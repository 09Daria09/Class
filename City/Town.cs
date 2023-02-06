using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City
{
    class Town
    {
        private string name;
        private string nameCantry;
        private int numberOfInhabitants;
        private int phoneTown;
        private string districtOfTown;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string NameCantry
        {
            get
            {
                return nameCantry;
            }
            set
            {
                nameCantry = value;
            }
        }
        public int NumberOfInhabitants
        {
            get
            {
                return numberOfInhabitants;
            }
            set
            {
                numberOfInhabitants = value;
            }
        }
        public int PhoneTown
        {
            get
            {
                return phoneTown;
            }
            set
            {
                phoneTown = value;
            }
        }
        public string DistrictOfTown
        {
            get
            {
                return districtOfTown;
            }
            set
            {
                districtOfTown = value;
            }
        }

        public void Input()
        {
            Console.Write("Введите название города: ");
            name = Console.ReadLine();
            Console.Write("Введите название страны: ");
            nameCantry = Console.ReadLine();
            Console.Write("Введите количество жителей: ");
            numberOfInhabitants = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите телефонный код города: ");
            phoneTown = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите название районов города: ");
            districtOfTown = Console.ReadLine();
        }

        public override string ToString()
        {
            return $"Название города: {name}\nНазвание страны: {nameCantry}\nКоличество жителей: {numberOfInhabitants}\nТелефонный код города: {phoneTown}\nНазвание районов города: {districtOfTown}";
        }
    }
}
