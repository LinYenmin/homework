using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class BMenu : Menu
    {
        private MenuItem[] menuItems;
        private const int MAX_COUNT = 8;
        private int index;

        public BMenu()
        {
            index = 0;
            menuItems = new MenuItem[MAX_COUNT];
            AddMenuItem("中式燉肉末佐青蔥蔬菜細麵", 150.0);
            AddMenuItem("油炸發酵豆腐佐醃漬生菜", 80.0);
            AddMenuItem("青蔬牡蠣蛋汁煎餅", 100.0);
            AddMenuItem("台式醃蘿蔔香煎雞蛋", 50.0);
            AddMenuItem("法式焗香奶油煎餅佐相思豆泥", 70.0);
            AddMenuItem("中式精燉豬肋排佐漢方藥", 200.0);
            AddMenuItem("油香煎餅佐嫩綠青蔥", 75.0);
            AddMenuItem("細絲鮮蔬義大利長麵附東方風情特調拌醬", 85.0);
        }

        private void AddMenuItem(string name, double price)
        {
            if (index < MAX_COUNT)
            {
                MenuItem menuItem = new MenuItem(name, price);
                menuItems[index] = menuItem;
            }
            index++;
        }

        public MenuItem[] GetMenuItems()
        {
            return this.menuItems;
        }

        public IEnumerator<MenuItem> GetEnumerator()
        {
            return new BMenuIteator(this.menuItems);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}