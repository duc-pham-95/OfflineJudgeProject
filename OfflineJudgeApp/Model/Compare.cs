using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OfflineJudgeApp.Model
{
    class Compare
    {
        public static string[] Diff(string yourOutputPath, string correctOutputPath)
        {
            DirectoryInfo yourOutputDir = new DirectoryInfo(yourOutputPath);
            DirectoryInfo correctOutputDir = new DirectoryInfo(correctOutputPath);
            DirectoryInfo inputDir = new DirectoryInfo(Model.Directories.GetTestInputDir());
            FileInfo[] inputFiles = inputDir.GetFiles();
            FileInfo[] yourOutputFiles = yourOutputDir.GetFiles();
            FileInfo[] correctOutputFiles = correctOutputDir.GetFiles();
            int correctLength = correctOutputFiles.Length;
            int yourLength = yourOutputFiles.Length;
            int length = correctLength < yourLength ? correctLength : yourLength;
            string[] wrongAnswerInfo = new string[6];
            Regex reg = new Regex(@"^\s*$");
            for (int filePosition = 0; filePosition < length; filePosition++)
            {
                string[] correctLines = File.ReadAllLines(correctOutputFiles[filePosition].FullName);
                string[] yourLines = File.ReadAllLines(yourOutputFiles[filePosition].FullName);
                int correctLinesLength = correctLines.Length;
                int yourLinesLength = yourLines.Length;
                int lineLength = correctLinesLength < yourLinesLength ? correctLinesLength : yourLinesLength;
                for (int linePosition = 0; linePosition < lineLength; linePosition++)
                {
                    string yourLine = yourLines[linePosition].TrimEnd();
                    string correctLine = correctLines[linePosition].TrimEnd();
                    if (correctLine != yourLine)
                    {
                        wrongAnswerInfo[0] = yourOutputFiles[filePosition].FullName;
                        wrongAnswerInfo[1] = correctOutputFiles[filePosition].FullName;
                        wrongAnswerInfo[2] = inputFiles[filePosition].Name;
                        wrongAnswerInfo[3] = inputFiles[filePosition].FullName;
                        wrongAnswerInfo[4] = yourLine;
                        wrongAnswerInfo[5] = correctLine;
                        return wrongAnswerInfo;
                    }
                }
                if (yourLinesLength > correctLinesLength)
                {
                    for (int linePosition = correctLinesLength; linePosition < yourLines.Length; linePosition++)
                    {
                        if (!reg.IsMatch(yourLines[linePosition]))
                        {
                            wrongAnswerInfo[0] = yourOutputFiles[filePosition].FullName;
                            wrongAnswerInfo[1] = correctOutputFiles[filePosition].FullName;
                            wrongAnswerInfo[2] = inputFiles[filePosition].Name;
                            wrongAnswerInfo[3] = inputFiles[filePosition].FullName;
                            wrongAnswerInfo[4] = yourLines[linePosition];
                            return wrongAnswerInfo;
                        }
                    }
                }
                if (yourLinesLength < correctLinesLength)
                {
                    for (int linePosition = yourLinesLength; linePosition < correctLinesLength; linePosition++)
                    {
                        if (!reg.IsMatch(correctLines[linePosition]))
                        {
                            wrongAnswerInfo[0] = yourOutputFiles[filePosition].FullName;
                            wrongAnswerInfo[1] = correctOutputFiles[filePosition].FullName;
                            wrongAnswerInfo[2] = inputFiles[filePosition].Name;
                            wrongAnswerInfo[3] = inputFiles[filePosition].FullName;
                            wrongAnswerInfo[5] = correctLines[linePosition];
                            return wrongAnswerInfo;
                        }
                    }
                }
            }
            return null;
        }
    }
}
