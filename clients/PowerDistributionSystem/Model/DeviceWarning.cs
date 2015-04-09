using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerDistributionSystem.Model
{
    class DeviceWarning
    {
        public int DevId { get; set; }
        public DateTime WarningTime { get; set; }
        public string WarningDesc { get; set; }
        public string WarningValue { get; set; }
        public string WarningContent { get; set; }
        public DateTime ProcessTime { get; set; }
        public int ProcessUserId { get; set; }
        public int DisableTime { get; set; }
    }
}
