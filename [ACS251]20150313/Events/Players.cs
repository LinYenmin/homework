using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Players
    {
        public string Name { get; set; }

        public bool InTeam { get; set; }

        public string DisplayMessage { get; set; }

        private int hp;

        public int HP
        {
            get
            {
                if (this.hp >= 0)
                {
                    return this.hp;
                }
                else
                {
                    this.InTeam = false;
                    return 0;
                }
            }
            set
            {
                if (this.hp >= 0)
                {
                    this.hp = value;
                }
                else
                {
                    this.InTeam = false;
                    this.hp = 0;
                }
            }
        }

        /*
        public int HP
        {
            get
            {
                if (this.hp >= 0)
                    return this.hp;
                else
                    return 0;
            }
            set
            {
                if (this.hp <= 0)
                    this.hp = 0;
                else
                    this.hp = value;
            }
        }*/

        public void OnAttack(object sender, EventArgs e)
        {
            if (e is AttackEventArgs)
            {
                AttackEventArgs attackEventArgs = e as AttackEventArgs;
                if (attackEventArgs.Name == this.Name)
                {
                    this.HP -= attackEventArgs.Hurt;
                    this.DisplayMessage = string.Format("敵人對 {0} 造成了 {1} 傷害!!\n", this.Name, attackEventArgs.Hurt);
                    this.DisplayMessage += string.Format("{0}的生命值剩下==>{1}!\n", this.Name, this.HP);
                    if (this.HP == 0)
                        this.InTeam = false;
                }
            }
        }

        public void Help(object sender, EventArgs e)
        {
            if (e is AttackEventArgs)
            {
                AttackEventArgs attackEventArgs = e as AttackEventArgs;
                if (attackEventArgs.Name != this.Name && this.InTeam)
                {
                    this.DisplayMessage = string.Format("{0}快來救我!\n", this.Name);
                }
            }
        }
    }
}