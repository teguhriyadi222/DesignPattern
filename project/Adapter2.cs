using System;
using System.Collections.Generic;

namespace AdapterDesignPattern
{

    // Pola Adapter adalah pola desain yang memungkinkan kita untuk mengubah interface satu kelas menjadi interface lain yang diharapkan oleh klien. 
    // Pola ini digunakan ketika ada kelas yang memiliki interface yang tidak kompatibel dengan klien, 
    // dan kita perlu menyelaraskan interface tersebut agar dapat berinteraksi secara mulus.
    
    public interface ITarget
    {
        void ProcessCompanySalary(string[,] employeesArray);
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

        public Employee(int id, string name, string position, decimal salary)
        {
            ID = id;
            Name = name;
            Position = position;
            Salary = salary;
        }
    }

    public class ThirdPartyBillingSystem
    {
        public void ProcessSalary(List<Employee> listEmployee)
        {
            foreach (Employee employee in listEmployee)
            {
                Console.WriteLine("Gaji sebesar " + employee.Salary + " disetor ke rekening " + employee.Name);
            }
        }
    }

    public class EmployeeAdapter : ITarget
    {
        private ThirdPartyBillingSystem thirdPartyBillingSystem = new ThirdPartyBillingSystem();

        public void ProcessCompanySalary(string[,] employeesArray)
        {
            string Id = null;
            string Name = null;
            string Position = null;
            string Salary = null;
            List<Employee> listEmployee = new List<Employee>();

            for (int i = 0; i < employeesArray.GetLength(0); i++)
            {
                for (int j = 0; j < employeesArray.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Id = employeesArray[i, j];
                    }
                    else if (j == 1)
                    {
                        Name = employeesArray[i, j];
                    }
                    else if (j == 2)
                    {
                        Position = employeesArray[i, j];
                    }
                    else
                    {
                        Salary = employeesArray[i, j];
                    }
                }
                listEmployee.Add(new Employee(Convert.ToInt32(Id), Name, Position, Convert.ToDecimal(Salary)));
            }

            Console.WriteLine("Adapter mengkonversi Array of Employee menjadi List of Employee");
            Console.WriteLine("Kemudian, didelegasikan ke ThirdPartyBillingSystem untuk memproses gaji karyawan\n");

            thirdPartyBillingSystem.ProcessSalary(listEmployee);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[,] employeesArray = new string[5, 4]
            {
                {"1","teguh","Manager","10000"},
                {"2","yuli","SE","20000"},
                {"3","gama","Operator","30000"},
                {"4","bayu","Sales","40000"},
                {"5","aziz","Pembantu","50000"}
            };

            ITarget target = new EmployeeAdapter();
            target.ProcessCompanySalary(employeesArray);
            Console.Read();
        }
    }
}
