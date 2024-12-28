using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace castringAndConversion
{
    internal class conversion 
    {

        private static void Main(string[] args)
        {
            //explicit conversion
            double d = 1234.7;
            int i1 = (int)d;
            Console.WriteLine(i1);
            //implicit conversion
            int i2 = 123;
            double d2 = i2;


            Console.WriteLine(d2);



            //pharse convets string to int if the string is a number
            string n = "123";
            int i = int.Parse(n);
            Console.WriteLine(i);
            int iTRyPharser;

            //try parse 

            if (int.TryParse(n, out i))
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine("Conversion failed");
            }

            //convert class is a class in system namespace

            //convert class has a method called toInt32
            //it takes a string and returns an int
            //it is a static method
            int iConvert = Convert.ToInt32(n);
            Console.WriteLine(i);

            //convert class has a method called tosrting
            //it takes an int and returns a string
            //it is a static method

            string s = Convert.ToString(i, 2);
            Console.WriteLine(s);


            //convert string to binary
            string s2 = "Akram";
            char[] c = s2.ToCharArray();
            foreach (char ch in c)
            {
                char[] b = Convert.ToString(ch, 2).ToCharArray();
                foreach (char b1 in b)
                {
                    Console.Write(b1);
                }
            }


        }
    }
}
