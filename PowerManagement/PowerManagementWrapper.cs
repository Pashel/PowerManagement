using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
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

        protected void GetNtPowerInformation(Information code, IntPtr buffer, int bufferSize)
        {
            uint retval = CallNtPowerInformation(
                (int)code,
                IntPtr.Zero,
                0,
                buffer,
                bufferSize
            );

            if (retval != STATUS_SUCCESS) {
                throw new Win32Exception((int)retval, "CallNtPowerInformation failed");
            }
        }
    }
}
