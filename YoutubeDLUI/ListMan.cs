using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeDL_UI
{
    public class ListMan
    {
        //Init strings for URL and argument identification
        public static string URL = "";
        public static string[] URLA = { };
        public static string Args = "";
        public static List<string> listB = new List<string>() {};
        //Push data to public strings for single URL
        public static void initList(string URLI, string DLType)
        {
            if (DLType == "Audio")
            {
                Args = "-f bestaudio";
                URL = URLI;
            }
            else if (DLType == "Video")
            {
                Args = "best";
                URL = URLI;
            }
            else
            {
                MessageBox.Show("Invalid download type", "ERROR");
            }
        }
        //Push data to public strings for several URLs
        public static void initListA(string[] URLI, string DLType)
        {
            if (DLType == "Audio")
            {
                Args = "-f bestaudio";
                URLA = URLI;
            }
            else if (DLType == "Video")
            {
                Args = "best";
                URLA = URLI;
            }
            else
            {
                MessageBox.Show("Invalid download type", "ERROR");
            }
        }

    }
}
