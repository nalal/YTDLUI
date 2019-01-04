using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

/*
    Application:    Youtube-DL UI Integration for windows
    Author:         Noah G., AKA Nac, AKA Nalal
    Organization:   FTC Group
    Init date:      3/1/2019
*/

namespace YoutubeDL_UI
{
    public partial class Form1 : Form
    {
        //Init path variables
        public static string localD = Environment.CurrentDirectory;
        public static string localAD = Path.Combine(localD, "Data");
        public static string localP = Path.Combine(localAD, "youtube-dl.exe");
        public static string localMD = Path.Combine(localAD, "Audio");
        public static string localVD = Path.Combine(localAD, "Video");
        public Form1()
        {
            InitializeComponent();
        }
        //Init Directories on load
        private void Form1_Load(object sender, EventArgs e)
        {
            FileIO.DIRInit();
            FileIO.appGet();
            LBDLT.Text = "None";
        }
        //Add URL to list
        private void BAdd_Click(object sender, EventArgs e)
        {
            Form add = new URLProm();
            add.ShowDialog();
            LBURLs.DataSource = null;
            LBURLs.DataSource = ListMan.listB;
        }
        //Remove URL from list
        private void BRem_Click(object sender, EventArgs e)
        {
            ListMan.listB.Remove(LBURLs.SelectedItem.ToString());
            LBURLs.DataSource = null;
            LBURLs.DataSource = ListMan.listB;
        }
        //Pass pars to DLMan for execution
        private void BDL_Click(object sender, EventArgs e)
        {
            int totalList = LBURLs.Items.Count;
            if (Err.isNull(LBURLs.Items.ToString()) == true && Err.isNull(DLType.DLT) == true)
            {
                if (totalList > 1)
                {
                    string[] LURL = LBURLs.Items.OfType<string>().ToArray();
                    string LDLType = DLType.DLT;
                    ListMan.initListA(LURL, LDLType);
                    DLMan.DLA(ListMan.URLA, ListMan.Args);
                    //FileIO.cleaner();
                    MessageBox.Show("Your files have been downloaded.", "Opperation Complete");
                }
                else if (totalList == 1)
                {
                    string LURL = LBURLs.Items[0].ToString();
                    string LDLType = DLType.DLT;
                    ListMan.initList(LURL, LDLType);
                    DLMan.DLS(ListMan.URL, ListMan.Args);
                    //FileIO.cleaner();
                    MessageBox.Show("Your files have been downloaded.", "Opperation Complete");
                }
                //"It could never happen" is not an excuse to not be ready for it
                else if (totalList < 0)
                {
                    MessageBox.Show("LIST UNDERFLOW ERROR", "Input error");
                }
            }
            //Catch null list
            else
            {
                MessageBox.Show("One or more of your inputs does not exist","Input Error");
            }

        }
        //Set DL type
        private void BDLType_Click(object sender, EventArgs e)
        {
           Form DLTF = new DLType();
           DLTF.ShowDialog();
           LBDLT.Text = DLType.DLT;
        }

        private void LBURLs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
