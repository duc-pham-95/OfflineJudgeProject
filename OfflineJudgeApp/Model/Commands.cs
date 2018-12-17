using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace OfflineJudgeApp.Model
{
    class Commands
    {
        private static readonly string Carries = @"/C ";
        private static readonly string CompileJava = "javac ";
        private static readonly string CompileCSharp = @"\csc.exe";
        public static string NetFrameWorkPath { get; set; }
        public static string StartupPath { get; set; }
        public static int Time = 5000;
        public static string ProcessCompileJava()
        {
            Process process = new Process();//khoi tao process
            ProcessStartInfo startInfo = new ProcessStartInfo();//khoi tao info chay cho process
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = Carries + CompileJava + '"' + Files.GetJavaFilePath() + '"';
            startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            process.StartInfo = startInfo;
            process.Start();//chay process
            /*luu ket qua*/
            string error = "";
            error = process.StandardError.ReadToEnd();
            return error;
        }
        public static Result ProcessRunJava(string command)
        {
            Process process = new Process(); //khoi tao process
            Result result = new Result(); //khoi tao doi tuong de luu tru ket qua tu process
            ProcessStartInfo StartInfo = new ProcessStartInfo();//khoi tao info chay cho process
            StartInfo.FileName = "cmd.exe";
            //StartInfo.Arguments = "/-cp "+'"' + Directories.GetMainDir() +'"' +" "+"Main";
            StartInfo.Arguments = Carries + "cd " + '"' + Directories.GetMainDir() + '"' + "&" + command;
            StartInfo.UseShellExecute = false;
            StartInfo.CreateNoWindow = true;
            StartInfo.RedirectStandardError = true;
            //StartInfo.RedirectStandardInput = true;
            //StartInfo.RedirectStandardOutput = true;
            process.StartInfo = StartInfo;
            process.Start();//chay process
            /*doc input*/
            //streamwriter sw = process.standardinput;
            //streamreader sr = process.standardoutput;
            //sw.writeline(fileinputcontent);
            //sw.close();
            /*kiem tra thoi gian chay*/
            Boolean TimeLimit = process.WaitForExit(Time);
            if (TimeLimit == false)
            {
                if(!process.HasExited)
                {
                    process.Kill();
                    foreach (var child in Process.GetProcessesByName("java"))
                    {
                        child.Kill();
                    }
                }
                result.Error = "Time Limit Exceeded";
                return result;
            }
            /*luu ket qua*/
            //result.Output = sr.ReadToEndAsync().ToString();
            //sr.Close();
            result.Error = process.StandardError.ReadToEnd();
            return result;
        }
        public static string ProcessCompileCSharp()
        {
            Regex reg = new Regex(@"(?<error>Main.cs.*)");
            Process process = new Process();//khoi tao process
            ProcessStartInfo startInfo = new ProcessStartInfo();//khoi tao info chay cho process
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = Carries + "cd " + '"' + Directories.GetMainDir() + '"' + "&" + '"' + StartupPath + '"' + " " + "Main.cs";
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            process.StartInfo = startInfo;
            process.Start();//chay process
            /*luu ket qua*/
            string error = "";
            string result = "";
            error = process.StandardOutput.ReadToEnd();
            foreach (Match item in reg.Matches(error))
            {
                result += item.Groups["error"].ToString();
            }
            return result;
        }
        public static Result ProcessRunCSharp(string command)
        {
            Process process = new Process(); //khoi tao process
            Result result = new Result(); //khoi tao doi tuong de luu tru ket qua tu process
            ProcessStartInfo StartInfo = new ProcessStartInfo();//khoi tao info chay cho process
            StartInfo.FileName = "cmd.exe";
            //StartInfo.Arguments = "-cp "+'"' + Directories.GetMainDir() +'"' +" "+"Main";
            StartInfo.Arguments = Carries + "cd " + '"' + Directories.GetMainDir() + '"' + "&" + command;
            StartInfo.UseShellExecute = false;
            StartInfo.CreateNoWindow = true;
            StartInfo.RedirectStandardError = true;
            //StartInfo.RedirectStandardInput = true;
            //StartInfo.RedirectStandardOutput = true;
            process.StartInfo = StartInfo;
            process.Start();//chay process
            /*doc input*/
            //streamwriter sw = process.standardinput;
            //streamreader sr = process.standardoutput;
            //sw.writeline(fileinputcontent);
            //sw.close();
            /*kiem tra thoi gian chay*/
            result.Error = process.StandardError.ReadToEnd();
            Boolean TimeLimit = process.WaitForExit(Time);
            if (TimeLimit == false)
            {
                process.Kill();
                foreach (var child in Process.GetProcessesByName("Main"))
                {
                    if (child.HasExited)
                        child.Kill();
                }
                result.Error = "Time Limit Exceeded";
                return result;
            }
            /*luu ket qua*/
            //result.Output = sr.ReadToEndAsync().ToString();
            //sr.Close();
            return result;
        }
        public static void OpenFolder(string path)
        {
            Process process = new Process(); //khoi tao process
            Result result = new Result(); //khoi tao doi tuong de luu tru ket qua tu process
            ProcessStartInfo StartInfo = new ProcessStartInfo();//khoi tao info chay cho process
            StartInfo.FileName = "explorer.exe";
            StartInfo.Arguments = path;
            process.StartInfo = StartInfo;
            process.Start();//chay process
        }
        public static void OpenFile(string path)
        {
            Process process = new Process(); //khoi tao process
            Result result = new Result(); //khoi tao doi tuong de luu tru ket qua tu process
            ProcessStartInfo StartInfo = new ProcessStartInfo();//khoi tao info chay cho process
            StartInfo.FileName = path;
            process.StartInfo = StartInfo;
            process.Start();//chay process
        }

    }
}
