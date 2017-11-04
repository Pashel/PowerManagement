using System;
using PowerManagement.Data;
using System.Runtime.InteropServices;

namespace PowerManagement
{
    class PowerManagement : PowerManagementWrapper, IPowerManagement
    {
        public UInt64 GetLastSleepTime()
        {
            IntPtr buffer = Marshal.AllocHGlobal(sizeof(UInt64));
            GetNtPowerInformation(Information.LastSleepTime, buffer, sizeof(UInt64));
            var result = (UInt64)Marshal.PtrToStructure(buffer, typeof(UInt64));
            return result;
        }

        public UInt64 GetLastWakeTime()
        {
            IntPtr buffer = Marshal.AllocHGlobal(sizeof(UInt64));
            GetNtPowerInformation(Information.LastWakeTime, buffer, sizeof(UInt64));
            var result = (UInt64)Marshal.PtrToStructure(buffer, typeof(UInt64));
            return result;
        }

        public SYSTEM_BATTERY_STATE GetSystemBatteryState()
        {
            IntPtr buffer = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(SYSTEM_BATTERY_STATE)));
            GetNtPowerInformation(Information.SystemBatteryState, buffer, Marshal.SizeOf(typeof(SYSTEM_BATTERY_STATE)));
            var result = (SYSTEM_BATTERY_STATE)Marshal.PtrToStructure(buffer, typeof(SYSTEM_BATTERY_STATE));
            return result;
        }

        public SYSTEM_POWER_INFORMATION GetSystemPowerInformation()
        {
            IntPtr buffer = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(SYSTEM_POWER_INFORMATION)));
            GetNtPowerInformation(Information.SystemPowerInformation, buffer, Marshal.SizeOf(typeof(SYSTEM_POWER_INFORMATION)));
            var result = (SYSTEM_POWER_INFORMATION)Marshal.PtrToStructure(buffer, typeof(SYSTEM_POWER_INFORMATION));
            return result;
        }
    }
}
