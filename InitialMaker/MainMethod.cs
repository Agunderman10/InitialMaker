using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialMaker
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is desired first name?");
            string userFirstName = Console.ReadLine();

            Console.WriteLine("What is desired middle name?");
            string userMiddleName = Console.ReadLine();

            Console.WriteLine("What is desired last name?");
            string userLastName = Console.ReadLine();

            //instantialize person's name class
            Name personName = new Name(userFirstName, userMiddleName, userLastName);
            string fullName, inits;
            fullName = personName.ToString();
            inits = personName.Initials();
            Console.WriteLine("The name is {0}.", fullName);
            Console.WriteLine("The initials are {0}.", inits);

            //keep console open
            while (true)
            {
                Console.ReadLine();
            }
        }
    }
}
