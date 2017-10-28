﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

 using System.Security.Principal;
 using System.Security.AccessControl;

namespace OfficeOilToolKits
{
    class cIOBase
    {

        public static void AddFileSecurity(string fileName, string account,
          FileSystemRights rights, AccessControlType controlType)
        {

            // Get a FileSecurity object that represents the
            // current security settings.
            FileSecurity fSecurity = File.GetAccessControl(fileName);

            // Add the FileSystemAccessRule to the security settings.
            fSecurity.AddAccessRule(new FileSystemAccessRule(account,
                rights, controlType));

            // Set the new access settings.
            File.SetAccessControl(fileName, fSecurity);

        }

        // Removes an ACL entry on the specified file for the specified account.
        public static void RemoveFileSecurity(string fileName, string account,
            FileSystemRights rights, AccessControlType controlType)
        {

            // Get a FileSecurity object that represents the
            // current security settings.
            FileSecurity fSecurity = File.GetAccessControl(fileName);

            // Remove the FileSystemAccessRule from the security settings.
            fSecurity.RemoveAccessRule(new FileSystemAccessRule(account,
                rights, controlType));

            // Set the new access settings.
            File.SetAccessControl(fileName, fSecurity);

        }

        public static bool GrantAccess(string fullPath)
        {
            DirectoryInfo dInfo = new DirectoryInfo(fullPath);
            DirectorySecurity dSecurity = dInfo.GetAccessControl();
            dSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
            dInfo.SetAccessControl(dSecurity);
            return true;
        }

        public static bool SetAccess(string user, string folder)
        {
            const FileSystemRights Rights = FileSystemRights.FullControl;

            // *** Add Access Rule to the actual directory itself
            var AccessRule = new FileSystemAccessRule(user, Rights,
                InheritanceFlags.None,
                PropagationFlags.NoPropagateInherit,
                AccessControlType.Allow);

            var Info = new DirectoryInfo(folder);
            var Security = Info.GetAccessControl(AccessControlSections.Access);
            bool Result;

            Security.ModifyAccessRule(AccessControlModification.Set, AccessRule, out Result);

            if (!Result) return false;

            // *** Always allow objects to inherit on a directory
            const InheritanceFlags iFlags = InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit;

            // *** Add Access rule for the inheritance
            AccessRule = new FileSystemAccessRule(user, Rights,
                iFlags,
                PropagationFlags.InheritOnly,
                AccessControlType.Allow);

            Security.ModifyAccessRule(AccessControlModification.Add, AccessRule, out Result);

            if (!Result) return false;

            Info.SetAccessControl(Security);

            return true;
        } 

        public static void splitFileByColumnIndex(string filename, int iIndex, string dirpathGoal, bool hasTitle, bool addTitle2File)
        {
            List<string> ltStrLine = new List<string>();
            List<string> ltStriIndex = new List<string>();
            string sHeadLine = "";

            int lineindex = 0;
            string[] split;
            using (StreamReader sr = new StreamReader(filename, Encoding.Default))
            {
                String line;
                while ((line = sr.ReadLine()) != null) //delete the line whose legth is 0
                {
                    lineindex++;
                    split = line.Trim().Split(new char[] { ' ', '\t', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                    if (hasTitle == true && lineindex == 1) sHeadLine = line;
                    else
                    {
                        if (split.Length >= iIndex)
                        {
                            ltStrLine.Add(line);
                            ltStriIndex.Add(split[iIndex - 1]);
                        }
                        else { MessageBox.Show("文件第" + lineindex.ToString() + "行列数不够。"); }

                    }
                }
            }

            if (Directory.Exists(dirpathGoal)) Directory.Delete(dirpathGoal, true);
            Directory.CreateDirectory(dirpathGoal);
            foreach (string sItem in ltStriIndex.Distinct())
            {
                string filepathGoal = Path.Combine(dirpathGoal, sItem + ".txt");
                StreamWriter swNewFile = new StreamWriter(filepathGoal, false, Encoding.UTF8);
                for (int i = 0; i <= ltStrLine.Count; i++)
                {
                    split = ltStrLine[i].Trim().Split(new char[] { ' ', '\t', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                    if (split[iIndex] == sItem)
                        swNewFile.WriteLine(ltStrLine);
                }
                swNewFile.Close();
            }
        }

        public static void joinFile(string[] filenameList, string filepathGoal)
        {
            StreamWriter swNewFile = new StreamWriter(filepathGoal, false, Encoding.UTF8);
            foreach (string filename in filenameList)
            {
                using (StreamReader sr = new StreamReader(filename, Encoding.Default))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null) //delete the line whose legth is 0
                    {
                        swNewFile.Write(line);
                    }
                }
            }
            swNewFile.Close();
        }
        /// <summary>
        /// 按列 得到一个ltStr
        /// </summary>
        /// <param name="filepath">
        /// 文件名
        /// </param>
        /// <param name="iIndex">
        /// 列指数 从0开始数
        /// </param>
        /// <param name="iStartLine">
        /// 行指数，从0开始数
        /// </param>
        /// <returns></returns>
        public static List<string> getStringListColumnFileByColumnIndex(string filepath, int iColumnIndex, int iStartLine)
        {
            List<string> ltStrReturn = new List<string>();

            int lineindex = 0;
            string[] split;
            using (StreamReader sr = new StreamReader(filepath, Encoding.Default))
            {

                String line;
                while ((line = sr.ReadLine()) != null) //delete the line whose legth is 0
                {
                    lineindex++;
                    split = line.Trim().Split(new char[] { ' ', '\t', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                    if (lineindex >= iStartLine && split.Length >= iColumnIndex + 1)
                        ltStrReturn.Add(split[iColumnIndex]);
                    else
                        MessageBox.Show(filepath + "文件第" + lineindex.ToString() + "行列数不够。");

                }
            }

            return ltStrReturn;
        }
      
        public static List<float> getFloatListColumnFileByColumnIndex(string filepath, int iIndex, int iStartLine)
        {
            List<float> fListReturn = new List<float>();

            int lineindex = 0;
            string[] split;
            using (StreamReader sr = new StreamReader(filepath, Encoding.Default))
            {

                String line;
                while ((line = sr.ReadLine()) != null) //delete the line whose legth is 0
                {
                    lineindex++;
                    split = line.Trim().Split(new char[] { ' ', '\t', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                    if (lineindex >= iStartLine && split.Length >= iIndex)
                        fListReturn.Add(float.Parse(split[iIndex - 1]));
                    else
                        MessageBox.Show(filepath + "文件第" + lineindex.ToString() + "行列数不够。");

                }
            }

            return fListReturn;
        }

        public static List<string> getFileHeadColumnFromTextFirstLine(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                return reader.ReadLine().Split().ToList();
            }
        }

        /// <summary>
        /// read text file 2 ListString firstlineIndex=1
        /// 空行删除了
        /// </summary>
        /// <param name="filepath">text file path</param>
        /// <param name="iStartLine">startline</param>
        /// <returns></returns>
        public static List<string> readText2StringList(string filepath, int iStartLine)
        {
            List<string> ltStrReturn = new List<string>();
            int lineindex = 0;
            if (File.Exists(filepath))
            {
                using (StreamReader sr = new StreamReader(filepath, Encoding.Default))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null) //delete the line whose legth is 0
                    {
                        lineindex++;
                        if (lineindex >= iStartLine && line!="")
                            ltStrReturn.Add(line);
                    }
                }
            }
            return ltStrReturn;
        }

        public static List<string> getListStrFromStringListByFirstWord(List<string> listString, string sFirstWord)
        {
            List<string> ltStrReturn = new List<string>();
           
              foreach(string line in listString) 
                {
                    string[] split = line.Trim().Split(new char[] { ' ', '\t', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                    if (split.Length > 0)
                    {
                        if (split[0] == sFirstWord)
                            ltStrReturn.Add(line);
                    }
                }
            
            return ltStrReturn;
        }

        public static List<string> getListStrFromTextByFirstWord(string filepath, int iStartLine, string sFirstWord)
        {
            List<string> ltStrReturn = new List<string>();
            int lineindex = 0;
            string[] split;
            if (File.Exists(filepath))
            {
                using (StreamReader sr = new StreamReader(filepath, Encoding.UTF8))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null) //delete the line whose legth is 0
                    {
                        lineindex++;
                        split = line.Trim().Split(new char[] { ' ', '\t', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                        if (split.Length > 0)
                        {
                            if (lineindex >= iStartLine && split[0] == sFirstWord)
                                ltStrReturn.Add(line);
                        }

                    }
                }
            }

            return ltStrReturn;
        }
        public static List<string> getListStrFromTextByFirstWord(string filepath, string sFirstWord)
        {
            return getListStrFromTextByFirstWord(filepath, 0, sFirstWord);
        }

        public static void write2file(string strText, string filePath)
        {
            try
            {
                StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8);
                sw.Write(strText);
                sw.Close();

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }

        }

        public static void write2file(List<string> ltStrLine, string filePath)
        {
            try
            {
                StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8);
                foreach (string _line in ltStrLine) sw.WriteLine(_line.TrimEnd());
                sw.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }

        }

        public static void creatTextFile(List<string> ltStrHead, List<string> ltStrLineData, string filePath)
        {
            try
            {
                StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8);
                sw.WriteLine(string.Join("\t", ltStrHead));
                foreach (string _line in ltStrLineData) sw.WriteLine(_line.TrimEnd());
                sw.Close();

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }

        }
     

        //按词列指数删除文件
        public static void deleteLinesByWordColumnIndexFromText(string filePathOriginal, string filePathGoal, int iDeleteColumnIndex,
            List<string> ltStr)
        {
            StreamWriter sw = new StreamWriter(filePathGoal, false, Encoding.UTF8);
            int _lineindex = 0;
            string[] split;
            using (StreamReader sr = new StreamReader(filePathOriginal, Encoding.Default))
            {
                String line;
                while ((line = sr.ReadLine()) != null) //delete the line whose legth is 0
                {
                    _lineindex++;
                    split = line.Trim().Split(new char[] { ' ', '\t', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                    if (ltStr.Contains(split[iDeleteColumnIndex])) sw.WriteLine(line);
                }
            }
            sw.Close();

        }

        public static void deleteLinesByFirstWordFromText(string filePathOriginal, string filePathGoal, List<string> ltStr)
        {
            StreamWriter sw = new StreamWriter(filePathGoal, false, Encoding.UTF8);
            int _lineindex = 0;
            string[] split;
            using (StreamReader sr = new StreamReader(filePathOriginal, Encoding.Default))
            {
                String line;
                while ((line = sr.ReadLine()) != null) //delete the line whose legth is 0
                {
                    _lineindex++;
                    split = line.Trim().Split(new char[] { ' ', '\t', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                    if (ltStr.Contains(split[0])) sw.WriteLine(line);
                }
            }
            sw.Close();

        }








    }
}
