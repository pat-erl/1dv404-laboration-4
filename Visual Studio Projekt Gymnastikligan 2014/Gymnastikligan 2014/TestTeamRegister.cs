using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnastikligan_2014
{   // Klass och metoder skapades i iteration 3.
    class TestTeamRegister
    {
        public static void TestRunner()
        {
            TestVerifyTeamRegister();
        }

        public static void TestVerifyTeamRegister()
        {
            string a = "lagnamn";
            string b = "lagledarnamn";
            string c = "föreningsnamn";
            string d = "ortsnamn";

            string result = TeamRegister.VerifyTeamRegister(a, b, c, d);
            Console.WriteLine("\nENHETSTEST 1 (iteration 3)\nTestfall 1: \n{0}", result);

            a = "";
            b = "lagledarnamn";
            c = "föreningsnamn";
            d = "ortsnamn";

            result = TeamRegister.VerifyTeamRegister(a, b, c, d);
            Console.WriteLine("ENHETSTEST 1 (iteration 3)\nTestfall 2: \n{0}", result);

            a = "lagnamn";
            b = "";
            c = "föreningsnamn";
            d = "ortsnamn";

            result = TeamRegister.VerifyTeamRegister(a, b, c, d);
            Console.WriteLine("ENHETSTEST 1 (iteration 3)\nTestfall 3: \n{0}", result);

            a = "lagnamn";
            b = "lagledarnamn";
            c = "";
            d = "ortsnamn";

            result = TeamRegister.VerifyTeamRegister(a, b, c, d);
            Console.WriteLine("ENHETSTEST 1 (iteration 3)\nTestfall 4: \n{0}", result);

            a = "lagnamn";
            b = "lagledarnamn";
            c = "föreningsnamn";
            d = "";

            result = TeamRegister.VerifyTeamRegister(a, b, c, d);
            Console.WriteLine("ENHETSTEST 1 (iteration 3)\nTestfall 5: \n{0}", result);
            Console.WriteLine("------------------------------\n");
        }
    }
}
