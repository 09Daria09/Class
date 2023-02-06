using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City
{
    class Program
    {
        static void Main(string[] args)
        {
            Town town = new Town();
            town.Input();
            string str = town.ToString();
            Console.WriteLine(str);

            Employee employee = new Employee();
            employee.Input();
            string str1 = employee.ToString();
            Console.WriteLine(str1);

            Airplane airplane = new Airplane();
            airplane.Input();
            string str2 = airplane.ToString();
            Console.WriteLine(str2);

        }
    }
}
