// See https://aka.ms/new-console-template for more information
using LinqTest;

Console.WriteLine("Hello, World!");

var people = GetPeople();

/*
 * 출력에 관련한 문제는 foreach와 함께 Console.WriteLine()를 사용합니다. 
 * foreach안에는 Console.WriteLine() 외에는 사용하지 않습니다.
 * 쿼리문은 한 줄로 끝나야 합니다. (Linq 식을 끊지 않는 것)
 */


/* CWS 初
 * Q1. 서울이의 나이는 몇살인지 구하시오
 */


/* CWS 初
 * Q2. 사람들이 나이가 어린 순서로 정렬해서 출력하시오.
 *     Console.WriteLine({나이});
 */


/*  ljy 初
 * Q3. 여성들의 평균 골격근량을 구하시오
 */


/* CJS 初
 * Q4. 남성들의 단백질량 평균을 구하시오
 */


/* KSH 初
 * Q5. BMI 가 21 이상인 수치의 사람들 구해서 출력하시오  (아래 만들어진 CalcBMI 함수를 이용)
 *     Console.WriteLine($"{이름}의 BMI는 {CalcBMI(x, y)}입니다. 체중관리에 신경쓰셔야겠네요");
 */

double CalcBMI(double height, double weight)
{
    return weight / Math.Pow(height / 100, 2);
}


/* LJY 中
 * Q6. 몸무게가 50이상인 사람들이 먹은 음식중에 최고칼로리를 구하시오
 */


/* CWS 中
 * Q7. 체지방률이 15% 이하인 사람들의 이름과 체지방률을 구해서 출력하시오  
 *     (이 때, 체지방률 식은 BodyFatMass / Weight * 100)
 *      Console.WriteLine($"{이름}: {체지방률}"); 같은 형식으로 출력
 */


/* LJY 中
 * Q8. 나이가 30대인 사람들의 전체 기간 평균 칼로리 섭취량을 구하시오
 */


/* KSH 中
 * Q9. 섭취한 음식의 총 칼로리의 높은 순서대로 사람들을 나열해서 출력해주세요
 *      Console.WriteLine($"{이름}은 {총칼로리}를 먹었습니다");
 */


/*  CJS 中
 * Q10. 2022.08.13일에 모든사람의 먹은 음식을 나열하고 겹치는 음식은 없도록 하시오 
 *      (EatenDictByDate를 사용하지 않고 EatenList를 사용하여 구하시오)    
 */


/* KSH 高
 * TODO 문제 바꾸어야함 아직 풀지 말아주세요.
 * 
 * Q11. 평균 지방 섭취량보다 많은 지방을 먹는 사람들을 나열해서 출력해주세요
 *      foreach문 안에서 linq 식을 허용 합니다.
 *      아래와같은 console 형식을 채용해주세요.
 *      Console.WriteLine($"{이름}은 지방을 {지방}g 섭취했습니다 주의하세요");
 */


/* CJS 高
 * Q12. 24일에 소비된 음식과 28일에 소비된 음식 중 더 칼로리가 소비된 날의 칼로리의 합을 구하시오 
 *      (EatenList를 사용하지 않고 EatenDictByDate를 사용하여 구하시오)
 */

/* KMJ 中
 * Q13. BMI는 몸무게(kg)을 키(m)의 제곱으로 나눠 계산합니다. (171cm, 60kg 일경우 60 / (1.71 * 1.71)으로 계산)
 *  남자들의 평균 BMI, 여자들의 평균 BMI를 계산해서
 *  Dictionary<string, double>으로 {"Male", ??.? }, {"Female", ??.? }와 같이 값이 나오게 LINQ를 구성해보세요.
 *  Male, Female 어떤 key가 먼저 나와도 상관 없습니다.
 * 김시내 : Female : 17.024857416819128
 * 신나래 : Female : 20.679522497704312
 * 김서울 : Male : 24.636678200692046
 * 전서라 : Female : 20.390624999999996
 * 신무준 : Male : 24.30914256198347
 * 박사울 : Male : 23.729018234512736
 */

/* KMJ 高
 * Q14. 8월 한 달 중에 사람들을 가장 많이 살찌운 음식을 찾아보려 합니다.
 * A가 8월 1일에 달걀, 달걀, 우유를 먹었고
 * 8월 2일에 우유, 달걀, 대추토마토를 먹었고
 * B가 8월 3일에 우유, 대추토마토, 달걀을 먹었다고 하면
 * 전체적으로 달걀은 4번 나왔고 칼로리로는 74 * 4 = 296
 * 우유는 3번 나왔고 칼로리는 62 * 3 = 186
 * 대추토마토는 2번 나왔고 칼로리는 16 * 2 = 32
 * 여기서, 각 음식의 이름을 Key로 하고 그 칼로리를 Value로 하는 Dictionary<string, double>를 구성하되
 * 칼로리가 높은 (value가 큰) 순서대로 정렬되도록 LINQ로 구성해보세요.
 */


/* KMJ 高
 * Q15. 8월 중에서, 하루에 섭취한 음식들의 칼로리 합계의 개인별 최대값을 기준으로 사람들을 내림차순으로 정렬하세요.
 * ex) A가 8월 1일에 300, 8월 5일에 600, B가 8월 3일에 100, 8월 10일에 900 칼로리 섭취했으면
 * 결과는 [B, A]
 * 
 */
*/


var doIt = "위에 문제를 푸는데에 있어 이 asdf 변수가 없으면 컴파일에 문제가 생겨 마우스를 올려 놓아도 타입을 알 수 없으니, 지우지 마시길 권합니다.";


List<Person> GetPeople()
{
    var foods = GetFoods();
    Person person1 = new() {
        Name = "김시내",
        Age = 28,
        Gender = new Gender().Female,
        Weight = new() { Unit = "kg", Value = 45.4 },
        Height = new() { Unit = "cm", Value = 163.3 },
        SkeletalMuscleMass = new() { Unit = "kg", Value = 19.3 },
        BodyFatMass = new() { Unit = "kg", Value = 19.5 },
        TotalBodyWater = new() { Unit = "kg", Value = 26.2 },
        Protein = new() { Unit = "kg", Value = 7.1 },
        EatenDictByDate = new()
        {
            { new DateTime(2022, 08, 12), new(){ foods[0], foods[6], foods[20] } },
            { new DateTime(2022, 08, 13), new(){ foods[6], foods[14], foods[3] } },
            { new DateTime(2022, 08, 22), new(){ foods[8], foods[18], foods[4] } },
            { new DateTime(2022, 08, 23), new(){ foods[10], foods[22], foods[8] } },
            { new DateTime(2022, 08, 24), new(){ foods[12], foods[6], foods[9] } },
            { new DateTime(2022, 08, 25), new(){ foods[14], foods[3], foods[12] } },
            { new DateTime(2022, 08, 31), new(){ foods[16], foods[9], foods[15] } },
        },
        EatenList = new()
        {
            new(){ EatenDate = new DateTime(2022, 08, 12), Foods = new() { foods[0], foods[6], foods[20] } },
            new(){ EatenDate = new DateTime(2022, 08, 13), Foods = new() { foods[6], foods[14], foods[3] } },
            new(){ EatenDate = new DateTime(2022, 08, 22), Foods = new() { foods[8], foods[18], foods[4] } },
            new(){ EatenDate = new DateTime(2022, 08, 23), Foods = new() { foods[10], foods[22], foods[8] } },
            new(){ EatenDate = new DateTime(2022, 08, 24), Foods = new() { foods[12], foods[6], foods[9] } },
            new(){ EatenDate = new DateTime(2022, 08, 25), Foods = new() { foods[14], foods[3], foods[12] } },
            new(){ EatenDate = new DateTime(2022, 08, 31), Foods = new() { foods[16], foods[9], foods[15] } },
        }
    };

    Person person2 = new()
    {
        Name = "신나래",
        Age = 36,
        Gender = new Gender().Female,
        Weight = new() { Unit = "kg", Value = 56.3 },
        Height = new() { Unit = "cm", Value = 165 },
        SkeletalMuscleMass = new() { Unit = "kg", Value = 21.2 },
        BodyFatMass = new() { Unit = "kg", Value = 16.7 },
        TotalBodyWater = new() { Unit = "kg", Value = 29.1 },
        Protein = new() { Unit = "kg", Value = 7.7 },
        EatenDictByDate = new()
        {
            { new DateTime(2022, 08, 01), new(){ foods[01], foods[08], foods[23] } },
            { new DateTime(2022, 08, 03), new(){ foods[07], foods[15], foods[03] } },
            { new DateTime(2022, 08, 04), new(){ foods[08], foods[22], foods[04] } },
            { new DateTime(2022, 08, 08), new(){ foods[14], foods[09], foods[11] } },
            { new DateTime(2022, 08, 17), new(){ foods[15], foods[18], foods[12] } },
            { new DateTime(2022, 08, 24), new(){ foods[20], foods[23], foods[21] } },
            { new DateTime(2022, 08, 28), new(){ foods[23], foods[06], foods[07] } },
        },
        EatenList = new()
        {
            new(){ EatenDate = new DateTime(2022, 08, 1), Foods = new() { foods[0], foods[6], foods[20] } },
            new(){ EatenDate = new DateTime(2022, 08, 3), Foods = new() { foods[6], foods[14], foods[3] } },
            new(){ EatenDate = new DateTime(2022, 08, 4), Foods = new() { foods[8], foods[18], foods[4] } },
            new(){ EatenDate = new DateTime(2022, 08, 8), Foods = new() { foods[10], foods[22], foods[8] } },
            new(){ EatenDate = new DateTime(2022, 08, 17), Foods = new() { foods[12], foods[6], foods[9] } },
            new(){ EatenDate = new DateTime(2022, 08, 24), Foods = new() { foods[14], foods[3], foods[12] } },
            new(){ EatenDate = new DateTime(2022, 08, 28), Foods = new() { foods[16], foods[9], foods[15] } },
        }
    };

    Person person3 = new()
    {
        Name = "김서울",
        Age = 27,
        Gender = new Gender().Male,
        Weight = new() { Unit = "kg", Value = 71.2 },
        Height = new() { Unit = "cm", Value = 170 },
        SkeletalMuscleMass = new() { Unit = "kg", Value = 36.5 },
        BodyFatMass = new() { Unit = "kg", Value = 7.8 },
        TotalBodyWater = new() { Unit = "kg", Value = 46.4 },
        Protein = new() { Unit = "kg", Value = 12.7 },
        EatenDictByDate = new()
        {
            { new DateTime(2022, 08, 02), new() { foods[01], foods[07], foods[16] } },
            { new DateTime(2022, 08, 10), new() { foods[02], foods[08], foods[18] } },
            { new DateTime(2022, 08, 13), new() { foods[03], foods[09], foods[21] } },
            { new DateTime(2022, 08, 15), new() { foods[03], foods[09], foods[21] } },
            { new DateTime(2022, 08, 20), new() { foods[04], foods[09], foods[22] } },
            { new DateTime(2022, 08, 24), new() { foods[05], foods[13], foods[22] } },
            { new DateTime(2022, 08, 25), new() { foods[06], foods[13], foods[23] } },
        },
        EatenList = new()
        {
            new(){ EatenDate = new DateTime(2022, 08, 02), Foods = new() { foods[01], foods[07], foods[16] } },
            new(){ EatenDate = new DateTime(2022, 08, 10), Foods = new() { foods[02], foods[08], foods[18] } },
            new(){ EatenDate = new DateTime(2022, 08, 13), Foods = new() { foods[03], foods[09], foods[21] } },
            new(){ EatenDate = new DateTime(2022, 08, 15), Foods = new() { foods[03], foods[09], foods[21] } },
            new(){ EatenDate = new DateTime(2022, 08, 20), Foods = new() { foods[04], foods[09], foods[22] } },
            new(){ EatenDate = new DateTime(2022, 08, 24), Foods = new() { foods[05], foods[13], foods[22] } },
            new(){ EatenDate = new DateTime(2022, 08, 25), Foods = new() { foods[06], foods[13], foods[23] } },
        }
    };

    Person person4 = new()
    {
        Name = "전서라",
        Age = 26,
        Gender = new Gender().Female,
        Weight = new() { Unit = "kg", Value = 52.2 },
        Height = new() { Unit = "cm", Value = 160 },
        SkeletalMuscleMass = new() { Unit = "kg", Value = 21.1 },
        BodyFatMass = new() { Unit = "kg", Value = 13.2 },
        TotalBodyWater = new() { Unit = "kg", Value = 28.5 },
        Protein = new() { Unit = "kg", Value = 7.7 },
        EatenDictByDate = new()
        {
            { new DateTime(2022, 08, 10), new() { foods[18], foods[18], foods[12] } },
            { new DateTime(2022, 08, 11), new() { foods[17], foods[05], foods[12] } },
            { new DateTime(2022, 08, 16), new() { foods[11], foods[01], foods[12] } },
            { new DateTime(2022, 08, 19), new() { foods[06], foods[05], foods[14] } },
            { new DateTime(2022, 08, 24), new() { foods[05], foods[21], foods[18] } },
            { new DateTime(2022, 08, 26), new() { foods[04], foods[23], foods[08] } },
            { new DateTime(2022, 08, 29), new() { foods[04], foods[15], foods[17] } },
        },
        EatenList = new()
        {
            new(){ EatenDate = new DateTime(2022, 08, 10), Foods = new() { foods[18], foods[18], foods[12] } },
            new(){ EatenDate = new DateTime(2022, 08, 11), Foods = new() { foods[17], foods[05], foods[12] } },
            new(){ EatenDate = new DateTime(2022, 08, 16), Foods = new() { foods[11], foods[01], foods[12] } },
            new(){ EatenDate = new DateTime(2022, 08, 19), Foods = new() { foods[06], foods[05], foods[14] } },
            new(){ EatenDate = new DateTime(2022, 08, 24), Foods = new() { foods[05], foods[21], foods[18] } },
            new(){ EatenDate = new DateTime(2022, 08, 26), Foods = new() { foods[04], foods[23], foods[08] } },
            new(){ EatenDate = new DateTime(2022, 08, 29), Foods = new() { foods[04], foods[15], foods[17] } },
        }
    };

    Person person5 = new()
    {
        Name = "신무준",
        Age = 32,
        Gender = new Gender().Male,
        Weight = new() { Unit = "kg", Value = 75.3 },
        Height = new() { Unit = "cm", Value = 176 },
        SkeletalMuscleMass = new() { Unit = "kg", Value = 37.6 },
        BodyFatMass = new() { Unit = "kg", Value = 9.8 },
        TotalBodyWater = new() { Unit = "kg", Value = 48.1 },
        Protein = new() { Unit = "kg", Value = 13.1 },
        EatenDictByDate = new()
        {
            { new DateTime(2022, 08, 01), new() { foods[20], foods[23], foods[03] } },
            { new DateTime(2022, 08, 03), new() { foods[18], foods[22], foods[14] } },
            { new DateTime(2022, 08, 05), new() { foods[20], foods[19], foods[22] } },
            { new DateTime(2022, 08, 06), new() { foods[16], foods[02], foods[07] } },
            { new DateTime(2022, 08, 16), new() { foods[15], foods[01], foods[06] } },
            { new DateTime(2022, 08, 18), new() { foods[0], foods[22], foods[01] } },
            { new DateTime(2022, 08, 19), new() { foods[09], foods[20], foods[09] } },
        },
        EatenList = new()
        {
            new(){ EatenDate = new DateTime(2022, 08, 01), Foods = new() { foods[20], foods[23], foods[03] } },
            new(){ EatenDate = new DateTime(2022, 08, 03), Foods = new() { foods[18], foods[22], foods[14] } },
            new(){ EatenDate = new DateTime(2022, 08, 05), Foods = new() { foods[20], foods[19], foods[22] } },
            new(){ EatenDate = new DateTime(2022, 08, 06), Foods = new() { foods[16], foods[02], foods[07] } },
            new(){ EatenDate = new DateTime(2022, 08, 16), Foods = new() { foods[15], foods[01], foods[06] } },
            new(){ EatenDate = new DateTime(2022, 08, 18), Foods = new() { foods[0], foods[22], foods[01] } },
            new(){ EatenDate = new DateTime(2022, 08, 19), Foods = new() { foods[09], foods[20], foods[09] } },
        }
    };

    Person person6 = new()
    {
        Name = "박사울",
        Age = 35,
        Gender = new Gender().Male,
        Weight = new() { Unit = "kg", Value = 78.6 },
        Height = new() { Unit = "cm", Value = 182 },
        SkeletalMuscleMass = new() { Unit = "kg", Value = 39.8 },
        BodyFatMass = new() { Unit = "kg", Value = 9.5 },
        TotalBodyWater = new() { Unit = "kg", Value = 50.6 },
        Protein = new() { Unit = "kg", Value = 13.9 },
        EatenDictByDate = new()
        {
            { new DateTime(2022, 08, 05), new() { foods[03], foods[14], foods[01] } },
            { new DateTime(2022, 08, 13), new() { foods[09], foods[06], foods[09] } },
            { new DateTime(2022, 08, 16), new() { foods[08], foods[09], foods[01] } },
            { new DateTime(2022, 08, 20), new() { foods[22], foods[11], foods[13] } },
            { new DateTime(2022, 08, 22), new() { foods[08], foods[22], foods[10] } },
            { new DateTime(2022, 08, 27), new() { foods[0], foods[21], foods[23] } },
            { new DateTime(2022, 08, 29), new() { foods[17], foods[22], foods[04] } },
        },
        EatenList = new()
        {
            new(){ EatenDate = new DateTime(2022, 08, 05), Foods = new() { foods[03], foods[14], foods[01] } },
            new(){ EatenDate = new DateTime(2022, 08, 13), Foods = new() { foods[09], foods[06], foods[09] } },
            new(){ EatenDate = new DateTime(2022, 08, 16), Foods = new() { foods[08], foods[09], foods[01] } },
            new(){ EatenDate = new DateTime(2022, 08, 20), Foods = new() { foods[22], foods[11], foods[13] } },
            new(){ EatenDate = new DateTime(2022, 08, 22), Foods = new() { foods[08], foods[22], foods[10] } },
            new(){ EatenDate = new DateTime(2022, 08, 27), Foods = new() { foods[0], foods[21], foods[23] } },
            new(){ EatenDate = new DateTime(2022, 08, 29), Foods = new() { foods[17], foods[22], foods[04] } },
        }
    };

    List<Person> people = new()
    {
        person1,person2,person3,person4,person5,person6
    };

    return people;
}

List<Food> GetFoods()
{  
    Food food1 = new()
    {
        Name = "소시지프레즐",
        Nutrition = new()
        {
            ServingSize = new() { Unit = "g", Value = 100 },
            Calories = new() { Unit = "kcal", Value = 348.00 },
            Fat = new() { Unit = "g", Value = 10.50 },
            Carbohydrate = new() { Unit = "g", Value = 29.00 },
            Protein = new() { Unit = "g", Value = 11.00 }
        }
    };

    Food food2 = new()
    {
        Name = "계란과자",
        Nutrition = new()
        {
            ServingSize = new() { Unit = "g", Value = 50 },
            Calories = new() { Unit = "kcal", Value = 232.00 },
            Fat = new() { Unit = "g", Value = 8.00 },
            Carbohydrate = new() { Unit = "g", Value = 37.00 },
            Protein = new() { Unit = "g", Value = 3.00 }
        }
    };

    Food food3 = new()
    {
        Name = "닭가슴살 소시지 고구마 핫도그",
        Nutrition = new()
        {
            ServingSize = new() { Unit = "g", Value = 100 },
            Calories = new() { Unit = "kcal", Value = 200.00 },
            Fat = new() { Unit = "g", Value = 5.00 },
            Carbohydrate = new() { Unit = "g", Value = 29.00 },
            Protein = new() { Unit = "g", Value = 9.00 }
        }
    };

    Food food4 = new()
    {
        Name = "맛있닭 닭가슴살 크리스피 한끼핫도그 훈제",
        Nutrition = new()
        {
            ServingSize = new() { Unit = "g", Value = 100 },
            Calories = new() { Unit = "kcal", Value = 195.00 },
            Fat = new() { Unit = "g", Value = 3.00 },
            Carbohydrate = new() { Unit = "g", Value = 13.00 },
            Protein = new() { Unit = "g", Value = 13.00 }
        }
    };

    Food food5 = new()
    {
        Name = "쌀국수",
        Nutrition = new()
        {
            ServingSize = new() { Unit = "g", Value = 300 },
            Calories = new() { Unit = "kcal", Value = 320.00 },
            Fat = new() { Unit = "g", Value = 4.20 },
            Carbohydrate = new() { Unit = "g", Value = 55.00 },
            Protein = new() { Unit = "g", Value = 16.00 }
        }
    };

    Food food6 = new()
    {
        Name = "비비큐 황금올리브치킨",
        Nutrition = new()
        {
            ServingSize = new() { Unit = "g", Value = 100 },
            Calories = new() { Unit = "kcal", Value = 312.00 },
            Fat = new() { Unit = "g", Value = 20.00 },
            Carbohydrate = new() { Unit = "g", Value = 11.00 },
            Protein = new() { Unit = "g", Value = 21.00 }
        }
    };

    Food food7 = new()
    {
        Name = "건포도",
        Nutrition = new()
        {
            ServingSize = new() { Unit = "g", Value = 100 },
            Calories = new() { Unit = "kcal", Value = 299.00 },
            Fat = new() { Unit = "g", Value = 0.46 },
            Carbohydrate = new() { Unit = "g", Value = 79.18 },
            Protein = new() { Unit = "g", Value = 3.07 }
        }
    };

    Food food8 = new()
    {
        Name = "과일 샐러드",
        Nutrition = new()
        {
            ServingSize = new() { Unit = "g", Value = 100 },
            Calories = new() { Unit = "kcal", Value = 57.00 },
            Fat = new() { Unit = "g", Value = 0.86 },
            Carbohydrate = new() { Unit = "g", Value = 13.16 },
            Protein = new() { Unit = "g", Value = 0.67 }
        }
    };

    Food food9 = new()
    {
        Name = "달걀",
        Nutrition = new()
        {
            ServingSize = new() { Unit = "개", Value = 1 },
            Calories = new() { Unit = "kcal", Value = 74.00 },
            Fat = new() { Unit = "g", Value = 4.97 },
            Carbohydrate = new() { Unit = "g", Value = 0.38 },
            Protein = new() { Unit = "g", Value = 6.29 }
        }
    };

    Food food10 = new()
    {
        Name = "통밀빵",
        Nutrition = new()
        {
            ServingSize = new() { Unit = "g", Value = 100 },
            Calories = new() { Unit = "kcal", Value = 246.00 },
            Fat = new() { Unit = "g", Value = 4.20 },
            Carbohydrate = new() { Unit = "g", Value = 12.26 },
            Protein = new() { Unit = "g", Value = 2.37 }
        }
    };

    Food food11 = new()
    {
        Name = "대추토마토",
        Nutrition = new()
        {
            ServingSize = new() { Unit = "g", Value = 100 },
            Calories = new() { Unit = "kcal", Value = 16 },
            Fat = new() { Unit = "g", Value = 0.18 },
            Carbohydrate = new() { Unit = "g", Value = 3.54 },
            Protein = new() { Unit = "g", Value = 0.79 }
        }
    };

    Food food12 = new()
    {
        Name = "삼겹살",
        Nutrition = new()
        {
            ServingSize = new() { Unit = "g", Value = 200 },
            Calories = new() { Unit = "kcal", Value = 661 },
            Fat = new() { Unit = "g", Value = 56.43 },
            Carbohydrate = new() { Unit = "g", Value = 1.18 },
            Protein = new() { Unit = "g", Value = 56.43 }
        }
    };

    Food food13 = new()
    {
        Name = "목살",
        Nutrition = new()
        {
            ServingSize = new() { Unit = "g", Value = 100 },
            Calories = new() { Unit = "kcal", Value = 269 },
            Fat = new() { Unit = "g", Value = 18.86 },
            Carbohydrate = new() { Unit = "g", Value = 0 },
            Protein = new() { Unit = "g", Value = 23.11 }
        }
    };

    Food food14 = new()
    {
        Name = "우유",
        Nutrition = new()
        {
            ServingSize = new() { Unit = "ml", Value = 100 },
            Calories = new() { Unit = "kcal", Value = 62 },
            Fat = new() { Unit = "g", Value = 3.35 },
            Carbohydrate = new() { Unit = "g", Value = 4.66 },
            Protein = new() { Unit = "g", Value = 3.32 }
        }
    };


    Food food15 = new()
    {
        Name = "대창",
        Nutrition = new()
        {
            ServingSize = new() { Unit = "g", Value = 100 },
            Calories = new() { Unit = "kcal", Value = 158 },
            Fat = new() { Unit = "g", Value = 11.95 },
            Carbohydrate = new() { Unit = "g", Value = 0 },
            Protein = new() { Unit = "g", Value = 12.23 }
        }
    };

    Food food16 = new()
    {
        Name = "나시고랭",
        Nutrition = new()
        {
            ServingSize = new() { Unit = "g", Value = 210 },
            Calories = new() { Unit = "kcal", Value = 346 },
            Fat = new() { Unit = "g", Value = 12.25 },
            Carbohydrate = new() { Unit = "g", Value = 44.95 },
            Protein = new() { Unit = "g", Value = 12.93 }
        }
    };

    Food food17 = new()
    {
        Name = "불고기와퍼",
        Nutrition = new()
        {
            ServingSize = new() { Unit = "g", Value = 278 },
            Calories = new() { Unit = "kcal", Value = 682 },
            Fat = new() { Unit = "g", Value = 28.00 },
            Carbohydrate = new() { Unit = "g", Value = 50.00 },
            Protein = new() { Unit = "g", Value = 28.00 }
        }
    };

    Food food18 = new()
    {
        Name = "콰트로치즈와퍼",
        Nutrition = new()
        {
            ServingSize = new() { Unit = "g", Value = 309 },
            Calories = new() { Unit = "kcal", Value = 769 },
            Fat = new() { Unit = "g", Value = 20.00 },
            Carbohydrate = new() { Unit = "g", Value = 50.00 },
            Protein = new() { Unit = "g", Value = 40.00 }
        }
    };

    Food food19 = new()
    {
        Name = "감자튀김",
        Nutrition = new()
        {
            ServingSize = new() { Unit = "g", Value = 102 },
            Calories = new() { Unit = "kcal", Value = 285 },
            Fat = new() { Unit = "g", Value = 12.00 },
            Carbohydrate = new() { Unit = "g", Value = 40.00 },
            Protein = new() { Unit = "g", Value = 4.00 }
        }
    };

    Food food20 = new()
    {
        Name = "상추 샐러드와 야채 모듬",
        Nutrition = new()
        {
            ServingSize = new() { Unit = "g", Value = 100 },
            Calories = new() { Unit = "kcal", Value = 15 },
            Fat = new() { Unit = "g", Value = 0.15 },
            Carbohydrate = new() { Unit = "g", Value = 3.14 },
            Protein = new() { Unit = "g", Value = 0.74 }
        }
    };

    Food food21 = new()
    {
        Name = "닭 가든 샐러드",
        Nutrition = new()
        {
            ServingSize = new() { Unit = "g", Value = 100 },
            Calories = new() { Unit = "kcal", Value = 72 },
            Fat = new() { Unit = "g", Value = 1.45 },
            Carbohydrate = new() { Unit = "g", Value = 1.93 },
            Protein = new() { Unit = "g", Value = 12.31 }
        }
    };

    Food food22 = new()
    {
        Name = "달걀과 참치 샐러드",
        Nutrition = new()
        {
            ServingSize = new() { Unit = "g", Value = 100 },
            Calories = new() { Unit = "kcal", Value = 196 },
            Fat = new() { Unit = "g", Value = 12.63 },
            Carbohydrate = new() { Unit = "g", Value = 6.26},
            Protein = new() { Unit = "g", Value = 13.71 }
        }
    };

    Food food23 = new()
    {
        Name = "마른오징어",
        Nutrition = new()
        {
            ServingSize = new() { Unit = "g", Value = 100 },
            Calories = new() { Unit = "kcal", Value = 349 },
            Fat = new() { Unit = "g", Value = 5.23 },
            Carbohydrate = new() { Unit = "g", Value = 11.68 },
            Protein = new() { Unit = "g", Value = 59.06 }
        }
    };

    Food food24 = new()
    {
        Name = "킹크랩",
        Nutrition = new()
        {
            ServingSize = new() { Unit = "g", Value = 100 },
            Calories = new() { Unit = "kcal", Value = 84 },
            Fat = new() { Unit = "g", Value = 0.6 },
            Carbohydrate = new() { Unit = "g", Value = 0 },
            Protein = new() { Unit = "g", Value = 18.29 }
        }
    };

    List<Food> Foods = new()
    {
        food1, food2, food3, food4, food5, food6,
        food7, food8, food9, food10, food11, food12,
        food13, food14, food15, food16, food17, food18,
        food19, food20, food21, food22, food23, food24, 
    };

    return Foods;
}