using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnastikligan_2014
{   // Klass och metoder skapades i iteration 1.
    class Register
    {   
        public static string VerifyRegister(string firstName, string lastName, string memberType)
        {
            if (memberType == "Tävlande" || memberType == "Lagledare" || memberType == "Domare" || memberType == "Huvuddomare" || memberType == "Sekreterare" || memberType == "Arrangör/schemaansvarig" || memberType == "Allmänhet/fans")
            {
                string username = firstName + lastName;
                string password = CreatePassword();

                return "\nDitt användarnamn: " + username + "\nDitt lösenord: " + password + "\n";
            }
            else
            {
                return "\nRegistrering godkändes ej, försök igen!\n";
            }
        }

        // Hittade kod till denna metod på http://stackoverflow.com/questions/1344221/how-can-i-generate-random-alphanumeric-strings-in-c
        public static string CreatePassword()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[7];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            var finalString = new String(stringChars);

            return finalString;
        }
    }
}
