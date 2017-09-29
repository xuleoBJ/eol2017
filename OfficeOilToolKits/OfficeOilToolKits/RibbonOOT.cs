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
using Newtonsoft.Json;
using System.Windows.Forms ;


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
            string fPath = @"E:\EOL2017\eol2017\pythonScript\data.json";
            StreamReader sr = new StreamReader(fPath, Encoding.Default);
            string jsonText = sr.ReadToEnd();
            sr.Close();
            Dictionary<string, string> jo = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonText);
            cSVG svgChinaMap = new cSVG();
            foreach (var item in jo)
            {
                svgChinaMap.addPath(item.Key, item.Value);
            }
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

        private void btnVolSedi_Click(object sender, RibbonControlEventArgs e)
        {
            Excel.Workbook wb = Globals.ThisAddIn.Application.ActiveWorkbook;
            Excel.Worksheet curSheet = wb.Sheets.Add();
            
            curSheet.Cells[1, 1].Value = "静止清水中沉积物沉降速度(Rubey,1931)";
            curSheet.Cells[1, 2].Value = "mm/s";
            curSheet.Cells[2, 1].Value = "沉积物";
            curSheet.Cells[2, 2].Value = "沉降速度";
            curSheet.Cells[3, 1].Value = "极细砂";
            curSheet.Cells[3, 2].Value = ">3.82";
            curSheet.Cells[4, 1].Value = "粗粉砂";
            curSheet.Cells[4, 2].Value = "0.96-3.84";
            curSheet.Cells[5, 1].Value = "中等粉砂";
            curSheet.Cells[5, 2].Value = "0.24-0.96";
            curSheet.Cells[6, 1].Value = "细粉砂";
            curSheet.Cells[6, 2].Value = "0.06-0.24";
            curSheet.Cells[7, 1].Value = "极细粉砂";
            curSheet.Cells[7, 2].Value = "0.015-0.06";
            curSheet.Cells[8, 1].Value = "粗粘土";
            curSheet.Cells[8, 2].Value = "0.00375-0.015";
            curSheet.Cells[9, 1].Value = "中等粘土";
            curSheet.Cells[9, 2].Value = "0.0009375-0.00375";
            curSheet.Cells[10, 1].Value = "细粉砂";
            curSheet.Cells[10, 2].Value = "<0.0009375";

            curSheet.Columns.AutoFit();

            string sheetName = "静止清水中沉积物沉降速度";
            if (cPublicMethod.IsExsitSheet(wb, sheetName) == false) curSheet.Name = sheetName;
            else MessageBox.Show("当前表单名已存在");
        }

        private void btnDrawLog_Click(object sender, RibbonControlEventArgs e)
        {
            Excel.Workbook wb = Globals.ThisAddIn.Application.ActiveWorkbook;
            Excel.Worksheet curSheet = Globals.ThisAddIn.Application.ActiveSheet;
            //read data
            List<double> ltValue = new List<double>();
            for (int i = 1; i < 100; i++) 
            {
                double _value = Convert.ToDouble(curSheet.Cells[i, 1].Value);
                ltValue.Add(_value);
            }
            //
        }
    }
}
