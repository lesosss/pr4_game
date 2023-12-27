using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr4_game
{
    public partial class Form1 : Form
    {
        bool goLeft, goRight, goUp, goDown, ganeOver;
        string facing = "up";
        int playerHealth = 100;
        int speed = 10;
        int ammo = 10;
        int zombiesSpeed = 3;
        Random randNum = new Random();

        List<PictureBox> zombiesList = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {

        }

        private void KeylsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                facing = "left";
                player.Image = Properties.Resources.left;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                facing = "right";
                player.Image = Properties.Resources.right;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                facing = "up";
                player.Image = Properties.Resources.up;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                facing = "down";
                player.Image = Properties.Resources.down;
            }

        }

        private void KeylsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
                
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
                
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
               
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
                
            }
        }

        private void ShootBullet(string direction)
        {

        }

        private void MakeZombies()
        {

        }

        private void RestartGame()
        {

        }
        
    }
}
