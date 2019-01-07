using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeDL_UI
{
    public partial class DLProgress : Form
    {
        public DLProgress()
        {
            InitializeComponent();
        }
        //Download Youtube-DL
        private void appGet()
        {
            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                wc.DownloadFileCompleted += wc_DownloadFileCompleted;
                wc.DownloadFileAsync(new Uri("https://yt-dl.org/downloads/2019.01.02/youtube-dl.exe"), Form1.localP);
            }
        }
        //Track DL progress
        private void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            PBDL.Value = e.ProgressPercentage;
        }
        //Catch DL end
        private void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            PBDL.Value = 0;

            if (e.Cancelled)
            {
                MessageBox.Show("The download has been cancelled");
                return;
            }

            if (e.Error != null) // We have an error! Retry a few times, then abort.
            {
                MessageBox.Show("An error ocurred while trying to download file");

                return;
            }
            Close();
        }
        private void DLProgress_Load(object sender, EventArgs e)
        {
            //Init form with Download opperation
            appGet();
        }

        private void PBDL_Click(object sender, EventArgs e)
        {

        }
    }
}
