using System;
using System.Diagnostics;
using System.Text;

namespace BackupOrganizer {
    public static class Zip {
        public static void ZipFile(string file, string output, string password) {
            Process process = new Process();
            process.StartInfo.FileName = "7z.exe";
            process.StartInfo.Arguments = CreateArguments(file, output, password).ToString();
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            process.Start();
            process.PriorityClass = ProcessPriorityClass.High;
            process.WaitForExit();
        }

        private static StringBuilder CreateArguments(string file, string output, string password) {
            StringBuilder arguments = new StringBuilder("a -bsp1");

            arguments.Append($" \"-p{password}\" -mhe=on");
            arguments.Append($" \"{output}\"");
            arguments.Append($" \"{file}\"");

            return arguments;
        }
    }
}
