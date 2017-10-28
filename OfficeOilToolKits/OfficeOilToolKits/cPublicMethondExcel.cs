using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;

namespace OfficeOilToolKits
{
    class cPublicMethondExcel
    {
        public static bool IsExsitSheet(Excel.Workbook wb, string strSheetName)
        {
            // Keeping track
            // Loop through all worksheets in the workbook
            foreach (Excel.Worksheet sheet in wb.Sheets)
                if (sheet.Name == strSheetName) return true; // Check the name of the current sheet

            return false;
        }

        //get excle cell value，null return "", or return string type
        public static string getCellValue (Excel.Worksheet ws, int iRow,int jCol)
        {
            string cell_value="";
            Excel.Range cell = ws.Cells[iRow, jCol];//A1单元格
            return  cell_value = (cell.Value ?? "").ToString();
        }
    }
}
