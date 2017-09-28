using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace OfficeOilToolKits
{
    public partial class FormWeb : Form
    {
        public FormWeb()
        {
            InitializeComponent();
            Cursor.Current = Cursors.WaitCursor;
            string filePathSVG = @"d:\123.svg";
            if(File.Exists(filePathSVG))  this.wbMain.Navigate(new Uri(filePathSVG));
            Cursor.Current = Cursors.Default;
        }
    }
}
