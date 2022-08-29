using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTest
{
    public class Person
    {
        public string Name { get; set; } = "";
        public int Age { get; set; }
        public string Gender { get; set; } = "";
        public ValueUnitPair Weight { get; set; } = new();
        public ValueUnitPair Height { get; set; } = new();
        /// <summary>
        /// 골격근량
        /// </summary>
        public ValueUnitPair SkeletalMuscleMass { get; set; } = new();
        /// <summary>
        /// 체지방량
        /// </summary>
        public ValueUnitPair BodyFatMass { get; set; } = new();
        /// <summary>
        /// 체수분
        /// </summary>
        public ValueUnitPair TotalBodyWater { get; set; } = new();
        public ValueUnitPair Protein { get; set; } = new();
        public Dictionary<DateTime, List<Food>> EatenDictByDate = new();
        public List<EatenList> EatenList { get; set; } = new();
    }
}
