using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllyControl
{
    public partial class Form1 : Form
    {
        Player Red = new Player("Red", 10, 2000);
        Player Chuck = new Player("Chuck", 12, 2300);
        Player Bomb = new Player("Bomb", 15, 2500);
        Player Hal = new Player("Hal", 13, 2400);

        bool gameLife = true;

        ConcreteAllyControlCenter ally = new ConcreteAllyControlCenter("ally");

        public Form1()
        {
            InitializeComponent();
            ally.Join(Red);
            ally.Join(Chuck);
            ally.Join(Bomb);
            ally.Join(Hal);
            RefreshHP();
        }

        private void AttackButton_Click(object sender, EventArgs e)
        {

            if (((AllyControlCenter)ally).observer.Count == 0)
            {
                statusRichTextBox.Text = "全員陣亡";
                gameLife = false;
            }
            else
            {
                Random rnd = new Random();
                int att = rnd.Next(ally.observer.Count);
                statusRichTextBox.Text = ally.observer[att].BeAttacked(ally);
                RefreshHP();
                if (((AllyControlCenter)ally).observer.Count == 0)
                {
                    statusRichTextBox.Text = "全員陣亡";
                    gameLife = false;
                }
                this.Refresh();
            }
        }

        private void RefreshHP()
        {
            player1HpLabel.Text = Red.Hp.ToString();
            player2HpLabel.Text = Chuck.Hp.ToString();
            player3HpLabel.Text = Bomb.Hp.ToString();
            player4HpLabel.Text = Hal.Hp.ToString();

            if (Red.Hp == 0)
                player1PictureBox.Image = Properties.Resources.tomb;
            if (Chuck.Hp == 0)
                player2PictureBox.Image = Properties.Resources.tomb;
            if (Bomb.Hp == 0)
                player3PictureBox.Image = Properties.Resources.tomb;
            if (Hal.Hp == 0)
                player4PictureBox.Image = Properties.Resources.tomb;
        }

        private void player1PictureBox_Click(object sender, EventArgs e)
        {
            if (gameLife && Red.Hp!=0)
            {
                if (ally.observer.Contains(Red))
                {
                    ally.Quit(Red);
                    player1PictureBox.Image = Properties.Resources.rest;
                }
                else
                {
                    ally.Join(Red);
                    player1PictureBox.Image = Properties.Resources.Red;
                }
            }
        }

        private void player2PictureBox_Click(object sender, EventArgs e)
        {
            if (gameLife && Chuck.Hp!=0)
            {
                if (ally.observer.Contains(Chuck))
                {
                    ally.Quit(Chuck);
                    player2PictureBox.Image = Properties.Resources.rest;
                }
                else
                {
                    ally.Join(Chuck);
                    player2PictureBox.Image = Properties.Resources.chuck;
                }
            }
        }

        private void player3PictureBox_Click(object sender, EventArgs e)
        {
            if (gameLife&&Bomb.Hp!=0)
            {
                if (ally.observer.Contains(Bomb))
                {
                    ally.Quit(Bomb);
                    player3PictureBox.Image = Properties.Resources.rest;
                }
                else
                {
                    ally.Join(Bomb);
                    player3PictureBox.Image = Properties.Resources.bomb;
                }
            }
        }

        private void player4PictureBox_Click(object sender, EventArgs e)
        {
            if (gameLife&&Hal.Hp!=0)
            {
                if (ally.observer.Contains(Hal))
                {
                    ally.Quit(Hal);
                    player4PictureBox.Image = Properties.Resources.rest;
                }
                else
                {
                    ally.Join(Hal);
                    player4PictureBox.Image = Properties.Resources.hal;
                }
            }
        }
    }
}
