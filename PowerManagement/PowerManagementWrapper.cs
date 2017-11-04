﻿using System;
using System.Runtime.InteropServices;
using  PowerManagement.Data;
using System.ComponentModel;

namespace PowerManagement
{
    internal class PowerManagementWrapper
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

            if (retval != STATUS_SUCCESS)
            {
                Marshal.Release(buffer);
                throw new Win32Exception((int)retval, "CallNtPowerInformation failed code");
            }

            var result = (T)Marshal.PtrToStructure(buffer, typeof(T));
            Marshal.Release(buffer);

            return result;
        }
    }
}