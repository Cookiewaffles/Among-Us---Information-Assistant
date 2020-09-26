using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Among_Us___Judgement
{
    public partial class frmMapSelect : Form
    {
        int mapNum = 0;
        int playerNum = 4;

        public frmMapSelect()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Among_Us___Judgement.Properties.Resources.https___blogs_images_forbes_com_startswithabang_files_2017_10_Tiny_bit_of_U;
        }

        private void gbPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {

        }

        private void customButton1_Click_1(object sender, EventArgs e)
        {
            mapNum = 1;
            Skeld_Map frm = new Skeld_Map(mapNum, playerNum);

            frm.Show();

            this.Hide();
        }

        private void btnMiraHQ_Click(object sender, EventArgs e)
        {
            mapNum = 2;
            Skeld_Map frm = new Skeld_Map(mapNum, playerNum);

            frm.Show();

            this.Hide();
        }

        private void btnPolus_Click(object sender, EventArgs e)
        {
            mapNum = 3;
            Skeld_Map frm = new Skeld_Map(mapNum, playerNum);

            frm.Show();

            this.Hide();
        }

        private void cbQA_Click(object sender, EventArgs e)
        {
            FAQs frm = new FAQs();

            frm.Show();
        }

        private void rb4_CheckedChanged(object sender, EventArgs e)
        {
            if (rb4.Checked == true) {
                playerNum = 4;
            }
        }

        private void rb5_CheckedChanged(object sender, EventArgs e)
        {
            if (rb5.Checked == true)
            {
                playerNum = 5;
            }
        }

        private void rb6_CheckedChanged(object sender, EventArgs e)
        {
            if (rb6.Checked == true)
            {
                playerNum = 6;
            }
        }

        private void rb7_CheckedChanged(object sender, EventArgs e)
        {
            if (rb7.Checked == true)
            {
                playerNum = 7;
            }
        }

        private void rb8_CheckedChanged(object sender, EventArgs e)
        {
            if (rb8.Checked == true)
            {
                playerNum = 8;
            }
        }

        private void rb9_CheckedChanged(object sender, EventArgs e)
        {
            if (rb9.Checked == true)
            {
                playerNum = 9;
            }
        }

        private void rb10_CheckedChanged(object sender, EventArgs e)
        {
            if (rb10.Checked == true)
            {
                playerNum = 10;
            }
        }
    }
}
