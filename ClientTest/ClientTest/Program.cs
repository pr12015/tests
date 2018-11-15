using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientTest
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1; i++)
            {
                var startInfo = new ProcessStartInfo
                {
                    FileName = @"C:\Users\Administrator\Desktop\blok2-master\Client\bin\Debug\Client.exe",
                    WindowStyle = ProcessWindowStyle.Normal,
                    UseShellExecute = true,
                    Arguments = "1"
                };

                var proc = new Process
                {
                    StartInfo = startInfo
                };

                proc.Start();
                System.Threading.Thread.Sleep(50);
            }
        }
    }
}
