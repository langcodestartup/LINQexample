﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProblem
{
    public class Food
    {
        public string Name { get; set; } = "";
        public Nutrition Nutrition { get; set; } = new();
    }
}
