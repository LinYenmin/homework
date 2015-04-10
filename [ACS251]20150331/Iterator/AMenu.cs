using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class AMenu : Menu
    {
        private ArrayList menuItems;

        public AMenu()
        {
            menuItems = new ArrayList();
            AddMenuItem("陽春麵", 35.0);
            AddMenuItem("臭豆腐", 30.0);
            AddMenuItem("蚵仔煎", 50.0);
            AddMenuItem("菜脯蛋", 15.0);
            AddMenuItem("紅豆餅", 10.0);
            AddMenuItem("藥燉排骨", 70.0);
            AddMenuItem("蔥油餅", 25.0);
            AddMenuItem("涼麵", 20.0);
        }

        private void AddMenuItem(string name, double price)
        {
            MenuItem menuItem = new MenuItem(name, price);
            menuItems.Add(menuItem);
        }

        public ArrayList GetMenuItems()
        {
            return this.menuItems;
        }

        public IEnumerator<MenuItem> GetEnumerator()
        {
            return new AMenuIteator(this.menuItems);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}