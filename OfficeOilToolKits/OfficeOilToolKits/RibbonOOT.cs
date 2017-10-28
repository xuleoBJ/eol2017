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
using System.Diagnostics;


namespace OfficeOilToolKits
{
    public partial class RibbonOOT
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

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
            if (cPublicMethondExcel.IsExsitSheet(wb, sheetName) == false) curSheet.Name = sheetName;
            else MessageBox.Show("当前表单名已存在");
        }

        private void btnDrawLog_Click(object sender, RibbonControlEventArgs e)
        {
            Excel.Workbook wb = Globals.ThisAddIn.Application.ActiveWorkbook;
            Excel.Worksheet curSheet = Globals.ThisAddIn.Application.ActiveSheet;
            //read data
            string dataText = "D:\\GitHub\\test123.txt ";
            List<string> dataline = cIOBase.readText2StringList(dataText,1);

            Microsoft.Office.Interop.Excel.Shape shp = curSheet.Shapes.AddShape(Microsoft.Office.Core.MsoAutoShapeType.msoShapeRectangle, 30, 100, 300, 100);
            shp.Name = "Shape1";
            shp.TextFrame2.TextRange.Font.Fill.ForeColor.RGB = System.Drawing.Color.Gray.ToArgb();
            shp.Fill.ForeColor.RGB = System.Drawing.Color.White.ToArgb();
            shp.TextEffect.Text = "text123";
            int iLine = dataline.Count;
            Single[,] myPoints = new Single[iLine, 2];
            iLine = 200;
            for (int i = 0; i < iLine; i++)
            {
                //判断excel单元格值能否转为数字，不能转，删
                string[] dataValue = dataline[i].Split();
                myPoints[iLine, 0] = Convert.ToSingle(dataValue[1])*10;
                myPoints[iLine, 1] = Convert.ToSingle(dataValue[0]);
            }
            object po = myPoints;
            curSheet.Shapes.AddPolyline(po);
        }

        private void btnInsertColumns_Click(object sender, RibbonControlEventArgs e)
        {

        }

        private void btnbtnIP_Click(object sender, RibbonControlEventArgs e)
        {
            FormIP newForm = new FormIP();
            newForm.ShowDialog();
        }

        private void btnExploreSheet_Click(object sender, RibbonControlEventArgs e)
        {
            FormExplorSheet newForm = new FormExplorSheet();
            newForm.Show();
        }

        private void btnGetIP_Click(object sender, RibbonControlEventArgs e)
        {
            
            Process cmd = new Process();
            cmd.StartInfo.FileName = "ipconfig.exe";//设置程序名     
            cmd.StartInfo.Arguments = "/all";  //参数     
            //重定向标准输出     
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.StartInfo.CreateNoWindow = true;//不显示窗口（控制台程序是黑屏）     
            //cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;//暂时不明白什么意思     
            /*  
     收集一下 有备无患  
            关于:ProcessWindowStyle.Hidden隐藏后如何再显示？  
            hwndWin32Host = Win32Native.FindWindow(null, win32Exinfo.windowsName);  
            Win32Native.ShowWindow(hwndWin32Host, 1);     //先FindWindow找到窗口后再ShowWindow  
            */
            cmd.Start();
            string info = cmd.StandardOutput.ReadToEnd();
            cmd.WaitForExit();
            cmd.Close();
            string infoPath = "当前机器IP.txt";
            File.WriteAllText(infoPath, info);
            System.Diagnostics.Process.Start(infoPath);
        }
    }
}
