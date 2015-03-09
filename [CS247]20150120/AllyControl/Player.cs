using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllyControl
{
    class Player : IObserver
    {
        public string Name { get; set; }
        public int Lv { get; set; }
        private int hp;

        public int Hp
        {
            get
            {
                if (hp >= 0)
                    return this.hp;
                else
                    return 0;
            }
            set
            {
                if (hp >= 0)
                    this.hp = value;
                else
                    hp = 0;
            }
        }

        public Player(string name, int lv, int hp)
        {
            this.Name = name;
            this.Lv = lv;
            this.Hp = hp;
        }


        public string Help()
        {
            string helper = string.Empty;
            helper = string.Format("{0}快來救我!!\n", this.Name);
            return helper;
        }

        public string BeAttacked(AllyControlCenter acc)
        {
            Random rnd = new Random();
            this.Hp -= rnd.Next(200, 1000);

            if (this.Hp == 0)
                acc.Quit(this);

            return acc.NotifyObserver(this.Name);
        }

    }
}
