using System;
using System.Collections.Generic;

namespace Classes
{
    public static class Class1
    {
        public static string MaxValue(params double[] values)
        {
            List<double> array = new List<double>();
            array.AddRange(values);
            array.Sort();
            array.Reverse();
            return String.Join(", ", array);
        }

        public static int Divider(int a, int b)
        {
            if (a <= 0 || b <= 0) throw new Exception("Числа должны быть больше нуля");


            while (a != 0 && b != 0)
            {
                if (a > b) a = a % b;
                else b = b % a;
            }
            return a + b;
        }

        public static int SumRank(int a)
        {
            if (a < 0) throw new Exception("Число не может быть меньше нуля");

            string result = "";

            while(a != 0)
            {
                int ostatok = a % 10;
                if(ostatok % 2 == 0) result = ostatok + result;

                a /= 10;
            }

            return Convert.ToInt32(result);
        }

        public static double matrix(double[,] array)
        {
            double summ = 0;
            int lengthTd = array.GetLength(1);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < lengthTd; j++)
                {
                    if(array[i,j] % 2 == 0) summ += array[i, j];
                }
                lengthTd--;
            }

            return summ;
        }


    }
}
