using System;
using System.Collections;

class Employee
{
    public string EmployeeName { get; set; }
    public int EmployeeID { get; set; }
    public double Salary { get; set; }

    public Employee(string name, int id, double salary)
    {
        EmployeeName = name;
        EmployeeID = id;
        Salary = salary;
    }
}

class EmployeeDAL
{
    ArrayList employees = new ArrayList();

    public bool AddEmployee(Employee e)
    {
        employees.Add(e);
        return true;
    }

    public bool DeleteEmployee(int id)
    {
        foreach (Employee emp in employees)
        {
            if (emp.EmployeeID == id)
            {
                employees.Remove(emp);
                return true;
            }
        }
        return false;
    }

    public string SearchEmployee(int id)
    {
        foreach (Employee emp in employees)
        {
            if (emp.EmployeeID == id)
                return emp.EmployeeName;
        }
        return null;
    }

    public Employee[] GetAllEmployeesListAll()
    {
        return (Employee[])employees.ToArray(typeof(Employee));
    }
}

class Program
{
    static void Main()
    {
        EmployeeDAL dal = new EmployeeDAL();

        dal.AddEmployee(new Employee("Aliya", 101, 90000));
        dal.AddEmployee(new Employee("thaariq", 102, 80000));
        dal.AddEmployee(new Employee("manasa", 103, 75000));

        Console.WriteLine("Search ID 102: " + dal.SearchEmployee(102));

        bool isDeleted = dal.DeleteEmployee(101);
        Console.WriteLine("Deleted ID 101? " + isDeleted);

        Console.WriteLine("\nAll Employees:");
        foreach (var emp in dal.GetAllEmployeesListAll())
        {
            Console.WriteLine(emp.EmployeeID + " - " + emp.EmployeeName + " - " + emp.Salary);
        }
    }
}