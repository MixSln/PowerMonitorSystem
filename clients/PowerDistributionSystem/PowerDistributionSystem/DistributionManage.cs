﻿using System;
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

using PowerDistributionSystem.Controller;
using PowerDistributionSystem.Model;

namespace PowerDistributionSystem
{
    public partial class DistributionManage : Form
    {
        public DistributionManage()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;

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

        private void DistributionManage_Load(object sender, EventArgs e)
        {
            FillDistributionList();
        }

        private void FillDistributionList()
        {
            DistributionController dc = new DistributionController(db);

            this.dgDistribution.DataSource = dc.GetDistributionList();
            
        }

        private void menu_save_Click(object sender, EventArgs e)
        {
            if (dgDistribution.SelectedRows.Count == 0) {
                MessageBox.Show("please select row!");
                return;
            }
            DataGridViewRow selectedRow = dgDistribution.SelectedRows[0];
            if (selectedRow.IsNewRow)
            {
            }
            else {
                Distribution dist = new Distribution();
                dist.DistId = 
            }
        }

        private void menu_New_Click(object sender, EventArgs e)
        {

        }

        private void menu_delete_Click(object sender, EventArgs e)
        {

        }

    }
}
