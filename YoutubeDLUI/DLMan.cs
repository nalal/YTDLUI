using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = Form1.localP;
                    startInfo.Arguments = argset;
                    Process.Start(startInfo);
                }
            }
        }
        //Run youtube-DL for single URL
        public static void DLS(string URL, string args)
        {
            if (Err.isNull(args) == true)
            {
                string argset = args + " " + URL;
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = Form1.localP;
                startInfo.Arguments = argset;
                Process.Start(startInfo);
            }
        }
    }
}
