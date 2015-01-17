using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnastikligan_2014
{   // Klass och metod skapades i iteration 2.
    class Login
    {
        public static bool VerifyLogin(string username, string password)
        {
            if (username == "användarnamn" && password == "lösenord")
            {
                return true;
            }
            else
            {
                return false;
            }   
        }
    }
}
