using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTest
{
    public class Nutrition
    {
        public ValueUnitPair ServingSize {get; set;} = new();
        public ValueUnitPair Calories { get; set; } = new();
        public ValueUnitPair Fat { get; set; } = new();
        public ValueUnitPair Carbohydrate { get; set; } = new();
        public ValueUnitPair Protein { get; set; } = new();
    }
}
