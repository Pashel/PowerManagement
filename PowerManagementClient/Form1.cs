using System;
using System.ComponentModel;
using System.Windows.Forms;
using PowerManagement;

namespace PowerManagementClient
{
    public partial class PowerManagementForm : Form
    {
        private readonly IPowerManager _manager;

        public PowerManagementForm()
        {
            _manager = new PowerManager();
            InitializeComponent();
        }

        private void LastSleepTime_Click(object sender, EventArgs e)
        {
            try {
                var time = _manager.GetLastSleepTime();
                Output.Text = $"Last system sleep time - {time}";
            }
            catch (Win32Exception exception) {
                Output.Text = exception.Message;
            }
        }

        private void LastWakeTime_Click(object sender, EventArgs e)
        {
            try {
                var time = _manager.GetLastWakeTime();
                Output.Text = $"Last system wake time - {time}";
            }
            catch (Win32Exception exception) {
                Output.Text = exception.Message;
            }
        }

        private void SystemBatteryState_Click(object sender, EventArgs e)
        {
            try {
                var state = _manager.GetSystemBatteryState();
                Output.Text = $"Works from socket - {state.AcOnLine}";
            }
            catch (Win32Exception exception) {
                Output.Text = exception.Message;
            }
        }

        private void SystemPowerInformation_Click(object sender, EventArgs e)
        {
            try {
                var state = _manager.GetSystemPowerInformation();
                Output.Text = $"The current idle level - {state.Idleness}%";
            }
            catch (Win32Exception exception) {
                Output.Text = exception.Message;
            }
        }

        private void ReserveHibernationFile_Click(object sender, EventArgs e)
        {
            try {
                _manager.ReserveHibernationFile();
                Output.Text = "Done";
            }
            catch (Win32Exception exception) {
                Output.Text = exception.Message;
            }
        }

        private void DeleteHibernationFile_Click(object sender, EventArgs e)
        {
            try {
                _manager.DeleteHibernationFile();
                Output.Text = "Done";
            }
            catch (Win32Exception exception) {
                Output.Text = exception.Message;
            }
        }

        private void HibernateSystem_Click(object sender, EventArgs e)
        {
            try {
                _manager.HibernateSystem();
                Output.Text = "Done";
            }
            catch (Win32Exception exception) {
                Output.Text = $"{exception.ErrorCode} - {exception.Message}";
            }
        }

        private void SuspendSystem_Click(object sender, EventArgs e)
        {
            try {
                _manager.SuspendSystem();
                Output.Text = "Done";
            }
            catch (Win32Exception exception) {
                Output.Text = $"{exception.ErrorCode} - {exception.Message}";
            }
        }
    }
}