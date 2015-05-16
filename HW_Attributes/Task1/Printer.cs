using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Task1
{
    class Printer
    {
        public void Print<T>(T obj)
        {
            Type t = obj.GetType();
            PropertyInfo[] properties = t.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                ForPrintAttribute attr = (ForPrintAttribute)property.GetCustomAttribute(typeof(ForPrintAttribute));

                if (attr != null)
                {
                    ConsoleColor color;

                    try
                    {
                        color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), attr.Color);
                    }
                    catch (ArgumentNullException)
                    {
                        color = ConsoleColor.White;
                    }

                    Console.ForegroundColor = color;
                    Console.WriteLine(property.GetValue(obj));
                }    
            }
        }
    }
}
