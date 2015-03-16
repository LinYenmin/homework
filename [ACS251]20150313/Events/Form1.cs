using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events
{
    public partial class Form1 : Form
    {
        public GameControl game;
        private Label[] labels;
        private PictureBox[] pictureBoxs;
        private Image[] images;
        private int playerNow;
        private System.Media.SoundPlayer sound;

        public Form1()
        {
            InitializeComponent();

            labels = new Label[] { this.HP1Label, this.HP2Label, this.HP3Label, this.HP4Label };
            pictureBoxs = new PictureBox[] { this.pictureBox1, this.pictureBox2, this.pictureBox3, this.pictureBox4 };
            images = new Image[] { Properties.Resources.thor, Properties.Resources.ironman,
                                   Properties.Resources.hulk, Properties.Resources.captain,
                                   Properties.Resources.AL0021, Properties.Resources.die };

            sound = new System.Media.SoundPlayer(Properties.Resources.attack);

            game = new GameControl();
            UpdateUIFirst();
        }

        private void AttackButton_Click(object sender, EventArgs e)
        {
            if (game.gameOver == false)
            {
                sound.Play();
                playerNow = game.OnAttack();
            }

            UpdateUI();
        }

        public void UpdateUIFirst()
        {
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].Text = game.players[i].HP.ToString();
                if (game.players[i].HP == 0)
                    pictureBoxs[i].Image = images[5];
            }

            ResultRichTextBox.Text = "遇到敵人了~";
        }

        public void UpdateUI()
        {
            if (game.gameOver == false)
            {
                labels[playerNow].Text = game.players[playerNow].HP.ToString();
                if (game.players[playerNow].HP == 0)
                    pictureBoxs[playerNow].Image = images[5];

                ResultRichTextBox.Text = game.DisplayMessage;
            }
            else
                ResultRichTextBox.Text = "遊戲結束";
        }

        private void InAndOut(object sender, EventArgs e)
        {
            if (game.gameOver == false)
            {
                int i;

                for (i = 0; i < pictureBoxs.Length; i++)
                {
                    if ((PictureBox)sender == pictureBoxs[i])
                    {
                        if (game.players[i].HP > 0)
                        {
                            game.players[i].InTeam = !(game.players[i].InTeam);
                            if (game.players[i].InTeam)
                                pictureBoxs[i].Image = images[i];
                            else
                                pictureBoxs[i].Image = images[4];
                        }
                        break;
                    }
                }
            }
        }
    }
}