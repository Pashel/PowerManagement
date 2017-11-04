using System;
using PowerManagement.Data;

namespace PowerManagement
{
    public interface IPowerManagement
    {
        UInt64 GetLastSleepTime();
        UInt64 GetLastWakeTime();
        SYSTEM_BATTERY_STATE GetSystemBatteryState();
        SYSTEM_POWER_INFORMATION GetSystemPowerInformation();
        void ReserveHibernationFile();
        void DeleteHibernationFile();
        void HibernateSystem();
        void SuspendSystem();
    }
}
