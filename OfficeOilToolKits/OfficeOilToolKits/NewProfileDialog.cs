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
    public partial class NewProfileDialog : Form
    {
        public NewProfileDialog()
        {
            InitializeComponent();
        }

        #region Events

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }

        #endregion

        #region public properties

        public string NewProfileName
        {
            get
            {
                return txtName.Text;
            }
        }

        #endregion
    }
}
