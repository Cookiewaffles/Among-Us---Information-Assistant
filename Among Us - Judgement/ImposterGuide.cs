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
    public partial class ImposterGuide : Form
    {
        //variables
        int mapNumber = 0;
        int playerNumber = 4;
        int killCounter = 0;


        //overload constructor
        public ImposterGuide(int number, int player)
        {
            InitializeComponent();

            mapNumber = number;
            playerNumber = player;
        }

        //loading guide
        private void ImposterGuide_Load(object sender, EventArgs e)
        {
            selectMap(mapNumber);

            DeadBoxes(playerNumber);

            KillSet(2);
        }

        //Select Map layout to assit player with locations
        public void selectMap(int map)
        {

            if (map == 1)
            {
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

        
        //Sets which boxes are visible base off players
        public void DeadBoxes(int players) {
            if (players == 4)
            {
                txtPlayer2.Visible = true;
                txtPlayer3.Visible = true;
                txtPlayer4.Visible = true;

                cbPlayer2Dead.Visible = true;
                cbPlayer3Dead.Visible = true;
                cbPlayer4Dead.Visible = true;
            }
            else if (players == 5)
            {
                txtPlayer2.Visible = true;
                txtPlayer3.Visible = true;
                txtPlayer4.Visible = true;
                txtPlayer5.Visible = true;

                cbPlayer2Dead.Visible = true;
                cbPlayer3Dead.Visible = true;
                cbPlayer4Dead.Visible = true;
                cbPlayer5Dead.Visible = true;
            }
            else if (players == 6)
            {
                txtPlayer2.Visible = true;
                txtPlayer3.Visible = true;
                txtPlayer4.Visible = true;
                txtPlayer5.Visible = true;
                txtPlayer6.Visible = true;

                cbPlayer2Dead.Visible = true;
                cbPlayer3Dead.Visible = true;
                cbPlayer4Dead.Visible = true;
                cbPlayer5Dead.Visible = true;
                cbPlayer6Dead.Visible = true;
            }
            else if (players == 7)
            {
                txtPlayer2.Visible = true;
                txtPlayer3.Visible = true;
                txtPlayer4.Visible = true;
                txtPlayer5.Visible = true;
                txtPlayer6.Visible = true;
                txtPlayer7.Visible = true;

                cbPlayer2Dead.Visible = true;
                cbPlayer3Dead.Visible = true;
                cbPlayer4Dead.Visible = true;
                cbPlayer5Dead.Visible = true;
                cbPlayer6Dead.Visible = true;
                cbPlayer7Dead.Visible = true;
            }
            else if (players == 8)
            {
                txtPlayer2.Visible = true;
                txtPlayer3.Visible = true;
                txtPlayer4.Visible = true;
                txtPlayer5.Visible = true;
                txtPlayer6.Visible = true;
                txtPlayer7.Visible = true;
                txtPlayer8.Visible = true;

                cbPlayer2Dead.Visible = true;
                cbPlayer3Dead.Visible = true;
                cbPlayer4Dead.Visible = true;
                cbPlayer5Dead.Visible = true;
                cbPlayer6Dead.Visible = true;
                cbPlayer7Dead.Visible = true;
                cbPlayer8Dead.Visible = true;
            }
            else if (players == 9)
            {
                txtPlayer2.Visible = true;
                txtPlayer3.Visible = true;
                txtPlayer4.Visible = true;
                txtPlayer5.Visible = true;
                txtPlayer6.Visible = true;
                txtPlayer7.Visible = true;
                txtPlayer8.Visible = true;
                txtPlayer9.Visible = true;

                cbPlayer2Dead.Visible = true;
                cbPlayer3Dead.Visible = true;
                cbPlayer4Dead.Visible = true;
                cbPlayer5Dead.Visible = true;
                cbPlayer6Dead.Visible = true;
                cbPlayer7Dead.Visible = true;
                cbPlayer8Dead.Visible = true;
                cbPlayer9Dead.Visible = true;
            }
            else if (players == 10)
            {
                txtPlayer2.Visible = true;
                txtPlayer3.Visible = true;
                txtPlayer4.Visible = true;
                txtPlayer5.Visible = true;
                txtPlayer6.Visible = true;
                txtPlayer7.Visible = true;
                txtPlayer8.Visible = true;
                txtPlayer9.Visible = true;
                txtPlayer10.Visible = true;

                cbPlayer2Dead.Visible = true;
                cbPlayer3Dead.Visible = true;
                cbPlayer4Dead.Visible = true;
                cbPlayer5Dead.Visible = true;
                cbPlayer6Dead.Visible = true;
                cbPlayer7Dead.Visible = true;
                cbPlayer8Dead.Visible = true;
                cbPlayer9Dead.Visible = true;
                cbPlayer10Dead.Visible = true;
            }
        }

        //Reopen Crewmate map, a return button
        private void customButton1_Click(object sender, EventArgs e)
        {
            Skeld_Map map = new Skeld_Map(mapNumber, playerNumber);

            map.Show();

            this.Close();
        }


        //setting the kil Counter
        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            KillSet(2);
        }
        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            KillSet(4);
        }
        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            KillSet(6);
        }

        public void KillSet(int num) {
            cbPlayer2Dead.Checked = false;
            cbPlayer3Dead.Checked = false;
            cbPlayer4Dead.Checked = false;
            cbPlayer5Dead.Checked = false;
            cbPlayer6Dead.Checked = false;
            cbPlayer7Dead.Checked = false;
            cbPlayer8Dead.Checked = false;
            cbPlayer9Dead.Checked = false;
            cbPlayer10Dead.Checked = false;

            killCounter = playerNumber;

            killCounter = killCounter - num;

            if (killCounter < 0) {
                killCounter = 0;            
            }

            pbDeathCounter.Image = Numbers.Images[killCounter];
        }


        //Changing the kill counter
        private void cbPlayer1Dead_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPlayer2Dead.Checked == true) {
                Counter();
            } else if (cbPlayer2Dead.Checked == false) {
                CounterReverse();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPlayer3Dead.Checked == true)
            {
                Counter();
            }
            else if (cbPlayer3Dead.Checked == false)
            {
                CounterReverse();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPlayer4Dead.Checked == true)
            {
                Counter();
            }
            else if (cbPlayer4Dead.Checked == false)
            {
                CounterReverse();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPlayer5Dead.Checked == true)
            {
                Counter();
            }
            else if (cbPlayer5Dead.Checked == false)
            {
                CounterReverse();
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPlayer6Dead.Checked == true)
            {
                Counter();
            }
            else if (cbPlayer6Dead.Checked == false)
            {
                CounterReverse();
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPlayer7Dead.Checked == true)
            {
                Counter();
            }
            else if (cbPlayer7Dead.Checked == false)
            {
                CounterReverse();
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPlayer8Dead.Checked == true)
            {
                Counter();
            }
            else if (cbPlayer8Dead.Checked == false)
            {
                CounterReverse();
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPlayer9Dead.Checked == true)
            {
                Counter();
            }
            else if (cbPlayer9Dead.Checked == false)
            {
                CounterReverse();
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPlayer10Dead.Checked == true)
            {
                Counter();
            }
            else if (cbPlayer10Dead.Checked == false)
            {
                CounterReverse();
            }
        }


        public void Counter() {
            killCounter = killCounter - 1;

            pbDeathCounter.Image = Numbers.Images[killCounter];
        }
        public void CounterReverse() {
            killCounter = killCounter + 1;

            pbDeathCounter.Image = Numbers.Images[killCounter];
        }
    }
}
