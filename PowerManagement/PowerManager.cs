using System;
using PowerManagement.Data;

namespace PowerManagement
{
    public class PowerManager : PowerManagerWrapper, IPowerManager
    {
        public TimeSpan GetLastSleepTime()
        {
            var result = GetNtPowerInformation<UInt64>(Information.LastSleepTime);
            TimeSpan timeSpan = TimeSpan.FromSeconds(result / Math.Pow(10, 7));
            return timeSpan;
        }

        public TimeSpan GetLastWakeTime()
        {
            var result = GetNtPowerInformation<UInt64>(Information.LastWakeTime);
            TimeSpan timeSpan = TimeSpan.FromSeconds(result / Math.Pow(10, 7));
            return timeSpan;
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

        public void HibernateSystem()
        {
            SuspendSystem(true);
        }

        public void SuspendSystem()
        {
            SuspendSystem(false);
        }
    }
}
