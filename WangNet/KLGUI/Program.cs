using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLGUI
{
    class Program
    {
        static int PID
        {
            get
            {
                Process[] proc = Process.GetProcessesByName("KLService.exe");
                if (proc.Length == 0)
                {
                    return -1;
                }
                return proc[0].Id;
            }
        }
        static bool Running
        {
            get
            {
                Process[] proc = Process.GetProcessesByName("KLService.exe");
                if(proc.Length == 0)
                {
                    return false;
                }
                return true;
            }
        }
       
        static void GetProcInfo()
        {
            if(Running)
            {
                Console.WriteLine("Running: true");
                Console.WriteLine("PID: " + PID);
            }
            else
            {
                Console.WriteLine("Running: false");
            }
        }
        
        static void Stop()
        {
            Process[] proc = Process.GetProcessesByName("KLService.exe");
            if (proc.Length == 0)
            {
                return;
            }
            proc[0].Kill();
        }
        
        static void Main(string[] args)
        {
            Console.Title = "WangNet -KLService";
            GetProcInfo();
            while(true)
            {
                Console.Write(":");
                string input = Console.ReadLine();
                if(input == "startservice")
                {
                    Process.Start("C:\\Keylogs\\KLService.exe");
                }
                if(input == "endservice")
                {

                }
            }
        }
    }
}
