using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace OfflineJudgeApp.Model
{
    class Directories
    {
        
        private static readonly string Root = Directory.GetCurrentDirectory();
        private static readonly string BaseDir = @"\BASE";
        private static readonly string MainDir = @"\MAIN";
        private static readonly string OutputDir = @"\OUT";
        private static readonly string SysTestIn = @"\TESTIN";
        private static readonly string SysTestOut = @"\TESTOUT";
        public static string CustomOutputDir { get; set; }
        public static string InputDir { get; set; }
        public static string TestOutputDir { get; set; }
        public static string DataTest { get; set; }

         

        //create directory
        public static void CreateMainDir()
        {
            Directory.CreateDirectory(Root + BaseDir + MainDir);
        }
        public static void CreateOutDir()
        {
            Directory.CreateDirectory(Root + BaseDir + OutputDir);
        }
        public static void CreateTestInDir()
        {
            Directory.CreateDirectory(Root + BaseDir + SysTestIn);
        }
        public static void CreateTestOutDir()
        {
            Directory.CreateDirectory(Root + BaseDir + SysTestOut);
        }
        public static void CreateAll()
        {
            CreateMainDir();
            CreateOutDir();
            CreateTestInDir();
            CreateTestOutDir();
        }
        //delete directory
        public static void DeleteMainDir()
        {
            Directory.Delete(Root + BaseDir + MainDir, true);
        }
        public static void DeleteOutDir()
        {
            Directory.Delete(Root + BaseDir + OutputDir, true);
        }
        public static void DeleteTestOutDir()
        {
            Directory.Delete(Root + BaseDir + SysTestOut, true);
        }
        public static void DeleteTestInDir()
        {
            Directory.Delete(Root + BaseDir + SysTestIn, true);
        }
        public static void DeleteAll()
        {
            DeleteMainDir();
            DeleteOutDir();
            DeleteTestInDir();
            DeleteTestOutDir();
        }
        //clear directory
        public static void ClearMainDir()
        {
            DirectoryInfo dir = new DirectoryInfo(GetMainDir());
            foreach (FileInfo file in dir.GetFiles())
            {
                File.SetAttributes(file.FullName, FileAttributes.Normal);
                File.Delete(file.FullName);
            }
        }
        public static void ClearOutDir()
        {
           if( Directory.Exists(GetOutDir()))
                {
                DirectoryInfo dir = new DirectoryInfo(GetOutDir());
                foreach (FileInfo file in dir.GetFiles())
                {
                    file.Delete();
                }
            }   
        }
        public static void ClearSysTestOutDir()
        {
            if (Directory.Exists(Root + BaseDir + SysTestOut))
            {
                DirectoryInfo dir = new DirectoryInfo(Root + BaseDir + SysTestOut);
                foreach (FileInfo file in dir.GetFiles())
                {
                    file.Delete();
                }
            }
        }
        public static void ClearSysTestInDir()
        {
            if (Directory.Exists(Root + BaseDir + SysTestIn))
            {
                DirectoryInfo dir = new DirectoryInfo(Root + BaseDir + SysTestIn);
                foreach (FileInfo file in dir.GetFiles())
                {
                    file.Delete();
                }
            }
        }
        public static void ClearCustomDir()
        {
            if(CustomOutputDir != null)
            {
                DirectoryInfo dir = new DirectoryInfo(CustomOutputDir);
                foreach (FileInfo file in dir.GetFiles())
                {
                    file.Delete();
                }
            }
        }
        public static void ClearAll()
        {
            ClearMainDir();
            ClearOutDir();
            ClearCustomDir();
        }
        //get directory
        public static string GetMainDir()
        {
            return Root + BaseDir + MainDir;
        }
        public static string GetOutDir()
        {
            if(CustomOutputDir == null)
                return Root + BaseDir + OutputDir;
            return CustomOutputDir;
        }
        public static string GetSysTestInDir()
        {
            return Root + BaseDir + SysTestIn;
        }
        public static string GetSysTestOutDir()
        {
            return Root + BaseDir + SysTestOut;
        }
        public static string GetTestOutputDir()
        {
            if(TestOutputDir != null)
                return TestOutputDir;
            return Root + BaseDir + SysTestOut;
        }
        public static string GetTestInputDir()
        {
            if (InputDir != null)
                return InputDir;
            return Root + BaseDir + SysTestIn;

        }
        //check directory
        public static Boolean isDirEmpty(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(@path);
            if(dir.GetFiles().Length > 0)
            {
                return false;
            }
            return true;
        }

        //check Dir C#
        public static string GetPathNetFramework()
        {
     
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Windows)+@"\Microsoft.NET\Framework64\"))
            {
                DirectoryInfo dir = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Windows) + @"\Microsoft.NET\Framework64\");
                Regex reg = new Regex(@"^v(?<version>\d)");
                string path = "";
                int maxVer = 0;
                foreach(DirectoryInfo subdir in dir.GetDirectories())
                {
                    if(reg.IsMatch(subdir.Name))
                    {
                        foreach(Match version in reg.Matches(subdir.Name))
                        {
                            int ver = int.Parse(version.Groups["version"].ToString());
                            if (ver == 4)
                            {
                                return subdir.FullName;
                            }
                            if (ver >= maxVer)
                            {
                                maxVer = ver;
                                path = subdir.FullName;
                            }      
                        }
                    }  
                }
                if (maxVer != 0)
                return path;
            }
            if(Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Windows) + @"\Microsoft.NET\Framework\"))
            {
                DirectoryInfo dir = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Windows) + @"\Microsoft.NET\Framework\");
                Regex reg = new Regex(@"^v(?<version>\d)");
                string path = "";
                int maxVer = 0;
                foreach (DirectoryInfo subdir in dir.GetDirectories())
                {
                    if (reg.IsMatch(subdir.Name))
                    {
                        foreach (Match version in reg.Matches(subdir.Name))
                        {
                            int ver = int.Parse(version.Groups["version"].ToString());
                            if (ver == 4)
                            {
                                return subdir.FullName;
                            }
                            if (ver >= maxVer)
                            {
                                maxVer = ver;
                                path = subdir.FullName;
                            }
                        }
                    }
                }
                if (maxVer == 0)
                    return "None";
                return path;
            }
                return "None";
        }
    }
}
