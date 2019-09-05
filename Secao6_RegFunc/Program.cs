using System;
using System.Collections.Generic;
using System.Globalization;

namespace Secao6_RegFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtde, i, id, pos;
            string name;
            double salary, percentage;

            Console.Write("How many employees will be registered??? ");
            Console.Write(" Realmente? ");
            qtde = int.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>();

            for (i = 1; i <= qtde; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Employee #{i}:");

                Console.Write("Id....: ");
                id = int.Parse(Console.ReadLine());

                Console.Write("Name..: ");
                name = Console.ReadLine();

                Console.Write("Salary: ");
                salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionarios.Add(new Funcionario(id, name, salary));
            }

            Console.WriteLine();
            Console.Write("Enter the employee Id that will have salary increase: ");
            id = int.Parse(Console.ReadLine());

            pos = funcionarios.FindIndex(a => a.Id == id);
            if (pos < 0)
            {
                Console.WriteLine("This Id does not exist!");
            }
            else
            {
                Console.Write("Enter the percentage: ");
                percentage = double.Parse(Console.ReadLine());

                funcionarios[pos].IncreaseSalary(percentage);
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Funcionario func in funcionarios)
            {
                Console.WriteLine(func);
            }
        }
    }
}
