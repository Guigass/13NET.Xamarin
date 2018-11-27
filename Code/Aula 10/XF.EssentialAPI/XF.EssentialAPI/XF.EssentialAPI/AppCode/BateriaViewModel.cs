using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Essentials;

namespace XF.EssentialAPI.AppCode
{
    public class BateriaViewModel : INotifyPropertyChanged
    {
        public BateriaViewModel()
        {

        }

        public double Level => Battery.ChargeLevel;
        public BatteryState State => Battery.State;
        public BatteryPowerSource PowerSource => Battery.PowerSource;
        public EnergySaverStatus EnergySaverStatus => Power.EnergySaverStatus;

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyname = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

        public void OnEnergySaverStatusChanged(object sender, EnergySaverStatusChangedEventArgs e)
        {
            OnPropertyChanged(nameof(EnergySaverStatus));
        }

        public void OnBatteryChanged(object sender, BatteryChangedEventArgs e)
        {
            OnPropertyChanged(nameof(Level));
            OnPropertyChanged(nameof(State));
            OnPropertyChanged(nameof(PowerSource));
        }
    }
}
