using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Auto> cars = new List<Auto>(){
                new Auto{
                    Producer = "Ford",
                    Model = "Shelby",
                    Year = 1965,
                    Color = "White"
                },
                new Auto{
                    Producer = "Chevrolet",
                    Model = "Impala",
                    Year = 1957,
                    Color = "Black"
                },
                new Auto{
                    Producer = "Ferrari",
                    Model = "Testarossa",
                    Year = 1984,
                    Color = "Red"
                }
            };

            List<Customer> customers = new List<Customer>(){
                new Customer{
                    AutoModel = "Impala",
                    Name = "Bill",
                    PhoneNumber = 80932223344
                },
                new Customer{
                    AutoModel = "Testarossa",
                    Name = "Brad",
                    PhoneNumber = 80939998877
                },
                new Customer{
                    AutoModel = "Impala",
                    Name = "John",
                    PhoneNumber = 80934445566
                }
            };

            var purchases = from customer in customers
                        join car in cars on customer.AutoModel equals car.Model
                        where customer.AutoModel == "Impala"
                        select new { 
                            Name = customer.Name,
                            Phone = customer.PhoneNumber,
                            Producer = car.Producer,
                            Model = car.Model,
                            Year = car.Year,
                            Color = car.Color
                        };

            foreach (var purchase in purchases)
            {
                Console.WriteLine(purchase);
            }

            Console.ReadKey();
        }
    }
}
