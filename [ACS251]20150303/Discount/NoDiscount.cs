﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketDiscount
{
    class NoDiscount:IDiscount
    {
        public double Calculate(double price)
        {
            return price;
        }
    }
}
