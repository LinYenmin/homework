﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events
{
    public class Dirty
    {
        public string SomeDirty { get; set; }

        public void DirtyWord(object sender, EventArgs e)
        {
            this.SomeDirty += "FF-";
        }
    }
}
