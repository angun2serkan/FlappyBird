using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappyBirdGit
{
    public partial class Form1 : Form
    {
        int gravity = 10; //for movement of bird
        int velocity = 15; //for pipes
        int score;
        bool pbPipe1Control, pbPipe3Control;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            timerGame.Start();
            if(e.KeyCode == Keys.Space && timerGame.Enabled)
            {
                if (pbBird.Top>0)
                {
                    pbBird.Top -= gravity * 4;
                }
            }
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            pbBird.Top += gravity;
            pbPipe1.Left -= velocity;
            pbPipe2.Left -= velocity;
            pbPipe3.Left -= velocity;
            pbPipe4.Left -= velocity;

            if (pbPipe1.Right<0) // if it left the screen (pipe1)
            {
                pbPipe1.Left = ClientSize.Width + rnd.Next(200);
                pbPipe1Control = false;
            }

            if (pbPipe2.Right < 0) // if it left the screen (pipe2)
            {
                pbPipe2.Left = ClientSize.Width + rnd.Next(200);               
            }

            if (pbPipe3.Right < 0) // if it left the screen (pipe3)
            {
                pbPipe3.Left = ClientSize.Width + rnd.Next(200);
                pbPipe3Control = false;
            }

            if (pbPipe4.Right < 0) // if it left the screen (pipe4)
            {
                pbPipe4.Left = ClientSize.Width + rnd.Next(200);              
            }

            if ( (pbPipe1.Bounds.IntersectsWith(pbBird.Bounds)) || (pbPipe2.Bounds.IntersectsWith(pbBird.Bounds)) || (pbPipe3.Bounds.IntersectsWith(pbBird.Bounds)) || (pbPipe4.Bounds.IntersectsWith(pbBird.Bounds)) || (pbGround.Bounds.IntersectsWith(pbBird.Bounds)) )
            { 
                timerGame.Stop();
                DialogResult dr = MessageBox.Show("Try Again ;)", "Flappy Bird", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    pbBird.Left = 0;
                    pbBird.Top = 170;
                    pbPipe1.Left += ClientSize.Width;
                    pbPipe2.Left += ClientSize.Width;
                    pbPipe3.Left += ClientSize.Width;
                    pbPipe4.Left += ClientSize.Width;

                    pbPipe1Control = false;
                    pbPipe3Control = false;
                    score = 0;
                    timerGame.Start();
                }
                else
                {
                    Close();
                }
            }

            if (pbBird.Right>pbPipe1.Left && !pbPipe1Control)
            {
                score++;
                pbPipe1Control = true; // if i dont use it, score will be increased by itself in every 20ms.
            }

            if (pbBird.Right>pbPipe3.Left && !pbPipe3Control)
            {
                score++;
                pbPipe3Control = true;
            }
            lblScore.Text = "Score: " + score;


        }
    }
}
