using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Among_Us___Judgement
{
    public partial class Skeld_Map : Form
    {
        int mapNumber = 0;
        int playerNumber = 4;

        public Skeld_Map(int number, int player)
        {
            InitializeComponent();

            mapNumber = number;
            playerNumber = player;
        }

        //intialize in order
        private void Skeld_Map_Load(object sender, EventArgs e)
        {
            //Map Starter
            mapFiller(mapNumber);
            selectMap(mapNumber);
            playerAmount(playerNumber);
            playerDefault();
           
        }

        //Resets Stats
        private void cbResetInfo_Click(object sender, EventArgs e)
        {
            playerDefault();
        }

        //Display Imposter Menu
        private void btnImposter_Click(object sender, EventArgs e)
        {
            ImposterGuide imposter = new ImposterGuide(mapNumber, playerNumber);

            imposter.Show();

            this.Hide();
        }

        //Customizing of all player fields
        //May wish to combine into a single class later down the line for simplicity
        //Player 1 Fields
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSus.SelectedIndex == 0) {
                gbPlayer1.BackColor = SystemColors.Control;
            } else if (cbSus.SelectedIndex == 1) {
                gbPlayer1.BackColor = Color.PaleTurquoise;
            }
            else if (cbSus.SelectedIndex == 2)
            {
                gbPlayer1.BackColor = Color.LightCoral;
            }
        }
        private void chbDeadOrAlive_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDeadOrAlive.Checked == true) {
                cbDeadLocation.Enabled = true;
                gbPlayer1.TitleBackColor = Color.Gray;
            }
            else {
                cbDeadLocation.Enabled = false;
                gbPlayer1.TitleBackColor = Color.SteelBlue;
            }
        }
        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbPlayer1.Image = pictures.Images[cbColor.SelectedIndex];
        }

        //player 2 Fields
        private void cbSus2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSus2.SelectedIndex == 0)
            {
                gbPlayer2.BackColor = SystemColors.Control;
            }
            else if (cbSus2.SelectedIndex == 1)
            {
                gbPlayer2.BackColor = Color.PaleTurquoise;
            }
            else if (cbSus2.SelectedIndex == 2)
            {
                gbPlayer2.BackColor = Color.LightCoral;
            }
        }
        private void chbDead2_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDead2.Checked == true)
            {
                cbDeadLocation2.Enabled = true;
                gbPlayer2.TitleBackColor = Color.Gray;
            }
            else
            {
                cbDeadLocation2.Enabled = false;
                gbPlayer2.TitleBackColor = Color.SteelBlue;
            }
        }
        private void cbColor2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            pbPlayer2.Image = pictures.Images[cbColor2.SelectedIndex];
        }


        //player 3 Fields
        private void cbSus3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbSus3.SelectedIndex == 0)
            {
                gbPlayer3.BackColor = SystemColors.Control;
            }
            else if (cbSus3.SelectedIndex == 1)
            {
                gbPlayer3.BackColor = Color.PaleTurquoise;
            }
            else if (cbSus3.SelectedIndex == 2)
            {
                gbPlayer3.BackColor = Color.LightCoral;
            }
        }
        private void chbDead3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chbDead3.Checked == true)
            {
                cbDeadLocation3.Enabled = true;
                gbPlayer3.TitleBackColor = Color.Gray;
            }
            else
            {
                cbDeadLocation3.Enabled = false;
                gbPlayer3.TitleBackColor = Color.SteelBlue;
            }
        }
        
        private void cbColor3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            pbPlayer3.Image = pictures.Images[cbColor3.SelectedIndex];
        }

        //player 4 Fields
        private void cbSus4_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbSus4.SelectedIndex == 0)
            {
                gbPlayer4.BackColor = SystemColors.Control;
            }
            else if (cbSus4.SelectedIndex == 1)
            {
                gbPlayer4.BackColor = Color.PaleTurquoise;
            }
            else if (cbSus4.SelectedIndex == 2)
            {
                gbPlayer4.BackColor = Color.LightCoral;
            }
        }
        private void chbDead4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chbDead4.Checked == true)
            {
                cbDeadLocation4.Enabled = true;
                gbPlayer4.TitleBackColor = Color.Gray;
            }
            else
            {
                cbDeadLocation4.Enabled = false;
                gbPlayer4.TitleBackColor = Color.SteelBlue;
            }
        }
        private void cbColor4_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            pbPlayer4.Image = pictures.Images[cbColor4.SelectedIndex];
        }

        //player 5 Fields
        private void cbSus5_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbSus5.SelectedIndex == 0)
            {
                gbPlayer5.BackColor = SystemColors.Control;
            }
            else if (cbSus5.SelectedIndex == 1)
            {
                gbPlayer5.BackColor = Color.PaleTurquoise;
            }
            else if (cbSus5.SelectedIndex == 2)
            {
                gbPlayer5.BackColor = Color.LightCoral;
            }
        }
        private void chbDead5_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chbDead5.Checked == true)
            {
                cbDeadLocation5.Enabled = true;
                gbPlayer5.TitleBackColor = Color.Gray;
            }
            else
            {
                cbDeadLocation5.Enabled = false;
                gbPlayer5.TitleBackColor = Color.SteelBlue;
            }
        }
        private void cbColor5_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            pbPlayer5.Image = pictures.Images[cbColor5.SelectedIndex];
        }

        //player 6 Fields
        private void cbSus6_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbSus6.SelectedIndex == 0)
            {
                gbPlayer6.BackColor = SystemColors.Control;
            }
            else if (cbSus6.SelectedIndex == 1)
            {
                gbPlayer6.BackColor = Color.PaleTurquoise;
            }
            else if (cbSus6.SelectedIndex == 2)
            {
                gbPlayer6.BackColor = Color.LightCoral;
            }
        }
        private void chbDead6_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chbDead6.Checked == true)
            {
                cbDeadLocation6.Enabled = true;
                gbPlayer6.TitleBackColor = Color.Gray;
            }
            else
            {
                cbDeadLocation6.Enabled = false;
                gbPlayer6.TitleBackColor = Color.SteelBlue;
            }
        }
        private void cbColor6_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            pbPlayer6.Image = pictures.Images[cbColor6.SelectedIndex];
        }

        //player 7 Fields
        private void cbSus7_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbSus7.SelectedIndex == 0)
            {
                gbPlayer7.BackColor = SystemColors.Control;
            }
            else if (cbSus7.SelectedIndex == 1)
            {
                gbPlayer7.BackColor = Color.PaleTurquoise;
            }
            else if (cbSus7.SelectedIndex == 2)
            {
                gbPlayer7.BackColor = Color.LightCoral;
            }
        }
        private void chbDead7_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chbDead7.Checked == true)
            {
                cbDeadLocation7.Enabled = true;
                gbPlayer7.TitleBackColor = Color.Gray;
            }
            else
            {
                cbDeadLocation7.Enabled = false;
                gbPlayer7.TitleBackColor = Color.SteelBlue;
            }
        }
        private void cbColor7_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            pbPlayer7.Image = pictures.Images[cbColor7.SelectedIndex];
        }

        //player 8 Fields
        private void cbSus8_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbSus8.SelectedIndex == 0)
            {
                gbPlayer8.BackColor = SystemColors.Control;
            }
            else if (cbSus8.SelectedIndex == 1)
            {
                gbPlayer8.BackColor = Color.PaleTurquoise;
            }
            else if (cbSus8.SelectedIndex == 2)
            {
                gbPlayer8.BackColor = Color.LightCoral;
            }
        }
        private void chbDead8_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chbDead8.Checked == true)
            {
                cbDeadLocation8.Enabled = true;
                gbPlayer8.TitleBackColor = Color.Gray;
            }
            else
            {
                cbDeadLocation8.Enabled = false;
                gbPlayer8.TitleBackColor = Color.SteelBlue;
            }
        }
        private void cbColor8_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            pbPlayer8.Image = pictures.Images[cbColor8.SelectedIndex];
        }

        //player 9 Fields
        private void cbSus9_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbSus9.SelectedIndex == 0)
            {
                gbPlayer9.BackColor = SystemColors.Control;
            }
            else if (cbSus9.SelectedIndex == 1)
            {
                gbPlayer9.BackColor = Color.PaleTurquoise;
            }
            else if (cbSus9.SelectedIndex == 2)
            {
                gbPlayer9.BackColor = Color.LightCoral;
            }
        }
        private void chbDead9_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chbDead9.Checked == true)
            {
                cbDeadLocation9.Enabled = true;
                gbPlayer9.TitleBackColor = Color.Gray;
            }
            else
            {
                cbDeadLocation9.Enabled = false;
                gbPlayer9.TitleBackColor = Color.SteelBlue;
            }
        }
        private void cbColor9_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            pbPlayer9.Image = pictures.Images[cbColor9.SelectedIndex];
        }


        //Add items to combobox of locations base off selected map 
        public void mapFiller(int mapNum) {
            string[] Skeld = { "Unknown", "Admin", "Cafeteria", "Communications", "Electrical", "Lower Engine", "Medbay", "Navigation", "O2", "Reactor", "Security", "Shields", "Storage", "Upper Engine", "Weapons" };
            string[] Mira = { "Unknow", "Admin", "Balcony", "Cafeteria", "Communications", "Decontamination", "Greenhouse", "Laboratory", "Launchpad", "Locker Room", "Medbay", "Office", "Reactor", "Storage"};
            string[] Polus = { "Unknow", "Admin", "Communications", "Dropship", "Electrical", "Laboraory", "O2", "Office", "Security", "Specimen Room", "Storage", "Weapons"};

            if (mapNum == 1) {
                //Last Location
                cbLocationLast.Items.AddRange(Skeld);
                cbLocationLast2.Items.AddRange(Skeld);
                cbLocationLast3.Items.AddRange(Skeld);
                cbLocationLast4.Items.AddRange(Skeld);
                cbLocationLast5.Items.AddRange(Skeld);
                cbLocationLast6.Items.AddRange(Skeld);
                cbLocationLast7.Items.AddRange(Skeld);
                cbLocationLast8.Items.AddRange(Skeld);
                cbLocationLast9.Items.AddRange(Skeld);


                //Dead Location
                cbDeadLocation.Items.AddRange(Skeld);
                cbDeadLocation2.Items.AddRange(Skeld);
                cbDeadLocation3.Items.AddRange(Skeld);
                cbDeadLocation4.Items.AddRange(Skeld);
                cbDeadLocation5.Items.AddRange(Skeld);
                cbDeadLocation6.Items.AddRange(Skeld);
                cbDeadLocation7.Items.AddRange(Skeld);
                cbDeadLocation8.Items.AddRange(Skeld);
                cbDeadLocation9.Items.AddRange(Skeld);
            }

            else if (mapNum == 2) {
                //Last Location
                cbLocationLast.Items.AddRange(Mira);
                cbLocationLast2.Items.AddRange(Mira);
                cbLocationLast3.Items.AddRange(Mira);
                cbLocationLast4.Items.AddRange(Mira);
                cbLocationLast5.Items.AddRange(Mira);
                cbLocationLast6.Items.AddRange(Mira);
                cbLocationLast7.Items.AddRange(Mira);
                cbLocationLast8.Items.AddRange(Mira);
                cbLocationLast9.Items.AddRange(Mira);


                //Dead Location
                cbDeadLocation.Items.AddRange(Mira);
                cbDeadLocation2.Items.AddRange(Mira);
                cbDeadLocation3.Items.AddRange(Mira);
                cbDeadLocation4.Items.AddRange(Mira);
                cbDeadLocation5.Items.AddRange(Mira);
                cbDeadLocation6.Items.AddRange(Mira);
                cbDeadLocation7.Items.AddRange(Mira);
                cbDeadLocation8.Items.AddRange(Mira);
                cbDeadLocation9.Items.AddRange(Mira);
            }
            else if (mapNum == 3)
            {
                //Last Location
                cbLocationLast.Items.AddRange(Polus);
                cbLocationLast2.Items.AddRange(Polus);
                cbLocationLast3.Items.AddRange(Polus);
                cbLocationLast4.Items.AddRange(Polus);
                cbLocationLast5.Items.AddRange(Polus);
                cbLocationLast6.Items.AddRange(Polus);
                cbLocationLast7.Items.AddRange(Polus);
                cbLocationLast8.Items.AddRange(Polus);
                cbLocationLast9.Items.AddRange(Polus);


                //Dead Location
                cbDeadLocation.Items.AddRange(Polus);
                cbDeadLocation2.Items.AddRange(Polus);
                cbDeadLocation3.Items.AddRange(Polus);
                cbDeadLocation4.Items.AddRange(Polus);
                cbDeadLocation5.Items.AddRange(Polus);
                cbDeadLocation6.Items.AddRange(Polus);
                cbDeadLocation7.Items.AddRange(Polus);
                cbDeadLocation8.Items.AddRange(Polus);
                cbDeadLocation9.Items.AddRange(Polus);
            }
        }


        //Select Map layout to assit player with locations
        public void selectMap(int map) {

            if (map == 1) {
                pbMapper.Image = Among_Us___Judgement.Properties.Resources.Skeld;
            }
            else if (map == 2)
            {
                pbMapper.Image = Among_Us___Judgement.Properties.Resources.Mira;
            }
            else if (map == 3)
            {
                pbMapper.Image = Among_Us___Judgement.Properties.Resources.Polus;
            }
        }


        //Determines active players
        public void playerAmount(int players) {
            if (players == 4) {
                gbPlayer1.Visible = true;
                gbPlayer2.Visible = true;
                gbPlayer3.Visible = true;
            }
            else if (players == 5)
            {
                gbPlayer1.Visible = true;
                gbPlayer2.Visible = true;
                gbPlayer3.Visible = true;
                gbPlayer4.Visible = true;
            }
            else if (players == 6)
            {
                gbPlayer1.Visible = true;
                gbPlayer2.Visible = true;
                gbPlayer3.Visible = true;
                gbPlayer4.Visible = true;
                gbPlayer5.Visible = true;
            }
            else if (players == 7)
            {
                gbPlayer1.Visible = true;
                gbPlayer2.Visible = true;
                gbPlayer3.Visible = true;
                gbPlayer4.Visible = true;
                gbPlayer5.Visible = true;
                gbPlayer6.Visible = true;
            }
            else if (players == 8)
            {
                gbPlayer1.Visible = true;
                gbPlayer2.Visible = true;
                gbPlayer3.Visible = true;
                gbPlayer4.Visible = true;
                gbPlayer5.Visible = true;
                gbPlayer6.Visible = true;
                gbPlayer7.Visible = true;
            }
            else if (players == 9)
            {
                gbPlayer1.Visible = true;
                gbPlayer2.Visible = true;
                gbPlayer3.Visible = true;
                gbPlayer4.Visible = true;
                gbPlayer5.Visible = true;
                gbPlayer6.Visible = true;
                gbPlayer7.Visible = true;
                gbPlayer8.Visible = true;
            }
            else if (players == 10)
            {
                gbPlayer1.Visible = true;
                gbPlayer2.Visible = true;
                gbPlayer3.Visible = true;
                gbPlayer4.Visible = true;
                gbPlayer5.Visible = true;
                gbPlayer6.Visible = true; 
                gbPlayer7.Visible = true;
                gbPlayer8.Visible = true;
                gbPlayer9.Visible = true;
            }
        }


        //Defaults all players from 1 to 10
        private void playerDefault() {
            //player 1
            cbSus.SelectedIndex = 0;
            cbLocationLast.SelectedIndex = 0;
            cbColor.SelectedIndex = 0;
            pbPlayer1.Image = pictures.Images[0];

            //player 2
            cbSus2.SelectedIndex = 0;
            cbLocationLast2.SelectedIndex = 0;
            cbColor2.SelectedIndex = 1;
            pbPlayer2.Image = pictures.Images[1];

            //player 3
            cbSus3.SelectedIndex = 0;
            cbLocationLast3.SelectedIndex = 0;
            cbColor3.SelectedIndex = 2;
            pbPlayer3.Image = pictures.Images[2];

            //player 4
            cbSus4.SelectedIndex = 0;
            cbLocationLast4.SelectedIndex = 0;
            cbColor4.SelectedIndex = 3;
            pbPlayer4.Image = pictures.Images[3];

            //player 5
            cbSus5.SelectedIndex = 0;
            cbLocationLast5.SelectedIndex = 0;
            cbColor5.SelectedIndex = 4;
            pbPlayer5.Image = pictures.Images[4];

            //player 6
            cbSus6.SelectedIndex = 0;
            cbLocationLast6.SelectedIndex = 0;
            cbColor6.SelectedIndex = 5;
            pbPlayer6.Image = pictures.Images[5];

            //player 7
            cbSus7.SelectedIndex = 0;
            cbLocationLast7.SelectedIndex = 0;
            cbColor7.SelectedIndex = 6;
            pbPlayer7.Image = pictures.Images[6];

            //player 8
            cbSus8.SelectedIndex = 0;
            cbLocationLast8.SelectedIndex = 0;
            cbColor8.SelectedIndex = 7;
            pbPlayer8.Image = pictures.Images[7];

            //player 9
            cbSus9.SelectedIndex = 0;
            cbLocationLast9.SelectedIndex = 0;
            cbColor9.SelectedIndex = 8;
            pbPlayer9.Image = pictures.Images[8];
        }


        //not needed
        private void pbPlayer1_Click(object sender, EventArgs e)
        {

        }

        private void cbLocationLast_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void gbPlayer1_Enter(object sender, EventArgs e)
        {
            
        }

        private void Skeld_Map_FormClosed(object sender, FormClosedEventArgs e)
        {
           // Application.Exit();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            frmMapSelect frm = new frmMapSelect();

            frm.Show();

            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
