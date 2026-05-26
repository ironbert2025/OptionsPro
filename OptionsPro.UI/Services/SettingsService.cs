using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OptionsPro.UI.Properties;

namespace Options.Application.Services
{
    public class SettingsService
    {
        //Broker
        public void SaveBroker(string broker)
        {
            Settings.Default.SelectedBroker = broker;

            Settings.Default.Save();
        }

        public string GetBroker()
        {
            string broker = Settings.Default.SelectedBroker;


            return Settings.Default.SelectedBroker;
        }

        //TargetPercent
        public int GetTargetPercent()
        {
            return Settings.Default.TargetPercent;
        }

        public void SaveTargetPercent(int value)
        {
            Settings.Default.TargetPercent = value;

            Settings.Default.Save();
        }

        //Position Size
        public double GetPositionPercent()
        {
            return Settings.Default.PositionPercent;
        }

        public void SavePositionPercent(double value)
        {
            Settings.Default.PositionPercent = value;

            Settings.Default.Save();
        }
    }
}
