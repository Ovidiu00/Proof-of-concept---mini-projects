using System;

namespace CleanCodeExamples.Examples
{
    public class SwitchesAsAbstractFactory
    {
        public static void Main(string[] args)
        {
            var employee = GetEmployeeById(2);

            var countryBoundEmployee = EmployeeFactory(employee.Country);
            var salary = countryBoundEmployee.CalculateSalary();

            Console.WriteLine(salary);
        }
        public abstract class Employee
        {
            public abstract float CalculateSalary();
            public string Country { get; set; }
        }
        public class MexicoEmployee : Employee
        {
            public override float CalculateSalary()
            {
                //logica pentru mexico
                throw new NotImplementedException();
            }
        }
        public class USAEmployee : Employee
        {
            public override float CalculateSalary()
            {
                //logica pentru usa
                throw new NotImplementedException();
            }
        }
        public class RomaniaEmployee : Employee
        {
            public override float CalculateSalary()
            {
                //logica pentru romania
                throw new NotImplementedException();
            }
        }

        private static Employee GetEmployeeById(int id)
        {
            return null;
        }

        private static Employee EmployeeFactory(string country)
        {
            switch (country)
            {
                case "USA": return new USAEmployee();
                case "MEXICO":return new MexicoEmployee();
                case "ROMANIA": return new RomaniaEmployee();

                default:
                    return null;
            }
        }
    }
}
