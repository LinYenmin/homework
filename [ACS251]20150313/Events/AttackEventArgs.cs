using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class AttackEventArgs : EventArgs
    {
        //private Random rnd = new Random();
        public int Hurt { get; set; }

        /*
        public int Hurt
        {
            get { return this.hurt; }
            set { this.hurt = rnd.Next(500, 1000); }
        }
         */

        public string Name { get; set; }
    }
}