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
        private int salary;
       public Employee()
        {
            fullName = null;
            dateOfBirth = null;
            phone = null;
            email = null;
            jobTitle = null;
            responsibilities = null;
            salary = 0;
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
        public int Salary
        {
            get => salary;
            set => salary = value;
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
            Console.Write("Введите зарплату: ");
            salary = Convert.ToInt32(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"ФИО: {fullName}\nДату рождения: {dateOfBirth}\nКонтактный телефон: {phone}" +
                $"\nРабочий email: {email}\nДолжность: {jobTitle}\nОписание служебных обязанностей: {responsibilities}\nЗарплата:";
        }

        public static Employee operator +(Employee a, int opl)
        {
            a.Salary += opl;
            return a;
        }
        public static Employee operator -(Employee a, int opl)
        {
            a.Salary -= opl;
            return a;
        }
        public static bool operator ==(Employee op1, Employee op2)
        {
            return op1.Salary == op2.Salary;
        }
        public static bool operator !=(Employee op1, Employee op2)
        {
            return op1.Salary != op2.Salary;
        }
        public static bool operator <(Employee op1, Employee op2)
        {
            return op1.Salary < op2.Salary;
        }
        public static bool operator >(Employee op1, Employee op2)
        {
            return op1.Salary > op2.Salary;
        }
    }
}
