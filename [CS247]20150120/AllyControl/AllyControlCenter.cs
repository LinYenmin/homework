using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllyControl
{
    abstract class AllyControlCenter
    {
        public List<IObserver> observer = new List<IObserver>();

        string allyName;

        public string AllyName
        {
            get { return allyName; }
            set { allyName = value; }
        }

        public void Join(IObserver obs)
        {
            observer.Add(obs);
        }

        public void Quit(IObserver obs)
        {
            observer.Remove(obs);
        }

        public abstract string NotifyObserver(string name);

    }
}
