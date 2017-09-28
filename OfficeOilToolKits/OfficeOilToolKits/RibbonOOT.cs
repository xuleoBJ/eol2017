using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using System.Drawing;
using OfficeOilToolKits.svg;
using System.IO;


namespace OfficeOilToolKits
{
    public partial class RibbonOOT
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

        private void btnChinaProvince_Click(object sender, RibbonControlEventArgs e)
        {
            string fPath= @"E:\EOL2017\eol2017\pythonScript\d.txt";
            StreamReader sr = new StreamReader(fPath, Encoding.Default);
            string d = sr.ReadToEnd();
            sr.Close();
            cSVG svgChinaMap = new cSVG();
            svgChinaMap.addPath(d);
            string fileName = "d:\\123.svg";
            svgChinaMap.makeSVGfile(fileName);
            FormWeb newForm = new FormWeb();
            newForm.Show();
        }

        private void btnWellPosition_Click(object sender, RibbonControlEventArgs e)
        {
            Excel.Workbook curWK = Globals.ThisAddIn.Application.ActiveWorkbook;
            Excel.Worksheet  curSheet = curWK.Sheets.Add();
            curSheet.Name = "井位图";
            curSheet.Cells[1, 1].Value = "井名";
            curSheet.Cells[1, 2].Value = "X";
            curSheet.Cells[1, 3].Value = "Y";
            curSheet.Cells[1, 4].Value = "井别";
        }
    }
}
