using System;
using PowerManagement.Data;

namespace PowerManagement
{
    class PowerManagement : PowerManagementWrapper, IPowerManagement
    {
        public UInt64 GetLastSleepTime()
        {
            var result = GetNtPowerInformation<UInt64>(Information.LastSleepTime);
            return result;
        }

        public UInt64 GetLastWakeTime()
        {
            var result = GetNtPowerInformation<UInt64>(Information.LastWakeTime);
            return result;
        }

        public SYSTEM_BATTERY_STATE GetSystemBatteryState()
        {
            var result = GetNtPowerInformation<SYSTEM_BATTERY_STATE>(Information.SystemBatteryState);
            return result;
        }

        public SYSTEM_POWER_INFORMATION GetSystemPowerInformation()
        {
            var result = GetNtPowerInformation<SYSTEM_POWER_INFORMATION>(Information.SystemPowerInformation);
            return result;
        }

        public void ReserveHibernationFile()
        {
            ManageHibernateFile(true);
        }

        public void DeleteHibernationFile()
        {
            ManageHibernateFile(false);
        }
    }
}
