using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace YoutubeDL_UI
{
    class FileIO
    {
        public static void cleaner()
        {
            string[] files = Directory.GetFiles(Form1.localD);
            if (DLType.DLT == "Audio")
            {
                foreach (string i in files)
                {
                    if (i.Contains(".exe") != true)
                    {
                        File.Move(Path.Combine(Form1.localD, i), Path.Combine(Form1.localMD, i));
                    }
                }
            }
            else if (DLType.DLT == "Video")
            {
                foreach (string i in files)
                {
                    if (i.Contains(".exe") != true && i.Contains(".pdb") != true)
                    {
                        File.Move(Path.Combine(Form1.localD, i), Path.Combine(Form1.localMD, i));
                    }
                }
            }
        }
        public static void DIRInit()
        {
            Directory.CreateDirectory(Form1.localAD);
            Directory.CreateDirectory(Form1.localMD);
            Directory.CreateDirectory(Form1.localVD);
        }
        public static void appGet()
        {
            WebClient client = new WebClient();
            client.DownloadFile("https://yt-dl.org/downloads/2019.01.02/youtube-dl.exe", Form1.localP);
        }
    }
}
