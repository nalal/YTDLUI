using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeDL_UI
{
    public partial class DLType : Form
    {
        //Init public DLT string for type verification
        public static string DLT = "";
        public DLType()
        {
            InitializeComponent();
        }
        //Set DL type
        private void BAcc_Click(object sender, EventArgs e)
        {
            //Verify a selection was made
            if(RBA.Checked == true || RBV.Checked == true)
            {
                //Save DLT to public for external use
                if (RBA.Checked == true)
                {
                    DLT = "Audio";
                    Close();
                }
                else if (RBV.Checked == true)
                {
                    DLT = "Video";
                }
            }
            //Catch unselected radio button
            else
            {
                MessageBox.Show("Please select a download type","Input Error");
            }
        }
        //Close window
        private void BCan_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
