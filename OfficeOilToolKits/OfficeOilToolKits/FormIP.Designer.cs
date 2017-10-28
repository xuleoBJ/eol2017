namespace OfficeOilToolKits
{
    partial class FormIP
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
            this.grpProxy = new System.Windows.Forms.GroupBox();
            this.chkByPassForLocal = new System.Windows.Forms.CheckBox();
            this.txtProxy = new System.Windows.Forms.TextBox();
            this.lblProxy = new System.Windows.Forms.Label();
            this.grpCurrent = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCurrentDNS = new System.Windows.Forms.Label();
            this.lblCurrentGateway = new System.Windows.Forms.Label();
            this.lblCurrentSubnet = new System.Windows.Forms.Label();
            this.lblCurrentIP = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCurrentProxy = new System.Windows.Forms.Label();
            this.chkUseProxy = new System.Windows.Forms.CheckBox();
            this.grpIEProxy = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkDHCP = new System.Windows.Forms.CheckBox();
            this.txtDNS = new System.Windows.Forms.TextBox();
            this.btnActivate = new System.Windows.Forms.Button();
            this.txtGateway = new System.Windows.Forms.TextBox();
            this.lblProfile = new System.Windows.Forms.Label();
            this.grpNIC = new System.Windows.Forms.GroupBox();
            this.txtSubnet = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lblDNS = new System.Windows.Forms.Label();
            this.lblGateway = new System.Windows.Forms.Label();
            this.lblSubnet = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboNIC = new System.Windows.Forms.ComboBox();
            this.btnNewProfile = new System.Windows.Forms.Button();
            this.cboProfiles = new System.Windows.Forms.ComboBox();
            this.btnItemDel = new System.Windows.Forms.Button();
            this.grpProxy.SuspendLayout();
            this.grpCurrent.SuspendLayout();
            this.grpIEProxy.SuspendLayout();
            this.grpNIC.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpProxy
            // 
            this.grpProxy.Controls.Add(this.chkByPassForLocal);
            this.grpProxy.Controls.Add(this.txtProxy);
            this.grpProxy.Controls.Add(this.lblProxy);
            this.grpProxy.Location = new System.Drawing.Point(13, 69);
            this.grpProxy.Name = "grpProxy";
            this.grpProxy.Size = new System.Drawing.Size(768, 114);
            this.grpProxy.TabIndex = 12;
            this.grpProxy.TabStop = false;
            this.grpProxy.Text = "Proxy";
            // 
            // chkByPassForLocal
            // 
            this.chkByPassForLocal.Location = new System.Drawing.Point(102, 69);
            this.chkByPassForLocal.Name = "chkByPassForLocal";
            this.chkByPassForLocal.Size = new System.Drawing.Size(244, 22);
            this.chkByPassForLocal.TabIndex = 17;
            this.chkByPassForLocal.Text = "&Bypass for local address";
            // 
            // txtProxy
            // 
            this.txtProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProxy.Location = new System.Drawing.Point(102, 34);
            this.txtProxy.Name = "txtProxy";
            this.txtProxy.Size = new System.Drawing.Size(653, 28);
            this.txtProxy.TabIndex = 16;
            // 
            // lblProxy
            // 
            this.lblProxy.AutoSize = true;
            this.lblProxy.Location = new System.Drawing.Point(13, 34);
            this.lblProxy.Name = "lblProxy";
            this.lblProxy.Size = new System.Drawing.Size(62, 18);
            this.lblProxy.TabIndex = 15;
            this.lblProxy.Text = "Pro&xy:";
            // 
            // grpCurrent
            // 
            this.grpCurrent.Controls.Add(this.label2);
            this.grpCurrent.Controls.Add(this.label3);
            this.grpCurrent.Controls.Add(this.label4);
            this.grpCurrent.Controls.Add(this.label5);
            this.grpCurrent.Controls.Add(this.lblCurrentDNS);
            this.grpCurrent.Controls.Add(this.lblCurrentGateway);
            this.grpCurrent.Controls.Add(this.lblCurrentSubnet);
            this.grpCurrent.Controls.Add(this.lblCurrentIP);
            this.grpCurrent.Controls.Add(this.label6);
            this.grpCurrent.Controls.Add(this.lblCurrentProxy);
            this.grpCurrent.Location = new System.Drawing.Point(78, 478);
            this.grpCurrent.Name = "grpCurrent";
            this.grpCurrent.Size = new System.Drawing.Size(793, 183);
            this.grpCurrent.TabIndex = 25;
            this.grpCurrent.TabStop = false;
            this.grpCurrent.Text = "当前配置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "DNS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gateway:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Subnet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "IP:";
            // 
            // lblCurrentDNS
            // 
            this.lblCurrentDNS.AutoSize = true;
            this.lblCurrentDNS.Location = new System.Drawing.Point(102, 137);
            this.lblCurrentDNS.Name = "lblCurrentDNS";
            this.lblCurrentDNS.Size = new System.Drawing.Size(0, 18);
            this.lblCurrentDNS.TabIndex = 10;
            // 
            // lblCurrentGateway
            // 
            this.lblCurrentGateway.AutoSize = true;
            this.lblCurrentGateway.Location = new System.Drawing.Point(102, 103);
            this.lblCurrentGateway.Name = "lblCurrentGateway";
            this.lblCurrentGateway.Size = new System.Drawing.Size(0, 18);
            this.lblCurrentGateway.TabIndex = 9;
            // 
            // lblCurrentSubnet
            // 
            this.lblCurrentSubnet.AutoSize = true;
            this.lblCurrentSubnet.Location = new System.Drawing.Point(102, 69);
            this.lblCurrentSubnet.Name = "lblCurrentSubnet";
            this.lblCurrentSubnet.Size = new System.Drawing.Size(0, 18);
            this.lblCurrentSubnet.TabIndex = 8;
            // 
            // lblCurrentIP
            // 
            this.lblCurrentIP.AutoSize = true;
            this.lblCurrentIP.Location = new System.Drawing.Point(102, 34);
            this.lblCurrentIP.Name = "lblCurrentIP";
            this.lblCurrentIP.Size = new System.Drawing.Size(0, 18);
            this.lblCurrentIP.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Proxy:";
            // 
            // lblCurrentProxy
            // 
            this.lblCurrentProxy.AutoSize = true;
            this.lblCurrentProxy.Location = new System.Drawing.Point(410, 69);
            this.lblCurrentProxy.Name = "lblCurrentProxy";
            this.lblCurrentProxy.Size = new System.Drawing.Size(0, 18);
            this.lblCurrentProxy.TabIndex = 7;
            // 
            // chkUseProxy
            // 
            this.chkUseProxy.Location = new System.Drawing.Point(13, 34);
            this.chkUseProxy.Name = "chkUseProxy";
            this.chkUseProxy.Size = new System.Drawing.Size(128, 23);
            this.chkUseProxy.TabIndex = 14;
            this.chkUseProxy.Text = "&Use Proxy";
            // 
            // grpIEProxy
            // 
            this.grpIEProxy.Controls.Add(this.grpProxy);
            this.grpIEProxy.Controls.Add(this.chkUseProxy);
            this.grpIEProxy.Enabled = false;
            this.grpIEProxy.Location = new System.Drawing.Point(78, 284);
            this.grpIEProxy.Name = "grpIEProxy";
            this.grpIEProxy.Size = new System.Drawing.Size(793, 194);
            this.grpIEProxy.TabIndex = 24;
            this.grpIEProxy.TabStop = false;
            this.grpIEProxy.Text = "代理设置";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(742, 672);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(149, 33);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "关闭";
            // 
            // chkDHCP
            // 
            this.chkDHCP.Location = new System.Drawing.Point(13, 57);
            this.chkDHCP.Name = "chkDHCP";
            this.chkDHCP.Size = new System.Drawing.Size(256, 23);
            this.chkDHCP.TabIndex = 6;
            this.chkDHCP.Text = "Obtain IP from &DHCP";
            // 
            // txtDNS
            // 
            this.txtDNS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDNS.Location = new System.Drawing.Point(102, 194);
            this.txtDNS.Name = "txtDNS";
            this.txtDNS.Size = new System.Drawing.Size(679, 28);
            this.txtDNS.TabIndex = 13;
            // 
            // btnActivate
            // 
            this.btnActivate.Enabled = false;
            this.btnActivate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActivate.Location = new System.Drawing.Point(336, 672);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(149, 33);
            this.btnActivate.TabIndex = 26;
            this.btnActivate.Text = "应用";
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // txtGateway
            // 
            this.txtGateway.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGateway.Location = new System.Drawing.Point(102, 160);
            this.txtGateway.Name = "txtGateway";
            this.txtGateway.Size = new System.Drawing.Size(679, 28);
            this.txtGateway.TabIndex = 11;
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Location = new System.Drawing.Point(83, 11);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(89, 18);
            this.lblProfile.TabIndex = 20;
            this.lblProfile.Text = "配置选择:";
            // 
            // grpNIC
            // 
            this.grpNIC.Controls.Add(this.chkDHCP);
            this.grpNIC.Controls.Add(this.txtDNS);
            this.grpNIC.Controls.Add(this.txtGateway);
            this.grpNIC.Controls.Add(this.txtSubnet);
            this.grpNIC.Controls.Add(this.txtIP);
            this.grpNIC.Controls.Add(this.lblDNS);
            this.grpNIC.Controls.Add(this.lblGateway);
            this.grpNIC.Controls.Add(this.lblSubnet);
            this.grpNIC.Controls.Add(this.lblIP);
            this.grpNIC.Controls.Add(this.label1);
            this.grpNIC.Controls.Add(this.cboNIC);
            this.grpNIC.Enabled = false;
            this.grpNIC.Location = new System.Drawing.Point(78, 44);
            this.grpNIC.Name = "grpNIC";
            this.grpNIC.Size = new System.Drawing.Size(793, 240);
            this.grpNIC.TabIndex = 23;
            this.grpNIC.TabStop = false;
            this.grpNIC.Text = "IP 配置";
            // 
            // txtSubnet
            // 
            this.txtSubnet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubnet.Location = new System.Drawing.Point(102, 126);
            this.txtSubnet.Name = "txtSubnet";
            this.txtSubnet.Size = new System.Drawing.Size(679, 28);
            this.txtSubnet.TabIndex = 9;
            // 
            // txtIP
            // 
            this.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIP.Location = new System.Drawing.Point(102, 91);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(679, 28);
            this.txtIP.TabIndex = 7;
            // 
            // lblDNS
            // 
            this.lblDNS.AutoSize = true;
            this.lblDNS.Location = new System.Drawing.Point(13, 194);
            this.lblDNS.Name = "lblDNS";
            this.lblDNS.Size = new System.Drawing.Size(44, 18);
            this.lblDNS.TabIndex = 12;
            this.lblDNS.Text = "&DNS:";
            // 
            // lblGateway
            // 
            this.lblGateway.AutoSize = true;
            this.lblGateway.Location = new System.Drawing.Point(13, 160);
            this.lblGateway.Name = "lblGateway";
            this.lblGateway.Size = new System.Drawing.Size(80, 18);
            this.lblGateway.TabIndex = 10;
            this.lblGateway.Text = "&Gateway:";
            // 
            // lblSubnet
            // 
            this.lblSubnet.AutoSize = true;
            this.lblSubnet.Location = new System.Drawing.Point(13, 126);
            this.lblSubnet.Name = "lblSubnet";
            this.lblSubnet.Size = new System.Drawing.Size(71, 18);
            this.lblSubnet.TabIndex = 8;
            this.lblSubnet.Text = "&Subnet:";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(13, 91);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(35, 18);
            this.lblIP.TabIndex = 6;
            this.lblIP.Text = "&IP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "网卡";
            // 
            // cboNIC
            // 
            this.cboNIC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNIC.Location = new System.Drawing.Point(102, 23);
            this.cboNIC.Name = "cboNIC";
            this.cboNIC.Size = new System.Drawing.Size(672, 26);
            this.cboNIC.TabIndex = 5;
            // 
            // btnNewProfile
            // 
            this.btnNewProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewProfile.Location = new System.Drawing.Point(769, 9);
            this.btnNewProfile.Name = "btnNewProfile";
            this.btnNewProfile.Size = new System.Drawing.Size(102, 33);
            this.btnNewProfile.TabIndex = 22;
            this.btnNewProfile.Text = "&New...";
            this.btnNewProfile.Click += new System.EventHandler(this.btnNewProfile_Click);
            // 
            // cboProfiles
            // 
            this.cboProfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProfiles.Location = new System.Drawing.Point(180, 9);
            this.cboProfiles.Name = "cboProfiles";
            this.cboProfiles.Size = new System.Drawing.Size(576, 26);
            this.cboProfiles.TabIndex = 21;
            this.cboProfiles.SelectedIndexChanged += new System.EventHandler(this.cboProfiles_SelectedIndexChanged);
            // 
            // btnItemDel
            // 
            this.btnItemDel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnItemDel.Enabled = false;
            this.btnItemDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnItemDel.Location = new System.Drawing.Point(539, 672);
            this.btnItemDel.Name = "btnItemDel";
            this.btnItemDel.Size = new System.Drawing.Size(149, 33);
            this.btnItemDel.TabIndex = 28;
            this.btnItemDel.Text = "删除";
            // 
            // FormIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 715);
            this.Controls.Add(this.btnItemDel);
            this.Controls.Add(this.grpCurrent);
            this.Controls.Add(this.grpIEProxy);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.grpNIC);
            this.Controls.Add(this.btnNewProfile);
            this.Controls.Add(this.cboProfiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormIP";
            this.Text = "IP";
            this.grpProxy.ResumeLayout(false);
            this.grpProxy.PerformLayout();
            this.grpCurrent.ResumeLayout(false);
            this.grpCurrent.PerformLayout();
            this.grpIEProxy.ResumeLayout(false);
            this.grpNIC.ResumeLayout(false);
            this.grpNIC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpProxy;
        private System.Windows.Forms.CheckBox chkByPassForLocal;
        private System.Windows.Forms.TextBox txtProxy;
        private System.Windows.Forms.Label lblProxy;
        private System.Windows.Forms.GroupBox grpCurrent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCurrentDNS;
        private System.Windows.Forms.Label lblCurrentGateway;
        private System.Windows.Forms.Label lblCurrentSubnet;
        private System.Windows.Forms.Label lblCurrentIP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCurrentProxy;
        private System.Windows.Forms.CheckBox chkUseProxy;
        private System.Windows.Forms.GroupBox grpIEProxy;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chkDHCP;
        private System.Windows.Forms.TextBox txtDNS;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.TextBox txtGateway;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.GroupBox grpNIC;
        private System.Windows.Forms.TextBox txtSubnet;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label lblDNS;
        private System.Windows.Forms.Label lblGateway;
        private System.Windows.Forms.Label lblSubnet;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNIC;
        private System.Windows.Forms.Button btnNewProfile;
        private System.Windows.Forms.ComboBox cboProfiles;
        private System.Windows.Forms.Button btnItemDel;

    }
}