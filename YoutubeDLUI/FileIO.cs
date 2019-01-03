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
    }
}
