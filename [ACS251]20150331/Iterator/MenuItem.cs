﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public MenuItem(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
