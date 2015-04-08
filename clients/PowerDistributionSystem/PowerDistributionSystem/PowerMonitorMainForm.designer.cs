namespace PowerDistributionSystem
{
    partial class PowerMonitorMainForm
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.sub_usermanagement = new System.Windows.Forms.ToolStripMenuItem();
            this.usermanage_usermanage = new System.Windows.Forms.ToolStripMenuItem();
            this.usermanage_changepass = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_deviceManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_distribution = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_predevice = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_device = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_deviceMonitor = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_deviceStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceMonitor = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceWarning = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_historyQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceMonitorHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.warningHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.logHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_systemControl = new System.Windows.Forms.ToolStripMenuItem();
            this.message = new System.Windows.Forms.ToolStripMenuItem();
            this.service = new System.Windows.Forms.ToolStripMenuItem();
            this.advertisement = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sub_usermanagement,
            this.sub_deviceManagement,
            this.sub_deviceMonitor,
            this.sub_historyQuery,
            this.sub_systemControl});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(944, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // sub_usermanagement
            // 
            this.sub_usermanagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usermanage_usermanage,
            this.usermanage_changepass});
            this.sub_usermanagement.Name = "sub_usermanagement";
            this.sub_usermanagement.Size = new System.Drawing.Size(67, 20);
            this.sub_usermanagement.Text = "用户管理";
            // 
            // usermanage_usermanage
            // 
            this.usermanage_usermanage.Name = "usermanage_usermanage";
            this.usermanage_usermanage.Size = new System.Drawing.Size(134, 22);
            this.usermanage_usermanage.Text = "用户增删改";
            // 
            // usermanage_changepass
            // 
            this.usermanage_changepass.Name = "usermanage_changepass";
            this.usermanage_changepass.Size = new System.Drawing.Size(134, 22);
            this.usermanage_changepass.Text = "修改密码";
            // 
            // sub_deviceManagement
            // 
            this.sub_deviceManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sub_distribution,
            this.sub_predevice,
            this.sub_device});
            this.sub_deviceManagement.Name = "sub_deviceManagement";
            this.sub_deviceManagement.Size = new System.Drawing.Size(67, 20);
            this.sub_deviceManagement.Text = "设备管理";
            // 
            // sub_distribution
            // 
            this.sub_distribution.Name = "sub_distribution";
            this.sub_distribution.Size = new System.Drawing.Size(134, 22);
            this.sub_distribution.Text = "配电室管理";
            this.sub_distribution.Click += new System.EventHandler(this.sub_distribution_Click);
            // 
            // sub_predevice
            // 
            this.sub_predevice.Name = "sub_predevice";
            this.sub_predevice.Size = new System.Drawing.Size(134, 22);
            this.sub_predevice.Text = "设备标签";
            // 
            // sub_device
            // 
            this.sub_device.Name = "sub_device";
            this.sub_device.Size = new System.Drawing.Size(134, 22);
            this.sub_device.Text = "设备管理";
            // 
            // sub_deviceMonitor
            // 
            this.sub_deviceMonitor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sub_deviceStatus,
            this.deviceMonitor,
            this.deviceWarning});
            this.sub_deviceMonitor.Name = "sub_deviceMonitor";
            this.sub_deviceMonitor.Size = new System.Drawing.Size(67, 20);
            this.sub_deviceMonitor.Text = "设备监控";
            // 
            // sub_deviceStatus
            // 
            this.sub_deviceStatus.Name = "sub_deviceStatus";
            this.sub_deviceStatus.Size = new System.Drawing.Size(146, 22);
            this.sub_deviceStatus.Text = "设备状态";
            // 
            // deviceMonitor
            // 
            this.deviceMonitor.Name = "deviceMonitor";
            this.deviceMonitor.Size = new System.Drawing.Size(146, 22);
            this.deviceMonitor.Text = "设备实时监控";
            // 
            // deviceWarning
            // 
            this.deviceWarning.Name = "deviceWarning";
            this.deviceWarning.Size = new System.Drawing.Size(146, 22);
            this.deviceWarning.Text = "设备告警";
            // 
            // sub_historyQuery
            // 
            this.sub_historyQuery.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deviceMonitorHistory,
            this.warningHistory,
            this.logHistory});
            this.sub_historyQuery.Name = "sub_historyQuery";
            this.sub_historyQuery.Size = new System.Drawing.Size(67, 20);
            this.sub_historyQuery.Text = "历史查询";
            // 
            // deviceMonitorHistory
            // 
            this.deviceMonitorHistory.Name = "deviceMonitorHistory";
            this.deviceMonitorHistory.Size = new System.Drawing.Size(146, 22);
            this.deviceMonitorHistory.Text = "设备监控历史";
            // 
            // warningHistory
            // 
            this.warningHistory.Name = "warningHistory";
            this.warningHistory.Size = new System.Drawing.Size(146, 22);
            this.warningHistory.Text = "告警历史";
            // 
            // logHistory
            // 
            this.logHistory.Name = "logHistory";
            this.logHistory.Size = new System.Drawing.Size(146, 22);
            this.logHistory.Text = "日志历史";
            // 
            // sub_systemControl
            // 
            this.sub_systemControl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.message,
            this.service,
            this.advertisement});
            this.sub_systemControl.Name = "sub_systemControl";
            this.sub_systemControl.Size = new System.Drawing.Size(67, 20);
            this.sub_systemControl.Text = "系统管理";
            // 
            // message
            // 
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(122, 22);
            this.message.Text = "系统消息";
            // 
            // service
            // 
            this.service.Name = "service";
            this.service.Size = new System.Drawing.Size(122, 22);
            this.service.Text = "联系客服";
            // 
            // advertisement
            // 
            this.advertisement.Name = "advertisement";
            this.advertisement.Size = new System.Drawing.Size(122, 22);
            this.advertisement.Text = "广告";
            // 
            // PowerMonitorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 576);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "PowerMonitorMainForm";
            this.Text = "智能配电系统";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem sub_usermanagement;
        private System.Windows.Forms.ToolStripMenuItem usermanage_usermanage;
        private System.Windows.Forms.ToolStripMenuItem usermanage_changepass;
        private System.Windows.Forms.ToolStripMenuItem sub_deviceManagement;
        private System.Windows.Forms.ToolStripMenuItem sub_deviceMonitor;
        private System.Windows.Forms.ToolStripMenuItem sub_distribution;
        private System.Windows.Forms.ToolStripMenuItem sub_predevice;
        private System.Windows.Forms.ToolStripMenuItem sub_device;
        private System.Windows.Forms.ToolStripMenuItem sub_deviceStatus;
        private System.Windows.Forms.ToolStripMenuItem deviceMonitor;
        private System.Windows.Forms.ToolStripMenuItem deviceWarning;
        private System.Windows.Forms.ToolStripMenuItem sub_historyQuery;
        private System.Windows.Forms.ToolStripMenuItem deviceMonitorHistory;
        private System.Windows.Forms.ToolStripMenuItem warningHistory;
        private System.Windows.Forms.ToolStripMenuItem logHistory;
        private System.Windows.Forms.ToolStripMenuItem sub_systemControl;
        private System.Windows.Forms.ToolStripMenuItem message;
        private System.Windows.Forms.ToolStripMenuItem service;
        private System.Windows.Forms.ToolStripMenuItem advertisement;
    }
}