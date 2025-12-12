internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Temperature Module Running...");
        VibrationModule.Run();
    }
}
class VibrationModule
{
    public static void Run()
    {
        Console.WriteLine("Vibration Module Helper Running...");
    }
}
