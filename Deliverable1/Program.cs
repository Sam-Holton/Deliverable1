using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = true;

            Console.WriteLine("You will be asked to enter a password.");
            Console.WriteLine("The password must contain the following criteria:");
            Console.WriteLine();
            Console.WriteLine("1. Contain at least one lower case character.");
            Console.WriteLine("2. Contain at least one upper case character.");
            Console.WriteLine("3. Contain a minimum of seven characters.");
            Console.WriteLine("4. Contain a maximum of twelve characters.");
            Console.WriteLine("5. Contain an exclamation point.");
            Console.WriteLine();
            Console.Write("Please Enter a Password: ");
 
            string password = Console.ReadLine();

            if (password.Length >= 7 && password.Length <= 12)
            {
                foreach (char x in password)
                {
                    if (Char.IsUpper(x))
                    {
                        foreach (char y in password)
                        {
                            if (Char.IsLower(y))
                            {
                                foreach (char z in password)
                                {
                                    if (z == '!')
                                    {
                                        result = true;
                                        break;
                                    }
                                    else result = false;
                                }
                                break;
                            }
                            else result = false;
                        }
                        break;
                    }
                    else result = false;
                }
            }
            else result = false;

            Console.WriteLine();
            if (result == true)
            {
                Console.WriteLine("Password valid and accepted");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
