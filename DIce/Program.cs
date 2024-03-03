using System.ComponentModel;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace DIce
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Well Come phonebook");

            Console.WriteLine("1 for create contact");

            Console.WriteLine("2 for Get all contact");

            Console.WriteLine("3 for Get Name by passing number");

            Console.WriteLine("search Contact");

            var inpute=Console.ReadLine();
            var phonebooks = new PhoneBook();
            while(true)
            {
                switch (inpute)
                {
                    case "1":

                        Console.WriteLine("input name");
                        var name = Console.ReadLine();
                        Console.WriteLine("input number");
                        var number = Console.ReadLine();

                        var newcontact = new Contact(name, number);

                        phonebooks.Createacontact(newcontact);
                        break;




                        break;
                    case "2":
                        phonebooks.DisplayallContact();
                        break;

                    case "3":
                        Console.WriteLine("input number");
                        var getname = Console.ReadLine();

                        phonebooks.matchingphrase(getname);
                        break;

                    case "x":
                        return;
                    default:
                        Console.WriteLine("invalid option");
                        break;
                }
                Console.WriteLine("select operation");
                inpute = Console.ReadLine();

            }

            



        }
        
    }
}
