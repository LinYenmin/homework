using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Waitress cindy = new Waitress();
            cindy.PrintMenu();
            /*
            Menu a = new AMenu();
            AMenuIteator aMenuIteator = new AMenuIteator(((AMenu)a).GetMenuItems());

            Menu b = new BMenu();
            BMenuIteator bMenuIteator = new BMenuIteator(((BMenu)b).GetMenuItems());

            while (aMenuIteator.MoveNext())
                Console.WriteLine(aMenuIteator.Current.Name +
                    " 價格:" + aMenuIteator.Current.Price.ToString());

            Console.WriteLine("================================");

            while (bMenuIteator.MoveNext())
                Console.WriteLine(bMenuIteator.Current.Name +
                    " 價格:" + bMenuIteator.Current.Price.ToString());
             */

            while ("q" != Console.ReadLine()) ;
        }
    }
}