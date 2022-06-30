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

namespace Minimal_Player
{
    public partial class frmPlayer : Form
    {
        public frmPlayer()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string fname;
            ofdVideo.Filter = "MP4 File|*.mp4|MKV File|*.mkv|All File|*.*";
            if(ofdVideo.ShowDialog() == DialogResult.OK)
            {
                fname = ofdVideo.FileName.ToString();
                miniPlayer.URL = fname;
                lsPlay.Items.Add(fname);
                miniPlayer.Ctlcontrols.play();
            }
        }

        private void btnGetList_Click(object sender, EventArgs e)
        {
            if(fbdGetlist.ShowDialog() == DialogResult.OK)
            {
                string path = fbdGetlist.SelectedPath.ToString();
                var fnames = Directory.GetFiles(path);
                foreach(string fname in fnames)
                {
                    lsPlay.Items.Add(fname);
                }
            }
        }

        private void lsPlay_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fname = lsPlay.SelectedItem.ToString();
            miniPlayer.URL = fname;
            miniPlayer.Ctlcontrols.play();
        }
    }
}
