using System;

namespace Laba1
{
    public class Program
    {
        public static int Suma(string s)
        {

            char[] c = s.ToCharArray();
            int[] n = new int[s.Length];
            int sum = 0;

            for (int i = 0; i < 4; i++)
            {
                n[i] = (int)Char.GetNumericValue(c[i]);
                sum += n[i];


            }
            Console.WriteLine("Suma: {0}", sum);

            return sum;

        }
        public static int Dobutok(string s)
        {
            char[] c = s.ToCharArray();
            int[] n = new int[s.Length];

            int dob = 1;
            for (int i = 0; i < 4; i++)
            {
                n[i] = (int)Char.GetNumericValue(c[i]);

                dob *= n[i];

            }

            Console.WriteLine("Dobytok: {0}", dob);
            return dob;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a four-digit number: ");
            string s = Console.ReadLine();
            Suma(s);
            Dobutok(s);
        }
    }
}