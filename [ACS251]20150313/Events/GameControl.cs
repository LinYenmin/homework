using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events
{
    public class GameControl
    {
        private Attack attack;
        public Players[] players;
        private Players player1;
        private Players player2;
        private Players player3;
        private Players player4;
        public string DisplayMessage;
        private Random rand;

        public bool gameOver { get; set; }

        public string allteam;

        public GameControl()
        {
            gameOver = false;
            player1 = new Players() { Name = "Thor", HP = 6500, InTeam = true };
            player2 = new Players() { Name = "IronMan", HP = 5800, InTeam = true };
            player3 = new Players() { Name = "Hulk", HP = 6600, InTeam = true };
            player4 = new Players() { Name = "Captain", HP = 5400, InTeam = true };
            players = new Players[] { player1, player2, player3, player4 };
            rand = new Random();
        }

        public int OnAttack()
        {
            for (int x = 0; x < players.Length; x++)
            {
                if (players[x].InTeam)
                {
                    gameOver = false;
                    break;
                }
                else
                    gameOver = true;
            }

            if (gameOver == false)
            {
                attack = new Attack();
                DisplayMessage = string.Empty;
                int i;

                AttackEventArgs attackEventArgs = new AttackEventArgs();

                do
                {
                    i = rand.Next(0, 4);
                    attackEventArgs.Name = players[i].Name;
                } while (!players[i].InTeam);

                foreach (Players p in players)
                {
                    if (p.Name == attackEventArgs.Name)
                        attack.OnAttack += p.OnAttack;
                    if (p.Name != attackEventArgs.Name && p.InTeam)
                        attack.OnAttack += p.Help;
                }

                attack.BeAttacked(attackEventArgs);

                foreach (Players p in players)
                {
                    if (p.Name == attackEventArgs.Name)
                        DisplayMessage += p.DisplayMessage;
                }

                foreach (Players p in players)
                {
                    if (p.Name != attackEventArgs.Name && p.InTeam)
                        DisplayMessage += p.DisplayMessage;
                }

                return i;
            }
            else
                return 0;
        }
    }
}