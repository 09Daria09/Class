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
            //Town town = new Town();
            //town.Input();
            //string str = town.ToString();
            //Console.WriteLine(str);

            //Employee employee = new Employee();
            //employee.Input();
            //string str1 = employee.ToString();
            //Console.WriteLine(str1);
            //Employee employee1 = employee + 10;

            //Employee employee3 = new Employee();
            //employee.Input();
            //string str3 = employee.ToString();
            //Console.WriteLine(str1);

            //Employee employee4 = employee3 + 100;
            //bool a = employee > employee4;
            //Console.WriteLine(a);

            //Airplane airplane = new Airplane();
            //airplane.Input();
            //string str2 = airplane.ToString();
            //Console.WriteLine(str2);

            //Matrix A = new Matrix(5);
            //A.InputRand();
            //A.Print();

            //System.Threading.Thread.Sleep(1000);

            //Matrix B = new Matrix(5);
            //B.InputRand();
            //B.Print();

            //Matrix C = new Matrix(5);
            //C = A + B;
            //C.Print();

            //Matrix D = new Matrix(5);
            //D = A - B;
            //D.Print();

            //Console.WriteLine(A == B);
            //Console.WriteLine(A != B);

            Matrix matrix = new Matrix(2, 3);
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    try
                    {
                        matrix[i, j] = i + j;
                        Console.Write(matrix[i, j] + "    ");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
