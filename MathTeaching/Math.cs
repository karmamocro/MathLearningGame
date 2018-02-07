using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace MathTeaching
{
    class Math
    {
        int TimeLeft { get; set; }
        int StreakAnswerd { get; set; }
        int Answer { get; set; }
        int HardnessLevel { get; set; }
        int MathType { get; set; }

        Vector NumberMinMAx = new Vector();
        Vector GeneratedNumbers = new Vector();

        public Math(string mType, string mHardLevel)
        {
            var dictLevel = new Dictionary<string, int>();
            dictLevel["Easy"] = 0;
            dictLevel["Easy-Normal"] = 1;
            dictLevel["Normal"] = 2;
            dictLevel["Hard"] = 3;
            dictLevel["Over 9000"] = 4;
            dictLevel["Super Sayen God Goku"] = 5;

            var dictMathType = new Dictionary<string, int>();
            dictMathType["Addition"] = 0;
            dictMathType["Subtraction"] = 1;
            dictMathType["Mulitiplication"] = 2;
            dictMathType["Division"] = 3;


            HardnessLevel = dictLevel[mHardLevel];
            MathType = dictMathType[mType];


            //Getting min max numbers for the game.
            switch (HardnessLevel)
            {
                case 0:
                    NumberMinMAx.X = 0;
                    NumberMinMAx.Y = 10;
                    break;
                case 1:
                    NumberMinMAx.X = 1;
                    NumberMinMAx.Y = 15;
                    break;
                case 2:
                    NumberMinMAx.X = 1;
                    NumberMinMAx.Y = 50;
                    break;
                case 3:
                    NumberMinMAx.X = 50;
                    NumberMinMAx.Y = 500;
                    break;
                case 4:
                    NumberMinMAx.X = 100;
                    NumberMinMAx.Y = 5000;
                    break;
                case 5:
                    NumberMinMAx.X = 120;
                    NumberMinMAx.Y = 10000;
                    break;

                default:
                    NumberMinMAx.X = 1;
                    NumberMinMAx.Y = 100;
                    break;
            }

            GeneratedNumbers = GetNumbers();
        }

        public Vector GetNumbers()
        {
            Vector temp = new Vector();
            temp.X = GenerateRandomNumber(Convert.ToInt32(NumberMinMAx.X), Convert.ToInt32(NumberMinMAx.Y));
            temp.Y = GenerateRandomNumber(Convert.ToInt32(NumberMinMAx.X), Convert.ToInt32(NumberMinMAx.Y));

            return temp;
        }

        private static int GenerateRandomNumber(int min, int max)
        {
            // Sleep 1 millisecond, because Seed needs another value
            Thread.Sleep(1);
            int temp = new System.Random(DateTime.Now.Millisecond).Next(min, max);
            return temp;
        }


        // This is just as random but this is prob sequential...
        //private static Random ran = new Random();
        //static int bla() => ran.Next(20) + 10; //Zahlen von 10  bis 30



    }
}
