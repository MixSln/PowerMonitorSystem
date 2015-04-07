using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerMonitorSystem.model
{
    class Distribution
    {
        public int DistId{get;set;}
        public string DistName { get; set; }
        public string NickName { get; set; }
        public string DistAddress { get; set; }
        public string DistDesc { get; set; }
        public string Contact_primary { get; set; }
        public string PhoneNumber_primary { get; set; }
        public string Contact_bak1 { get; set; }
        public string PhoneNumber_bak1 { get; set; }
        public string Contact_bak2 { get; set; }
        public string PhoneNumber_bak2 { get; set; }

    }
}
