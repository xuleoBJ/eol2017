using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Collections;

namespace OfficeOilToolKits
{
    public partial class FormIP : Form
    {
        private ArrayList _Profiles = new ArrayList();
        /// <summary>
        /// Returns the current NICName
        /// </summary>
        private string _NICName
        {
            get
            {
                return cboNIC.SelectedItem as string;
            }
        }
        public FormIP()
        {
            InitializeComponent();
            loadApp();
        }
        private void loadApp()
        {
            loadProfiles();
            loadCurrentProxySetting();
        }

        /// <summary>
        /// Displayes current proxy setting for Internet Explorer
        /// </summary>
        private void loadCurrentProxySetting()
        {
            if (IEProxy.ProxyEnabled)
                lblCurrentProxy.Text = IEProxy.ProxyServer;
            else
                lblCurrentProxy.Text = "No Proxy";

            if (IEProxy.BypassProxyForLocal)
                lblCurrentProxy.Text += ". Bypass local";
            else
                lblCurrentProxy.Text += ". Do not bypass local";
        }
        /// <summary>
        /// Load profile from configuration file
        /// </summary>
        private void loadProfiles()
        {
            _Profiles = ConfigurationHelper.LoadConfig();

            // populate the profile drop down list
            cboProfiles.Items.Clear();
            foreach (Profile profile in _Profiles)
            {
                cboProfiles.Items.Add(profile.Name);
            }
        }

        private void btnNewProfile_Click(object sender, EventArgs e)
        {
            createNewProfile();
        }
        private void createNewProfile()
        {
            using (NewProfileDialog newProfileDialog = new NewProfileDialog())
            {

                if (DialogResult.OK == newProfileDialog.ShowDialog(this))
                {
                    // create a new profile object
                    Profile newProfile = new Profile(newProfileDialog.NewProfileName);
                    _Profiles.Add(newProfile);

                    // show it in the drop down as selected
                    cboProfiles.SelectedIndex = cboProfiles.Items.Add(newProfile.Name);

                    // load the NIC list
                    loadNICs();
                }
            }
        }
        /// <summary>
        /// Apply currently selected profile
        /// </summary>
        private void applyProfile()
        {
            ApplySettingDialog applyDialog = new ApplySettingDialog();
            applyDialog.Show();
            applyDialog.Refresh();

            // Start applying setting
            applyDialog.ApplySetting(_CurrentProfile);

            // show current configuration after applying
            loadCurrentSetting(_NICName);
            loadCurrentProxySetting();
        }

        /// <summary>
        /// Loads current network configuration for the specified NIC and show in 
        /// the current configuration block
        /// </summary>
        /// <param name="nicName"></param>
        private void loadCurrentSetting(string nicName)
        {

            string[] ipAddresses;
            string[] subnets;
            string[] gateways;
            string[] dnses;

            // Load current IP configuration for the selected NIC
            WMIHelper.GetIP(nicName, out ipAddresses, out subnets, out gateways, out dnses);

            // if network connection is disabled, no information will be available
            if (null == ipAddresses || null == subnets || null == gateways || null == dnses)
                return;

            // Show the setting
            lblCurrentIP.Text = string.Join(",", ipAddresses);
            lblCurrentSubnet.Text = string.Join(",", subnets);
            lblCurrentGateway.Text = string.Join(",", gateways);
            lblCurrentDNS.Text = string.Join(",", dnses);
        }
        
        private void close()
        {
            this.Close();
        }
        private void loadNICs()
        {
            // get the NIC names
            ArrayList nicNames = WMIHelper.GetNICNames();

            // populate the NIC list
            cboNIC.Items.Clear();
            foreach (string name in nicNames)
                cboNIC.Items.Add(name);

            // if NIC found, select the first one
            if (cboNIC.Items.Count > 0)
            {
                cboNIC.SelectedIndex = 0;
                grpNIC.Enabled = true;
            }
        }

        private void cboProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadProfile(_CurrentProfile);
        }

        /// <summary>
        /// Returns the currently selected profile object
        /// </summary>
        private Profile _CurrentProfile
        {
            get
            {
                // find the profile for the currently selected profile
                foreach (Profile profile in _Profiles)
                    if (profile.Name.Equals(_ProfileName))
                        return profile;

                return null;
            }
        }

        /// <summary>
        /// returns the current profile name
        /// </summary>
        private string _ProfileName
        {
            get
            {
                return cboProfiles.SelectedItem as string;
            }
        }
        /// <summary>
        /// Load a particular profile
        /// </summary>
        /// <param name="profile"></param>
        private void loadProfile(Profile profile)
        {
            // load the NIC list
            loadNICs();

            // load proxy setting
            loadIEProxy();

            btnActivate.Enabled = true;
        }

        /// <summary>
        /// Loads IE Proxy settings
        /// </summary>
        private void loadIEProxy()
        {
            IEProfile profile = _CurrentProfile.IEProfile;

            chkUseProxy.Checked = profile.UseProxy;
            chkByPassForLocal.Checked = profile.BypassLocal;
            //txtLocal.Text = profile.BypassAddresses;
            txtProxy.Text = profile.ProxyName;

            grpIEProxy.Enabled = true;
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            applyProfile();
        }
    }
}
