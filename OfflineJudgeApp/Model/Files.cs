using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfflineJudgeApp.Model
{
    class Files
    {   //general  
        public static readonly string PathFormat = @"\";
        public static readonly string FileName = "Main";
        public static readonly string TextFileType = ".txt";
        public static string AnswerFileType = ".ans";
        public static string OutputFileType = ".out";
        public static string customFileType = ".txt";
        //java
        public static readonly string JavaFileType = ".java";
        //c#
        public static readonly string CSharpFileType = ".cs";
        public Files()
        {

        }
        //java
        public static string GetJavaFilePath()
        {
            return Directories.GetMainDir() + PathFormat + FileName + JavaFileType;
        }
        public static string GetCSharpFilePath()
        {
            return Directories.GetMainDir() + PathFormat + FileName + CSharpFileType;
        }
        //c#

        //general
        public static void CreateFile(string path)
        {
            File.Create(path);
        }
        public static void DeleteFile(string Path)
        {
            File.Delete(Path);
        }
        public static void WriteTextToFile(string Path, string[] Text)
        {
            File.WriteAllLines(Path, Text);
        }
        public static void CopyTestFilesToSysFolder(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(Model.Directories.DataTest);
            foreach(FileInfo File in dir.GetFiles())
            {
                if(File.Extension.Equals(".in"))
                {
                    File.CopyTo(Directories.GetSysTestInDir() + @"\" + File.Name);
                }
                if(File.Extension.Equals(".out"))
                {
                    File.CopyTo(Directories.GetSysTestOutDir() + @"\" + File.Name);
                }
            }
        }
        public static string[] GetFileContent(string Path)
        {

            return File.ReadAllLines(Path);
        }       
        public static string GetFileContentText(string Path)
        {
            return File.ReadAllText(Path);
        }
        public static string[] GetInputFilePaths(string Path)
        {

            DirectoryInfo Dir = new DirectoryInfo(Path);
            string[] FilePaths = new string[Dir.GetFiles().Length];
            int i = 0;
            foreach (FileInfo File in Dir.GetFiles())
            {
                string Name = Path + @"\" + File.Name;
                FilePaths[i++] = Name;
            }
            return FilePaths;
        }
        public static string[] GetOutputFilePaths(string Path)
        {
            string OutType = TextFileType;
            if(customFileType.Equals(OutputFileType))
            {
                OutType = OutputFileType;
            }
            if (customFileType.Equals(AnswerFileType))
            {
                OutType = AnswerFileType;
            }
            DirectoryInfo Dir = new DirectoryInfo(Path);
            string[] FilePaths = new string[Dir.GetFiles().Length];
            int i = 0;
            foreach (FileInfo File in Dir.GetFiles())
            {
                int Index = File.Name.LastIndexOf('.');
                string Temp = File.Name.Substring(0, Index);
                string Name = Directories.GetOutDir() + @"\" + Temp + OutType;
                FilePaths[i++] = Name;
            }
            return FilePaths;
        }
        public static string[] GetRunJavaCommands(string Path)
        {
            string OutType = TextFileType;
            if (customFileType.Equals(OutputFileType))
            {
                OutType = OutputFileType;
            }
            if (customFileType.Equals(AnswerFileType))
            {
                OutType = AnswerFileType;
            }
            DirectoryInfo Dir = new DirectoryInfo(Path);
            string[] Commands = new string[Dir.GetFiles().Length];
            int i = 0;
            foreach (FileInfo File in Dir.GetFiles())
            {
                int Index = File.Name.LastIndexOf('.');
                string Temp = File.Name.Substring(0, Index);
                string Command = "java Main < " + '"' + Path + @"\" + File.Name + '"' + " > " + '"' + Directories.GetOutDir() + @"\" + Temp + OutType + '"';
                Commands[i++] = Command;
            }
            return Commands;
        }
        public static string[] GetRunCSharpCommands(string Path)
        {
            string OutType = TextFileType;
            if (customFileType.Equals(OutputFileType))
            {
                OutType = OutputFileType;
            }
            if (customFileType.Equals(AnswerFileType))
            {
                OutType = AnswerFileType;
            }
            DirectoryInfo Dir = new DirectoryInfo(Path);
            string[] Commands = new string[Dir.GetFiles().Length];
            int i = 0;
            foreach (FileInfo File in Dir.GetFiles())
            {
                int Index = File.Name.LastIndexOf('.');
                string Temp = File.Name.Substring(0, Index);
                string Command = "Main < " + '"' + Path + @"\" + File.Name + '"' + " > " + '"' + Directories.GetOutDir() + @"\" + Temp + OutType + '"';
                Commands[i++] = Command;
            }
            return Commands;
        }
        public static Boolean IsFileExist(string Path)
        {
            if (File.Exists(Path))
            {
                return true;
            }
            return false;
        }
        public static Boolean IsFileEmpty(string Path)
        {
            if(new FileInfo(Path).Length > 0)
            {
                return false;
            }
            return true;
        }
        
    }
}
