using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTest.Question
{
    public static partial class Question
    {
        // 초
        public static void Number1(List<Person> people)
        {
            // BMI 가 21 이상인 수치의 사람들을 선별해주세요
            var dietpeople = people.Where(x => CalcBMI(x.Height.Value, x.Weight.Value) >= 21);

            foreach (var person in dietpeople)
            {                
                Console.WriteLine($"{person.Name}의 BMI는 {CalcBMI(person.Height.Value, person.Weight.Value)}입니다. 체중관리에 신경쓰셔야겠네요");
            }

            static double CalcBMI(double height, double weight)
            {
                return weight / Math.Pow(height / 100, 2);
            }
        }

        // 중
        public static void Number2(List<Person> people)
        {
            // 섭취한 음식의 총 칼로리의 순서대로 사람들을 나열해서 출력해주세요
            var topfoodfighter = people.OrderByDescending(x => x.EatenDictByDate.SelectMany(y => y.Value).Sum(z=>z.Nutrition.Calories.Value));

            foreach (var fighter in topfoodfighter)
            {
                var sumofcalorie = fighter.EatenDictByDate.SelectMany(y => y.Value).Sum(z => z.Nutrition.Calories.Value);
                Console.WriteLine($"{fighter.Name}은 총 {sumofcalorie}를 먹었습니다");
            }
        }

        // 고
        public static void Number3(List<Person> people)
        {
            // 평균 지방 섭취량보다 많은 지방을 먹는 사람들을 나열해서 출력해주세요
            var oilypeople = people
                .Where(p => 
                p.EatenList
                    .SelectMany(v => v.Foods)
                    .Sum(f => f.Nutrition.Fat.Value) >
                people.Average(p => 
                p.EatenList
                    .SelectMany(f => f.Foods)
                    .Select(f => f.Nutrition)
                    .Sum(v => v.Fat.Value)))                
                .Select
                (
                    x => new 
                    { 
                        x.Name, 
                        fatSum = x.EatenList.SelectMany(y=>y.Foods).Sum(z=>z.Nutrition.Fat.Value) 
                    }
                );

            foreach (var person in oilypeople)
            {                
                Console.WriteLine($"{person.Name}은 지방을 {person.fatSum}g 섭취했습니다 주의하세요");
            }
        }
    }
}
