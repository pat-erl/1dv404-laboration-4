using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnastikligan_2014
{   // Klass och metoder skapades i iteration 2.
    class TestLogin
    {
        public static void TestRunner()
        {
            TestVerifyLogin();
        }

        public static void TestVerifyLogin()
        {
            string a = "användarnamn";
            string b = "lösenord";

            bool result = Login.VerifyLogin(a, b);
            Console.WriteLine("\nENHETSTEST 1 (iteration 2)\nTestfall 1: \n\n{0}\n", result);

            a = "felanvändarnamn";
            b = "fellösenord";

            result = Login.VerifyLogin(a, b);
            Console.WriteLine("ENHETSTEST 1 (iteration 2)\nTestfall 2: \n\n{0}", result);
            Console.WriteLine("\n------------------------------");
        }
    }
}
