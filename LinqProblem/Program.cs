// See https://aka.ms/new-console-template for more information
using LinqTest;

Console.WriteLine("Hello, World!");

var people = GetPeople();

var ddd = "";
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
            { new DateTime(2022, 08, 18), new() { foods[24], foods[22], foods[01] } },
            { new DateTime(2022, 08, 19), new() { foods[09], foods[20], foods[09] } },
        },
        EatenList = new()
        {
            new(){ EatenDate = new DateTime(2022, 08, 01), Foods = new() { foods[20], foods[23], foods[03] } },
            new(){ EatenDate = new DateTime(2022, 08, 03), Foods = new() { foods[18], foods[22], foods[14] } },
            new(){ EatenDate = new DateTime(2022, 08, 05), Foods = new() { foods[20], foods[19], foods[22] } },
            new(){ EatenDate = new DateTime(2022, 08, 06), Foods = new() { foods[16], foods[02], foods[07] } },
            new(){ EatenDate = new DateTime(2022, 08, 16), Foods = new() { foods[15], foods[01], foods[06] } },
            new(){ EatenDate = new DateTime(2022, 08, 18), Foods = new() { foods[24], foods[22], foods[01] } },
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
            { new DateTime(2022, 08, 27), new() { foods[24], foods[21], foods[24] } },
            { new DateTime(2022, 08, 29), new() { foods[17], foods[22], foods[04] } },
        },
        EatenList = new()
        {
            new(){ EatenDate = new DateTime(2022, 08, 05), Foods = new() { foods[03], foods[14], foods[01] } },
            new(){ EatenDate = new DateTime(2022, 08, 13), Foods = new() { foods[09], foods[06], foods[09] } },
            new(){ EatenDate = new DateTime(2022, 08, 16), Foods = new() { foods[08], foods[09], foods[01] } },
            new(){ EatenDate = new DateTime(2022, 08, 20), Foods = new() { foods[22], foods[11], foods[13] } },
            new(){ EatenDate = new DateTime(2022, 08, 22), Foods = new() { foods[08], foods[22], foods[10] } },
            new(){ EatenDate = new DateTime(2022, 08, 27), Foods = new() { foods[24], foods[21], foods[24] } },
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
        Name = "계란과자",
        Nutrition = new()
        {
            ServingSize = new() { Unit = "g", Value = 100 },
            Calories = new() { Unit = "kcal", Value = 348.00 },
            Fat = new() { Unit = "g", Value = 10.50 },
            Carbohydrate = new() { Unit = "g", Value = 29.00 },
            Protein = new() { Unit = "g", Value = 11.00 }
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