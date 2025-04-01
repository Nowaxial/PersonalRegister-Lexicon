namespace PersonalRegister;

class Program
{

    static List<Staff> personalRegister = new List<Staff>();

    class Staff
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Salary { get; set; }
    }
    static void Main(string[] args)
    {
        bool runningConsole = true;

        while (runningConsole)
        {
            Console.WriteLine("Staff Register");
            Console.WriteLine("1. Add an employee");
            Console.WriteLine("2. Show all employees");
            Console.WriteLine("3. Quit");
            Console.Write("Choose an option: ");

            string chosenValue = Console.ReadLine()!;

            switch (chosenValue)
            {
                case "1":
                    AddEmployee();
                    break;

                case "2":
                    ShowAllEmployees();
                    break;

                case "3":
                    runningConsole = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice, try again!");
                    break;
            }
        }
    }


    static void AddEmployee()
    {
        Staff employee = new Staff();
        
        Console.Write("Add first name: ");
        employee.FirstName = Console.ReadLine()!;
        
        Console.Write("Add last name: ");
        employee.LastName = Console.ReadLine()!;
        
        Console.Write("Add salary: ");
        employee.Salary = int.Parse(Console.ReadLine()!);

        personalRegister.Add(employee);
        Console.WriteLine("Employee added!");
    }

    static void ShowAllEmployees()
    {
        if (personalRegister.Count == 0)
        {
            Console.WriteLine("No registered employees");
            return;
        }

        Console.WriteLine("All employees:");
        foreach (var employee in personalRegister)
        {
            Console.WriteLine("-------------------");
            Console.WriteLine($"Name: {employee.FirstName} {employee.LastName}");
            Console.WriteLine($"Salary: {employee.Salary} kr");
            Console.WriteLine("-------------------");
        }
    }
}
