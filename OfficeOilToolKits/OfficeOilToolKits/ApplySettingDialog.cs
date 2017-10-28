using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OfficeOilToolKits
{
    public partial class ApplySettingDialog : Form
    {
        public ApplySettingDialog()
        {
            InitializeComponent();
        }

        private void ApplySettingDialog_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();		
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        internal void ApplySetting(Profile profile)
        {
            lblProfileName.Text = profile.Name;

            // Invole the profile manager to apply the profile
            ProfileManager manager = new ProfileManager(profile);
            manager.OnStatusUpdate += new StatusUpdate(manager_OnStatusUpdate);
            manager.Run();

            btnOK.Enabled = true;
        }

        /// <summary>
        /// Callback function for ProfileManager to show messages
        /// </summary>
        /// <param name="message"></param>
        private void manager_OnStatusUpdate(string message)
        {
            txtStatus.AppendText(message);
        }
    }
}
