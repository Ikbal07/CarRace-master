using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carrace
{
    public partial class maingame : Form
    {
        int betsstart = 1;
        racecars[] objraceing = new racecars[3];
        Beting[] objbets = new Beting[4];
        Random myRandomizer = new Random();
        
    public maingame()
        {
            InitializeComponent();
            SetupRaceTrack();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < objbets.Length; i++)
            {
                if (objbets[i].Engine())
                {
                    EndRace(i);
                    break;
                }
            }

        }
        void StartRace()
        {
            timer1.Interval = 50;
            timer1.Start();
        }

        private void Racebtn_Click(object sender, EventArgs e)
        {
            StartRace();
            racebtn.Enabled = false;
        }

        private void betbtn_Click(object sender, EventArgs e)
        {
            if (Jimrb.Checked)
            {
                objraceing[0].carbeetingrace((int)betupdown.Value, (int)carupdown.Value);
                objraceing[0].UpdateLb();
            }
            if (Kanerb.Checked)
            {
                objraceing[1].carbeetingrace((int)betupdown.Value, (int)carupdown.Value);
                objraceing[1].UpdateLb();
            }
            if (katrb.Checked)
            {
                objraceing[2].carbeetingrace((int)betupdown.Value, (int)carupdown.Value);
                objraceing[2].UpdateLb();
            }
        }

       


        public void EndRace(int winnercar)
        {
            timer1.Stop();
            timer1.Dispose();
            MessageBox.Show("And the winner is " + winnercar);
            foreach (var guy in objraceing)
            {
                guy.firstracer(winnercar);
            }
            foreach (var bike in objbets)
            {
                bike.GOGOGO();
            }
            racebtn.Enabled = true;
        }
        public void SetupRaceTrack()
        {
            objbets[0] = new Beting()
            {
                imgcarshow = carPB1,
                posstart = raceTrackPictureBox.Left,
                racestames = raceTrackPictureBox.Width - carPB1.Width,
                radomsteps = myRandomizer
            };
            objbets[1] = new Beting()
            {
                imgcarshow = carPB2,
                posstart = raceTrackPictureBox.Left,
                racestames = raceTrackPictureBox.Width - carPB2.Width,
                radomsteps = myRandomizer
            };
            objbets[2] = new Beting()
            {
                imgcarshow = carPb3,
                posstart = raceTrackPictureBox.Left,
                racestames = raceTrackPictureBox.Width - carPb3.Width,
                radomsteps = myRandomizer
            };
            objbets[3] = new Beting()
            {
                imgcarshow = carpb4,
                posstart = raceTrackPictureBox.Left,
                racestames = raceTrackPictureBox.Width - carpb4.Width,
                radomsteps = myRandomizer
            };


            objraceing[0] = new racecars("Jim", 50, Jimrb, Jimlb);
            objraceing[1] = new racecars("Kane", 50, Kanerb, kanelb);
            objraceing[2] = new racecars("kat", 50, katrb, katlb);

            foreach (var guy in objraceing)
            {
                guy.carbeetingrace(0, 0);
                guy.UpdateLb();
            }
            minimumBetLabel.Text = "Minimum bet: " + betsstart + " bucks";
            betupdown.Minimum = betsstart;
        }
       

        private void carUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void playerrb3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void playerrb1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void player2Label_Click(object sender, EventArgs e)
        {

        }

        private void playerrb2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void carPB1_Click(object sender, EventArgs e)
        {

        }
    }
}
