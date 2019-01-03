using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
                        File.Move(i, Form1.localMD);
                    }
                }
            }
            else if (DLType.DLT == "Video")
            {
                foreach (string i in files)
                {
                    if (i.Contains(".exe") != true)
                    {
                        File.Move(i, Form1.localVD);
                    }
                }
            }
        }
    }
}
