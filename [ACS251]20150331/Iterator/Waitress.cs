using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class Waitress
    {
        private Menu A;
        private Menu B;

        public Waitress()
        {
            this.A = new AMenu();
            this.B = new BMenu();
        }

        public void PrintMenu()
        {
            AMenuIteator aMenuIteator = new AMenuIteator(((AMenu)A).GetMenuItems());
            BMenuIteator bMenuIteator = new BMenuIteator(((BMenu)B).GetMenuItems());

            Console.WriteLine("AMenu");
            PrintMenu(aMenuIteator);
            Console.WriteLine("=======================================");
            Console.WriteLine("=======================================");
            Console.WriteLine("BMenu");
            PrintMenu(bMenuIteator);
        }

        private void PrintMenu(IEnumerator<MenuItem> Iterator)
        {
            while (Iterator.MoveNext())
                Console.WriteLine(Iterator.Current.Name +
                    " 價格:" + Iterator.Current.Price.ToString());
        }
    }
}