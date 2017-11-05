using System;
using System.Runtime.InteropServices;
using  PowerManagement.Data;
using System.ComponentModel;

namespace PowerManagement
{
    public class PowerManagerWrapper
    {
        private const uint STATUS_SUCCESS = 0;

        [DllImport("powrprof.dll")]
        private static extern uint CallNtPowerInformation(
            int InformationLevel,
            IntPtr lpInputBuffer,
            int nInputBufferSize,
            IntPtr lpOutputBuffer,
            int nOutputBufferSize
        );

        [DllImport("Powrprof.dll", SetLastError = true)]
        private static extern bool SetSuspendState(bool hibernate, bool forceCritical, bool disableWakeEvent);

        protected T GetNtPowerInformation<T>(Information code)
        {
            var bufferSize = Marshal.SizeOf(typeof(T));
            IntPtr buffer = Marshal.AllocHGlobal(bufferSize);

            uint retval = CallNtPowerInformation(
                (int)code,
                IntPtr.Zero,
                0,
                buffer,
                bufferSize
            );

            if (retval != STATUS_SUCCESS) {
                Marshal.Release(buffer);
                throw new Win32Exception("CallNtPowerInformation failed");
            }

            var result = (T)Marshal.PtrToStructure(buffer, typeof(T));
            Marshal.Release(buffer);

            return result;
        }

        protected static void ManageHibernateFile(bool action)
        {
            int systemReserveHiberFile = 10;

            IntPtr ptr = Marshal.AllocHGlobal(sizeof(bool));
            Marshal.StructureToPtr(action, ptr, false);

            uint retval = CallNtPowerInformation(
                systemReserveHiberFile,
                ptr,
                sizeof(bool),
                IntPtr.Zero,
                0
            );

            Marshal.Release(ptr);

            if (retval != STATUS_SUCCESS) {
                throw new Win32Exception("Manage hibernate file failed");
            }
        }

        protected void SuspendSystem(bool action)
        {
            var result = SetSuspendState(action, false, false);

            if (!result) {
                var error = Marshal.GetLastWin32Error();
                throw new Win32Exception(error, "SetSuspendState failed");
            }
        }
    }
}
