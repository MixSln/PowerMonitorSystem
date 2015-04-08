namespace PowerDistributionSystem
{
    partial class DistributionManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgDistribution = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DistId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact_primary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber_primary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact_bak1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber_bak1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact_bak2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber_bak2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menu_save = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_New = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgDistribution)).BeginInit();
            this.dgMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgDistribution
            // 
            this.dgDistribution.AllowUserToDeleteRows = false;
            this.dgDistribution.AllowUserToOrderColumns = true;
            this.dgDistribution.AllowUserToResizeRows = false;
            this.dgDistribution.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgDistribution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDistribution.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.DistId,
            this.DistName,
            this.Column1,
            this.DistAddress,
            this.Contact_primary,
            this.PhoneNumber_primary,
            this.Contact_bak1,
            this.PhoneNumber_bak1,
            this.Contact_bak2,
            this.PhoneNumber_bak2,
            this.DistDesc});
            this.dgDistribution.ContextMenuStrip = this.dgMenu;
            this.dgDistribution.Location = new System.Drawing.Point(2, 12);
            this.dgDistribution.MultiSelect = false;
            this.dgDistribution.Name = "dgDistribution";
            this.dgDistribution.Size = new System.Drawing.Size(927, 460);
            this.dgDistribution.TabIndex = 0;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.Width = 21;
            // 
            // DistId
            // 
            this.DistId.DataPropertyName = "DistId";
            this.DistId.HeaderText = "ID";
            this.DistId.Name = "DistId";
            this.DistId.ReadOnly = true;
            this.DistId.Width = 43;
            // 
            // DistName
            // 
            this.DistName.DataPropertyName = "DistName";
            this.DistName.HeaderText = "名称";
            this.DistName.Name = "DistName";
            this.DistName.Width = 56;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "NickName";
            this.Column1.HeaderText = "昵称";
            this.Column1.Name = "Column1";
            this.Column1.Width = 56;
            // 
            // DistAddress
            // 
            this.DistAddress.DataPropertyName = "DistAddress";
            this.DistAddress.HeaderText = "地址";
            this.DistAddress.Name = "DistAddress";
            this.DistAddress.Width = 56;
            // 
            // Contact_primary
            // 
            this.Contact_primary.DataPropertyName = "Contact_primary";
            this.Contact_primary.HeaderText = "主要联系人";
            this.Contact_primary.Name = "Contact_primary";
            this.Contact_primary.Width = 92;
            // 
            // PhoneNumber_primary
            // 
            this.PhoneNumber_primary.DataPropertyName = "PhoneNumber_primary";
            this.PhoneNumber_primary.HeaderText = "主要联系人电话";
            this.PhoneNumber_primary.Name = "PhoneNumber_primary";
            this.PhoneNumber_primary.Width = 85;
            // 
            // Contact_bak1
            // 
            this.Contact_bak1.DataPropertyName = "Contact_bak1";
            this.Contact_bak1.HeaderText = "备用联系人1";
            this.Contact_bak1.Name = "Contact_bak1";
            this.Contact_bak1.Width = 74;
            // 
            // PhoneNumber_bak1
            // 
            this.PhoneNumber_bak1.DataPropertyName = "PhoneNumber_bak1";
            this.PhoneNumber_bak1.HeaderText = "备用联系人1电话";
            this.PhoneNumber_bak1.Name = "PhoneNumber_bak1";
            this.PhoneNumber_bak1.Width = 90;
            // 
            // Contact_bak2
            // 
            this.Contact_bak2.DataPropertyName = "Contact_bak2";
            this.Contact_bak2.HeaderText = "备用联系人2";
            this.Contact_bak2.Name = "Contact_bak2";
            this.Contact_bak2.Width = 74;
            // 
            // PhoneNumber_bak2
            // 
            this.PhoneNumber_bak2.DataPropertyName = "PhoneNumber_bak2";
            this.PhoneNumber_bak2.HeaderText = "备用联系人2电话";
            this.PhoneNumber_bak2.Name = "PhoneNumber_bak2";
            this.PhoneNumber_bak2.Width = 90;
            // 
            // DistDesc
            // 
            this.DistDesc.DataPropertyName = "DistDesc";
            this.DistDesc.HeaderText = "说明";
            this.DistDesc.Name = "DistDesc";
            this.DistDesc.Width = 52;
            // 
            // dgMenu
            // 
            this.dgMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_save,
            this.menu_delete,
            this.menu_New});
            this.dgMenu.Name = "dgMenu";
            this.dgMenu.Size = new System.Drawing.Size(99, 70);
            // 
            // menu_save
            // 
            this.menu_save.Name = "menu_save";
            this.menu_save.Size = new System.Drawing.Size(152, 22);
            this.menu_save.Text = "保存";
            // 
            // menu_delete
            // 
            this.menu_delete.Name = "menu_delete";
            this.menu_delete.Size = new System.Drawing.Size(152, 22);
            this.menu_delete.Text = "删除";
            // 
            // menu_New
            // 
            this.menu_New.Name = "menu_New";
            this.menu_New.Size = new System.Drawing.Size(152, 22);
            this.menu_New.Text = "新建";
            // 
            // DistributionManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 484);
            this.Controls.Add(this.dgDistribution);
            this.Name = "DistributionManage";
            this.Text = "配电室管理";
            this.Load += new System.EventHandler(this.DistributionManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDistribution)).EndInit();
            this.dgMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDistribution;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact_primary;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber_primary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact_bak1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber_bak1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact_bak2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber_bak2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistDesc;
        private System.Windows.Forms.ContextMenuStrip dgMenu;
        private System.Windows.Forms.ToolStripMenuItem menu_save;
        private System.Windows.Forms.ToolStripMenuItem menu_delete;
        private System.Windows.Forms.ToolStripMenuItem menu_New;

    }
}