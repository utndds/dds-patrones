﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <summary>
    /// The 'Strategy' abstract class
    /// </summary>
    abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }
}
