using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using System.Data;

using PowerMonitorSystem.controller;
using PowerMonitorSystem.model;

namespace PowerMonitorSystem.view
{
    public partial class DistributionManage : Form
    {
        public DistributionManage()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            db = factory.Create("PowerMonitor") as SqlDatabase;
        }

        public static SqlDatabase db = null;

        private void button1_Click(object sender, EventArgs e)
        {
            DistributionController dc = new DistributionController(db);

            Distribution dist = new Distribution();
            dist.DistName = "dist1";
            dc.AddDistribution(dist);

        }
    }
}
