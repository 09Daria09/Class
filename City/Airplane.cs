using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City
{
    class Airplane
    {
        private string name;
        private string manufacturer;
        private string yearOfIssue;
        private string type;

        public Airplane()
        {
            name = null;
            manufacturer = null;
            yearOfIssue = null;
            type = null;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Manufacturer
        {
            get => manufacturer;
            set => manufacturer = value;
        }
        public string YearOfIssue
        {
            get => yearOfIssue;
            set => yearOfIssue = value;
        }
        public string Type
        {
            get => type;
            set => type = value;
        }      
        public void Input()
        {
            Console.Write("Введите название самолета: ");
            name = Console.ReadLine();
            Console.Write("Введите название производителя: ");
            manufacturer = Console.ReadLine();
            Console.Write("Введите год выпуска: ");
            yearOfIssue = Console.ReadLine();
            Console.Write("Введите тип самолета: ");
            type = Console.ReadLine();             
        }

        public override string ToString()
        {
            return $"Название самолета: {name}\nНазвание производителя: {manufacturer}\nГод выпуска: {yearOfIssue}\nТип самолета: {type}";
        }

    }
}
