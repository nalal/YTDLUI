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
    public partial class URLProm : Form
    {
        public URLProm()
        {
            InitializeComponent();
        }
        //Close window with no change
        private void BCan_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Add URL to the URL list var
        private void BAcc_Click(object sender, EventArgs e)
        {
            //Confirm is URL
            if (Err.isURL(TBURL.Text) == true)
            {
                ListMan.listB.Add(TBURL.Text);
                Close();
            }
            else
            {
                MessageBox.Show("That is not a valid URL","Input Error");
            }
        }
    }
}
