using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeDL_UI
{
    class DLMan
    {
        //Run youtube-DL for several URLs
        public static void DLA(string[] URL, string args)
        {
            if (Err.isNull(args) == true)
            {
                foreach (string i in URL)
                {
                    string argset = args + " " + i;
                    var start = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = Form1.localP,
                            Arguments = argset
                        }
                    };
                    start.Start();
                    start.WaitForExit();
                    Thread.Sleep(4000);
                    //FileIO.cleaner();
                }
            }
            else
            {
                MessageBox.Show("INPUT ERROR","INPUT ERROR");
            }
        }
        //Run youtube-DL for single URL
        public static void DLS(string URL, string args)
        {
            if (Err.isNull(args) == true)
            {
                string argset = args + " " + URL;
                var start = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = Form1.localP,
                        Arguments = argset
                    }
                };
                start.Start();
                start.WaitForExit();
                Thread.Sleep(4000);
                //FileIO.cleaner();
            }
            else
            {
                MessageBox.Show("INPUT ERROR", "INPUT ERROR");
            }
        }
    }
}
