using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class FoodList
    {
        public List<string> FoodMenu()
        {
            List<string> Items = new List<string>();
            Items.Add("漢堡");
            Items.Add("薯條");
            Items.Add("沙拉");
            Items.Add("雞塊");
            Items.Add("炸雞");
            Items.Add("飲料");
            Items.Add("咖啡");
            Items.Add("濃湯");
            Items.Add("聖代");
            
            return Items;
        }
    }
}
