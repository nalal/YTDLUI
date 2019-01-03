using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeDL_UI
{
    class Err
    {
        //Catch null string
        public static bool isNull(string inp)
        {
            bool result = false;
            if (inp != null)
            {
                result = true;
            }
            return result;
        }
        //Catch non URL type string
        public static bool isURL(string URL)
        {
            bool result = false;
            if(URL.Contains("."))
            {
                result = true;
            }
            return result;
        }
    }
}
