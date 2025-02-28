namespace ConsoleApp55
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            Company company = new Company();

           
            company.AddEmployee(new Employee("Иван", 1000));
            company.AddEmployee(new Employee("Мария", 1500));
            company.AddEmployee(new Employee("Петър", 1500));
            company.AddEmployee(new Employee("Георги", 2000));

          
            string foundName = company.FindEmployeeBySalary(1500);
            Console.WriteLine(foundName); 

            
            foundName = company.FindEmployeeBySalary(3000);
            Console.WriteLine(foundName);
        }
    }
}
