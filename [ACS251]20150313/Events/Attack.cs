using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events
{
    internal class Attack
    {
        public event EventHandler<AttackEventArgs> OnAttack;

        private Random rnd = new Random();
        public AttackEventArgs attackEventArg;

        public void BeAttacked(EventArgs e)
        {
            if (e is AttackEventArgs)
            {
                this.attackEventArg = e as AttackEventArgs;
                attackEventArg.Hurt = rnd.Next(1000, 2000);
                this.OnAttack(this, this.attackEventArg);
            }
        }
    }
}