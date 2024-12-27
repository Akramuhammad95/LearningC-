using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Africa
{
    class Egypt
    {
        public void Pyramids()
        {
            Console.WriteLine("Pyramids of Egypt");

        }

    }
}
    namespace LearningProject
    {
        internal class Program
        {
            private static void Main(string[] args)
            {
                Africa.Egypt egypt = new Africa.Egypt();
                egypt.Pyramids();
            }
        }
    }
