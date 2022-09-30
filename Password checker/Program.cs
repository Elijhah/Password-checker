using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_checker
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string username, password;
            int ctr = 0;
            Console.Write("\n\nCheck username and password :\n");
            Console.Write("N.B. : Default user name and password is :hamza and 1127\n");
            Console.Write("------------------------------------------------------\n");

            do
            {
                Console.Write("Input a username: ");
                username = Console.ReadLine();

                Console.Write("Input a password: ");
                password = Console.ReadLine();

                if (username != "hamza" || password != "1127")
                    ctr++;
                else
                    ctr = 1;

            }
            while ((username != "hamza" || password != "1127") && (ctr != 3));

            if (ctr == 3)
                Console.Write("\nLogin attemp three or more times. You have been disabled!\n\n");
            else
                Console.Write("\nThe password entered successfully!\n\n");
        }
    }
}
