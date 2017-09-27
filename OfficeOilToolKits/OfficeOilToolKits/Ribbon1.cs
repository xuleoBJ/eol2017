using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using System.Drawing;

namespace OfficeOilToolKits
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnInsertLine_Click(object sender, RibbonControlEventArgs e)
        {
            Excel.Range rng = Globals.ThisAddIn.Application.ActiveCell;
            rng = (Excel.Range)rng.Cells[rng.Rows.Count, 1];

            rng = rng.EntireRow;
            //当前设置插入5行
            for (int i = 0; i < 5; i++)
                rng.Insert(Excel.XlInsertShiftDirection.xlShiftDown);
        }
    }
}
