using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input user's login:");
            string login = Console.ReadLine();
            Console.WriteLine("Input user's name:");
            string name = Console.ReadLine();
            Console.WriteLine("Input user's surname:");
            string surname = Console.ReadLine();
            Console.WriteLine("Input user's age:");
            uint age = uint.Parse(Console.ReadLine());
            Console.WriteLine("Input date of creation:");
            string creationDate = Console.ReadLine();

            User user = new User(login, name, surname, age, creationDate);
            
            Console.WriteLine("\nLogin: {0} \nName: {1} \nSurname: {2} \nAge: {3} \nDate of creation: {4}", user.Login, user.Name, user.Surname, user.Age, user.CreationDate);
            Console.ReadKey();
        }
    }
}