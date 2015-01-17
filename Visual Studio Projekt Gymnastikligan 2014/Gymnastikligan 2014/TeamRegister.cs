using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnastikligan_2014
{   // Klass och metod skapades i iteration 3.
    class TeamRegister
    {
        public static string VerifyTeamRegister(string teamName, string teamLeaderName, string clubName, string cityName)
        {
            if (teamName == "" || teamLeaderName == "" || clubName == "" || cityName == "")
            {
                return "\nRegistreringen kunde ej bekräftas, försök igen!\n";
            }
            else
            {
                return "\nRegistreringen är bekräftad!!\n";
            }
        }
    }
}
