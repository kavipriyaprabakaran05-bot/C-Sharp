using System;
class Person
{
    private string firstName;
    private string lastName;
    private string emailAddress;
    private DateTime dateOfBirth;
    public Person(string firstName, string lastName, string emailAddress, DateTime dateOfBirth)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.emailAddress = emailAddress;
        this.dateOfBirth = dateOfBirth;
    }
    public bool IsAdult
    {
        get
        {
            int age = DateTime.Now.Year - dateOfBirth.Year;
            if (dateOfBirth > DateTime.Now.AddYears(-age)) age--;
            return age >= 18;
        }
    }
    public bool IsBirthDay
    {
        get => dateOfBirth.Month == DateTime.Now.Month &&
               dateOfBirth.Day == DateTime.Now.Day;
    }
    public string SunSign
    {
        get
        {
            int m = dateOfBirth.Month;
            int d = dateOfBirth.Day;

            if ((m == 3 && d >= 21) || (m == 4 && d <= 19)) return "Aries";
            if ((m == 4 && d >= 20) || (m == 5 && d <= 20)) return "Taurus";
            if ((m == 5 && d >= 21) || (m == 6 && d <= 20)) return "Gemini";
            if ((m == 6 && d >= 21) || (m == 7 && d <= 22)) return "Cancer";
            if ((m == 7 && d >= 23) || (m == 8 && d <= 22)) return "Leo";
            if ((m == 8 && d >= 23) || (m == 9 && d <= 22)) return "Virgo";
            if ((m == 9 && d >= 23) || (m == 10 && d <= 22)) return "Libra";
            if ((m == 10 && d >= 23) || (m == 11 && d <= 21)) return "Scorpio";
            if ((m == 11 && d >= 22) || (m == 12 && d <= 21)) return "Sagittarius";
            if ((m == 12 && d >= 22) || (m == 1 && d <= 19)) return "Capricorn";
            if ((m == 1 && d >= 20) || (m == 2 && d <= 18)) return "Aquarius";
            return "Pisces";
        }
    }
    public string ScreenName
    {
        get
        {
            string fn = firstName.Substring(0, Math.Min(2, firstName.Length)).ToLower();
            string ln = lastName.Substring(0, Math.Min(2, lastName.Length)).ToLower();
            return fn + ln + dateOfBirth.Month + dateOfBirth.Day + dateOfBirth.Year;
        }
    }
}
class HourlyEmployee : Person
{
    public double HoursWorked { get; set; }
    public double PayPerHour { get; set; }

    public HourlyEmployee(string fname, string lname, string email, DateTime dob,
        double hoursWorked, double payPerHour)
        : base(fname, lname, email, dob)
    {
        HoursWorked = hoursWorked;
        PayPerHour = payPerHour;
    }

    public double TotalPay
    {
        get { return HoursWorked * PayPerHour; }
    }
}
class PermanentEmployee : Person
{
    public double HRA { get; set; }
    public double DA { get; set; }
    public double Tax { get; set; }
    public double TotalPay { get; set; }
    public double NetPay { get; set; }

    public PermanentEmployee(string fname, string lname, string email, DateTime dob,
        double hra, double da, double tax)
        : base(fname, lname, email, dob)
    {
        HRA = hra;
        DA = da;
        Tax = tax;

        TotalPay = hra + da;
        NetPay = TotalPay - tax;
    }
}
class Program
{
    static void Main()
    {
        HourlyEmployee hEmp = new HourlyEmployee(
            "John",
            "Smith",
            "john@example.com",
            new DateTime(1995, 4, 12),
            40,
            20
        );
        Console.WriteLine("----- Hourly Employee -----");
        Console.WriteLine("Is Adult: " + hEmp.IsAdult);
        Console.WriteLine("Sun Sign: " + hEmp.SunSign);
        Console.WriteLine("Total Pay: " + hEmp.TotalPay);
        Console.WriteLine("Screen Name: " + hEmp.ScreenName);
        PermanentEmployee pEmp = new PermanentEmployee(
            "Sara",
            "Lee",
            "sara@example.com",
            new DateTime(1988, 11, 3),
            5000,
            3000,
            800
        );

        Console.WriteLine("\n----- Permanent Employee -----");
        Console.WriteLine("Is Adult: " + pEmp.IsAdult);
        Console.WriteLine("Sun Sign: " + pEmp.SunSign);
        Console.WriteLine("Total Pay: " + pEmp.TotalPay);
        Console.WriteLine("Net Pay: " + pEmp.NetPay);
        Console.WriteLine("Screen Name: " + pEmp.ScreenName);
    }
}
