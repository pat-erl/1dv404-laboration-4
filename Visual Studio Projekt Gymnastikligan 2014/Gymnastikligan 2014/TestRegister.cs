using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnastikligan_2014
{   // Klass och metoder skapades i iteration 1.
    class TestRegister
    {
        public static void TestRunner()
        {
            TestVerifyRegister();
            TestCreatePassword();
        }

        public static void TestVerifyRegister()
        {
            string a = "Förnamn";
            string b = "Efternamn";
            string c = "Tävlande";

            string result = Register.VerifyRegister(a, b, c);
            Console.WriteLine("\nENHETSTEST 1 (iteration 1)\nTestfall 1: \n{0}", result);

            a = "Förnamn";
            b = "Efternamn";
            c = "Inkorrekt val av medlemstyp";

            result = Register.VerifyRegister(a, b, c);
            Console.WriteLine("ENHETSTEST 1 (iteration 1)\nTestfall 2: \n{0}", result);
        }

        public static void TestCreatePassword()
        {
            string result2 = Register.CreatePassword();
            Console.WriteLine("ENHETSTEST 2 (iteration 1)\nTestfall 1: \n\n{0}", result2);
            Console.WriteLine("\n------------------------------");
        }
    }
}
