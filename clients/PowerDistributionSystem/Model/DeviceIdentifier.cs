using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerDistributionSystem.Model
{
    class DeviceIdentifier
    {
        public string AddressCode { get; set; }
        public string Label { get; set; }
        public bool Usable { get; set; }
    }
}
