using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City
{
    class Employee
    {
        private string fullName;
        private string dateOfBirth;
        private string phone;
        private string email;
        private string jobTitle;
        private string responsibilities;

       public Employee()
        {
            fullName = null;
            dateOfBirth = null;
            phone = null;
            email = null;
            jobTitle = null;
            responsibilities = null;
        }
       
        public string FullName
        {
            get => fullName;
            set => fullName = value;
        }
        public string DateOfBirth
        {
            get => dateOfBirth;
            set => dateOfBirth = value;
        }
        public string Phone
        {
            get => phone;
            set => phone = value;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }
        public string JobTitle
        {
            get => jobTitle;
            set => jobTitle = value;
        }
        public string Responsibilities
        {
            get => responsibilities;
            set => responsibilities = value;
        }
        public void Input()
        {
            Console.Write("ФИО: ");
            fullName = Console.ReadLine();
            Console.Write("Введите дату рождения: ");
            dateOfBirth = Console.ReadLine();
            Console.Write("Введите контактный телефон: ");
            phone = Console.ReadLine();
            Console.Write("Введите рабочий email: ");
            email = Console.ReadLine(); ;
            Console.Write("Введите должность: ");
            jobTitle = Console.ReadLine();
            Console.Write("Введите описание служебных обязанностей: ");
            responsibilities = Console.ReadLine();
        }

        public override string ToString()
        {
            return $"ФИО: {fullName}\nДату рождения: {dateOfBirth}\nКонтактный телефон: {phone}" +
                $"\nРабочий email: {email}\nДолжность: {jobTitle}\nОписание служебных обязанностей: {responsibilities}";
        }
    }
}
