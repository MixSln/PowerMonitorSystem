using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerDistributionSystem.Model
{
    class DeviceMonitor
    {
        public DateTime StatusDate { get; set; }
        public int DevId { get; set; }
        public int VoltageA { get; set; }
        public int VoltageB { get; set; }
        public int VoltageC { get; set; }
        public int VoltageAB { get; set; }
        public int VoltageCA { get; set; }
        public int VoltageBC { get; set; }
        public int CurrentA { get; set; }
        public int CurrentB { get; set; }
        public int CurrentC { get; set; }
        public int RealPowerA { get; set; }
        public int RealPowerB { get; set; }
        public int RealPowerC { get; set; }
        public int RealPowerTotal { get; set; }
        public int ReactivePowerA { get; set; }
        public int ReactivePowerB { get; set; }
        public int ReactivePowerC { get; set; }
        public int ReactivePowerTotal { get; set; }
        public int ApparentPowerTotal { get; set; }
        public float PowerFactor { get; set; }
        public float Frequency { get; set; }
        public float ActivePowerEnergyPositive { get; set; }
        public float ActivePowerEnergyNegative { get; set; }
        public float ReactivePowerEnergyPositive { get; set; }
        public float ReactivePowerEnergyNegative { get; set; }
        public int SwitchValue { get; set; }
    }
}


