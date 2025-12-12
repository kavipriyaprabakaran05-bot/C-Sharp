using System;
class Gadget
{
    private string brand;
    private string model;
    private DateTime releaseDate;
    private double price;
    public Gadget(string brand, string model, DateTime releaseDate, double price)
    {
        this.brand = brand;
        this.model = model;
        this.releaseDate = releaseDate;
        this.price = price;
    }
    public int AgeInYears
    {
        get
        {
            int age = DateTime.Now.Year - releaseDate.Year;
            if (releaseDate > DateTime.Now.AddYears(-age)) age--;
            return age;
        }
    }
    public bool IsWarrantyValid
    {
        get
        {
            return DateTime.Now <= releaseDate.AddYears(2);
        }
    }
    public double DiscountedPrice
    {
        get
        {
            if (AgeInYears > 3)
                return price * 0.88;  
            else if (AgeInYears > 1)
                return price * 0.95;   
            else
                return price;
        }
    }
    public string UniqueCode
    {
        get
        {
            string b = brand.Length >= 3 ? brand.Substring(0, 3).ToLower() : brand.ToLower();
            string m = model.Length >= 2 ? model.Substring(model.Length - 2).ToLower() : model.ToLower();
            string y = releaseDate.Year.ToString().Substring(2);  // last 2 digits

            return b + m + y;
        }
    }
    public string Brand => brand;
    public string Model => model;
}
class Smartphone : Gadget
{
    public int RAM { get; set; }
    public int Storage { get; set; }
    public double CameraMP { get; set; }
    public Smartphone(string brand, string model, DateTime releaseDate, double price,
        int ram, int storage, double cameraMP)
        : base(brand, model, releaseDate, price)
    {
        RAM = ram;
        Storage = storage;
        CameraMP = cameraMP;
    }
}
class Laptop : Gadget
{
    public int RAM { get; set; }
    public string Processor { get; set; }
    public double BatteryBackupHours { get; set; }
    public Laptop(string brand, string model, DateTime releaseDate, double price,
        int ram, string processor, double backup)
        : base(brand, model, releaseDate, price)
    {
        RAM = ram;
        Processor = processor;
        BatteryBackupHours = backup;
    }
}
class Program
{
    static void Main()
    {
        Smartphone phone = new Smartphone(
            "Samsung",
            "S21",
            new DateTime(2020, 5, 10),
            699.99,
            8,     
            128,    
            64.0    
        );
        Laptop laptop = new Laptop(
            "Dell",
            "XPS13",
            new DateTime(2019, 3, 15),
            1199.99,
            16,        
            "Intel i7",
            10.5     
        );
        Console.WriteLine("===== Smartphone Details =====");
        Console.WriteLine($"Brand: {phone.Brand}");
        Console.WriteLine($"Model: {phone.Model}");
        Console.WriteLine($"Age in Years: {phone.AgeInYears}");
        Console.WriteLine($"Warranty Valid: {phone.IsWarrantyValid}");
        Console.WriteLine($"Discounted Price: {phone.DiscountedPrice}");
        Console.WriteLine($"Unique Code: {phone.UniqueCode}");
        Console.WriteLine($"RAM: {phone.RAM} GB");
        Console.WriteLine($"Storage: {phone.Storage} GB");
        Console.WriteLine($"Camera: {phone.CameraMP} MP");

        Console.WriteLine("\n===== Laptop Details =====");
        Console.WriteLine($"Brand: {laptop.Brand}");
        Console.WriteLine($"Model: {laptop.Model}");
        Console.WriteLine($"Age in Years: {laptop.AgeInYears}");
        Console.WriteLine($"Warranty Valid: {laptop.IsWarrantyValid}");
        Console.WriteLine($"Discounted Price: {laptop.DiscountedPrice}");
        Console.WriteLine($"Unique Code: {laptop.UniqueCode}");
        Console.WriteLine($"RAM: {laptop.RAM} GB");
        Console.WriteLine($"Processor: {laptop.Processor}");
        Console.WriteLine($"Battery Backup: {laptop.BatteryBackupHours} hours");
    }
}
