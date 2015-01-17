using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnastikligan_2014
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;

            Console.WriteLine("\nGYMNASTIKLIGAN 2014\n\n");
            Console.WriteLine("Tryck '1' för att skapa konto");
            Console.WriteLine("Tryck '2' för att logga in");
            Console.WriteLine("(Tryck '3' för att logga in som lagledare)");
            Console.WriteLine("-------------------------");
            Console.WriteLine("(Tryck 't' för att köra tester)\n");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {   // Skapades i iteration 1.
                Console.Clear();

                string firstName;
                string lastName;
                string memberType;
                string userDetails;

                Console.WriteLine("\nFyll i ditt förnamn: ");
                firstName = Console.ReadLine();
                Console.WriteLine("\nFyll i ditt efternamn: ");
                lastName = Console.ReadLine();
                Console.WriteLine("\nFyll i vilken typ av medlem du registrerar dig som: \n\n(Tävlande, Lagledare, Domare, Huvuddomare, Sekreterare, \nArrangör/schemaansvarig, Allmänhet/fans\n");
                memberType = Console.ReadLine();

                userDetails = Register.VerifyRegister(firstName, lastName, memberType);

                Console.Clear();
                Console.WriteLine(userDetails);
            }
            else if (userInput == "2")
            {   // Skapades i iteration 2.
                Console.Clear();

                string username;
                string password;
                bool login;

                Console.WriteLine("\nFyll i användarnamn: ");
                username = Console.ReadLine();
                Console.WriteLine("\nFyll i lösenord: ");
                password = Console.ReadLine();

                login = Login.VerifyLogin(username, password);

                if (login == true)
                {
                    Console.Clear();
                    Console.WriteLine("\nVälkommen till din startsida!\n");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\nInloggning misslyckades, försök igen!\n");
                }
            }
            else if (userInput == "3")
            {   // Skapades i iteration 3.
                Console.Clear();
                Console.WriteLine("\nVälkommen till din startsida!\n");
                Console.WriteLine("Tryck 'r' för att registrera lag\n");
                userInput = Console.ReadLine();
                if (userInput == "r")
                {
                    Console.Clear();

                    string teamName;
                    string teamLeaderName;
                    string clubName;
                    string cityName;
                    string registerTeam;

                    Console.WriteLine("\nFyll i lagnamn: ");
                    teamName = Console.ReadLine();
                    Console.WriteLine("\nFyll i lagledarens namn: ");
                    teamLeaderName = Console.ReadLine();
                    Console.WriteLine("\nFyll i föreningens namn: ");
                    clubName = Console.ReadLine();
                    Console.WriteLine("\nFyll i ortens namn: ");
                    cityName = Console.ReadLine();

                    registerTeam = TeamRegister.VerifyTeamRegister(teamName, teamLeaderName, clubName, cityName);

                    Console.Clear();
                    Console.WriteLine(registerTeam);
                }
                else
                {
                    return;
                }
            }
            else if (userInput == "t")
            {
                Console.Clear();
                // Skapades i iteration 1.
                Console.ForegroundColor = ConsoleColor.Cyan;
                TestRegister.TestRunner();

                // Skapades i iteration 2.
                Console.ForegroundColor = ConsoleColor.Magenta;
                TestLogin.TestRunner();

                // Skapades i iteration 3.
                Console.ForegroundColor = ConsoleColor.Yellow;
                TestTeamRegister.TestRunner();
                Console.ResetColor();
            }
            else
            {
                return;
            }
        }
    }
}