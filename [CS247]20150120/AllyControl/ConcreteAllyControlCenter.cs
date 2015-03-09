using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllyControl
{
    class ConcreteAllyControlCenter : AllyControlCenter
    {
        public ConcreteAllyControlCenter(string name)
        {
        }

        public override string NotifyObserver(string name)
        {
            string showStatus = string.Format("我是{0},我被攻擊了!!\n", name);

            foreach (object obs in observer)
            {
                if (!((IObserver)obs).Name.Equals(name))
                    showStatus += ((IObserver)obs).Help();
            }

            foreach (object obs in observer)
            {
                if (((IObserver)obs).Name.Equals(name))
                    showStatus += string.Format("{0}的生命值剩下{1}!!\n",name,((Player)obs).Hp);
            }

            return showStatus;
        }
    }
}
