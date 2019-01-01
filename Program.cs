using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1)	Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.");
            int firstDigit = 1;
            int secondDigit = 2;
            int thirdDigit = 3;

            Console.WriteLine($"{firstDigit}   {secondDigit}   {thirdDigit}");

            Console.WriteLine("2)	Вывести на экран числа 5, 10 и 21 одно под другим.");
            int numberFive = 5;
            int numberTen = 10;
            int numberTwentyOne = 21;

            Console.WriteLine(numberFive);
            Console.WriteLine(numberTen);
            Console.WriteLine(numberTwentyOne);


            Console.WriteLine("3.	Дано расстояние в сантиметрах. Найти число полных метров в нем.");
            int distanceSantimetr = 351;
            int metrOnSantimetr = 100;
            double distanceMetr = distanceSantimetr / metrOnSantimetr;

            Console.WriteLine($" Расстояние в metr = {distanceMetr}");


            Console.WriteLine("4.	С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?");
            int dayHasPassed = 234;
            int daysInWeek = 7;
            int fullWeek = dayHasPassed / daysInWeek;

            Console.WriteLine($" Полных недель = {fullWeek}");

            Console.WriteLine("5.	Дано двузначное число. Найти: a.	число десятков в нем, b.	число единиц в нем, c.	сумму его цифр, d.	произведение его цифр");
            int twoDigitNumber = 67;
            int ten = 10;
            int digitDecade = twoDigitNumber / ten;
            int digitOne = twoDigitNumber % ten;
            int digitSum = (digitDecade + digitOne);
            int digitMultiplication = (digitDecade * digitOne);
            Console.WriteLine($" Число десятков = {digitDecade}, Число единиц = {digitOne}, Сумма чисел = {digitSum}, Произведение чисел = {digitMultiplication}");


            Console.WriteLine("6.	Вычислить значение логического выражения при следующих значениях логических величин А, В и С: А = Истина, В = Ложь, С = Ложь:");
            bool magnitudeA = true;
            bool magnitudeB = false;
            bool magnitudeC = false;

            bool comparisonAorB = magnitudeA || magnitudeB;
            bool comparisonAandB = magnitudeA && magnitudeB;
            bool comparisonBorC = magnitudeB || magnitudeC;

            Console.WriteLine($"А или В = {comparisonAorB}, A и В = {comparisonAandB}, B и C = {comparisonBorC}");


            Console.WriteLine("7.	Даны радиус круга и сторона квадрата. У какой фигуры площадь больше?");
            int radiusCircle = 9;
            int sideSquare = 7;

            double areaCircle = Math.PI * (radiusCircle * radiusCircle);
            int areaSquare = sideSquare * sideSquare;

            if (areaCircle > areaSquare)
            {
                Console.WriteLine($"Площадь круга больше = {areaCircle}");
            }
            else
            {
                Console.WriteLine($"Площадь квадрата больше = {areaSquare}");
            }


            Console.WriteLine("8.   Даны объемы и массы двух тел из разных материалов. Материал какого из тел имеет большую плотность?");
            int massFirstSubstance = 20;
            int volumeFirstSubstance = 5;
            int massSecondSubstance = 45;
            int volumeSecondSubstance = 5;

            int densityFirst = massFirstSubstance / volumeFirstSubstance;
            int densitySecond = massSecondSubstance / volumeSecondSubstance;

            if (densityFirst < densitySecond)
            {
                Console.WriteLine($"Плотность второго больше = {densitySecond}");
            }
            else
            {
                Console.WriteLine($"Плотность второго больше = {densityFirst}");
            }


            Console.WriteLine("9.   Известны сопротивления двух несоединенных друг с другом участков электрической цепи и напряжение на каждом из них. По какому участку протекает меньший ток?");
            int voltageFirst = 5;
            int voltageSecond = 9;
            int resistanceFirst = 10;
            int resistanceSecond = 13;

            double amperageFirst = voltageFirst / resistanceFirst;
            double amperageSecond = voltageSecond / resistanceSecond;

            if (amperageFirst < amperageSecond)
            {
                Console.WriteLine($"По первому участку протекает меньший ток = {amperageFirst}");
            }
            else
            {
                Console.WriteLine($"По второму участку протекает меньший ток = {amperageSecond}");
            }


            Console.WriteLine("Напечатать 'столбиком': a.	все целые числа от 20 до 35, b.	квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры; b > 10), c.	третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a < 50), d.	все целые числа от a до b (значения a и b вводятся с клавиатуры; b > a).");
            /*все целые числа от 20 до 35*/
            int from = 20;
            int to = 35;
            for (; from <= to; from++)
            {
                Console.WriteLine(from);
            }

            /*квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры; b > 10)*/
            int userDigitB ;
            int digitTen = 10;
            Console.WriteLine("Введите число от 10 и выше!");
            userDigitB = int.Parse(Console.ReadLine());

            for (; userDigitB > digitTen; userDigitB--)
            {
               int kvadratCelyh = (userDigitB * userDigitB);
                Console.WriteLine($" Числа в квадрате = {kvadratCelyh}");

            }

            
            /*третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a < 50), d.	все целые числа от a до b (значения a и b вводятся с клавиатуры; b > a)*/
            int digitFifty = 50;
            int userDigitA;
            Console.WriteLine("Введите число до 50!");
            userDigitA = int.Parse(Console.ReadLine());

            for (;userDigitA<digitFifty;userDigitA++)
            {
                int thirdStepen = (userDigitA*userDigitA*userDigitA);
                Console.WriteLine($" Числа в третьей степени = {thirdStepen}");
            }


            /*все целые числа от a до b (значения a и b вводятся с клавиатуры; b > a)*/
            int inputUserA;
            int inputUserB;
            Console.WriteLine("Введите число a!");
            inputUserA = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b!");
            inputUserB = int.Parse(Console.ReadLine());

            for (; inputUserB >= inputUserA; inputUserB--)
            {
                Console.WriteLine($"От a до b = {inputUserB}");
            }


            Console.ReadLine();
        }
    }
}
