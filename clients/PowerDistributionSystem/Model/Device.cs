using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerDistributionSystem.Model
{
    public class Device
    {
        public int DevId { get; set; }
        public string DevName { get; set; }
        public string AddressCode { get; set; }
        public float MaxCurrent { get; set; }
        public float WarningCurrent { get; set; }
        public float WarningVoltageHigh { get; set; }
        public float WarningVoltageLow { get; set; }
        public string DevStatus { get; set; }
    }
}

