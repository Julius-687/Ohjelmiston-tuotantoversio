using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autopeli
{
    public partial class Autopeli : Form
    {

        int carSpeed = 5;
        int roadSpeed = 5;
        bool carLeft;
        bool carRight;
        int trafficSpeed = 5;
        int Score = 0;
        Random rnd = new Random();

        private void Reset()
        {
            trophy.Visible = false;

            button1.Enabled = false; 

            rajahdys.Visible = false; 

            trafficSpeed = 5; 

            roadSpeed = 5; 

            Score = 0; 

            pelaaja.Left = 161;
            pelaaja.Top = 286;

            carLeft = false;
            carRight = false;


            auto1.Left = 66;
            auto1.Top = -120;

            auto2.Left = 294;
            auto2.Top = -185;


            tie1.Left = 0;
            tie1.Top = 105;
            tie2.Left = 0;
            tie2.Top = -500;


            timer1.Start();

        }

        public Autopeli()
        {
            InitializeComponent();
            Reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Score++;

            pisteet.Text = "" + Score;

            tie2.Top += roadSpeed;
            tie1.Top += roadSpeed;


            if (tie2.Top > 499)
            {
                tie2.Top = -499;
            }
            if (tie1.Top > 499)
            {
                tie1.Top = -499;
            }
            if (carLeft) { pelaaja.Left -= carSpeed; } 
            if (carRight) { pelaaja.Left += carSpeed; } 


            if (pelaaja.Left < 1)
            {
                carLeft = false; 
            }
            else if (pelaaja.Left + pelaaja.Width > 380)
            {
                carRight = false;
            }



            auto1.Top += trafficSpeed;
            auto1.Top += trafficSpeed;



            if (pelaaja.Bounds.IntersectsWith(auto1.Bounds) || pelaaja.Bounds.IntersectsWith(auto2.Bounds))
            {
                gameOver(); 
            }

            if (Score > 100 && Score < 500)
            {
                trafficSpeed = 6;
                roadSpeed = 7;
            }

            else if (Score > 500 && Score < 1000)
            {
                trafficSpeed = 7;
                roadSpeed = 8;
            }

            else if (Score > 1200)
            {
                trafficSpeed = 9;
                roadSpeed = 10;
            }


        }

        private void moveCar(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && pelaaja.Left > 0)
            {
                carLeft = true;
            }

            if (e.KeyCode == Keys.Right && pelaaja.Left + pelaaja.Width < panel1.Width)
            {
                carRight = true;
            }
        }

        private void stopCar(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                carLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                carRight = false;
            }
        }

        private void gameOver()
        {
            trophy.Visible = true; 

            timer1.Stop();

            button1.Enabled = true; 


            rajahdys.Visible = true; 
            pelaaja.Controls.Add(rajahdys); 
            rajahdys.Location = new Point(-8, 5);
            rajahdys.BackColor = Color.Transparent;
            rajahdys.BringToFront();


            if (Score < 1000)
            {
                trophy.Image = Properties.Resources.pronssia;

            }

            if (Score > 2000)
            {
                trophy.Image = Properties.Resources.hopeaa;
            }


            if (Score > 3500)
            {
                trophy.Image = Properties.Resources.kultaa;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
