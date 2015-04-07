using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerMonitorSystem.view
{
    public partial class PowerMonitorMainForm : Form
    {
        public PowerMonitorMainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void sub_distribution_Click(object sender, EventArgs e)
        {
            Form distDialog = new DistributionManage();
            distDialog.MdiParent = this;
            distDialog.Show();
        }

        
    }
}
