using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WindowsIdentity.GetCurrent().Name);

            int duration = 20000;
            for (int i = 0; i < 15; ++i) {

                var startInfo = new ProcessStartInfo
                {
                    FileName = @"C:\Users\Administrator\Desktop\blok2-master\Worker\bin\Debug\Worker.exe",
                    WindowStyle = ProcessWindowStyle.Normal,
                    UseShellExecute = true,
                    Arguments = (duration + i * 3000).ToString()
                };

                var proc = new Process
                {
                    StartInfo = startInfo
                };

                proc.Start();
            }

            while (true)
            {
                Random rand = new Random();
                Thread.Sleep(rand.Next(6000, 10000));
                
                int randDuration = rand.Next(3000, 6000);

                var startInfo = new ProcessStartInfo
                {
                    FileName = @"C:\Users\Administrator\Desktop\blok2-master\Worker\bin\Debug\Worker.exe",
                    WindowStyle = ProcessWindowStyle.Normal,
                    UseShellExecute = true,
                    Arguments = 30000.ToString()
                };

                var proc = new Process
                {
                    StartInfo = startInfo
                };

                proc.Start();                
            }
        }
    }
}