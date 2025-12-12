internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter number of days in the month: ");
        int n = int.Parse(Console.ReadLine());
        int[] sales = new int[n];
        Console.WriteLine("\nEnter sales for each day:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Day {i + 1}: ");
            sales[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\n--- Original Sales Data ---");
        foreach (int s in sales)
            Console.Write(s + " ");
        Console.WriteLine();
        int[] sortedSales = (int[])sales.Clone();
        Array.Sort(sortedSales);
        Console.WriteLine("\n--- Sorted Sales Data ---");
        foreach (int s in sortedSales)
            Console.Write(s + " ");
        Console.WriteLine();
        int total = 0;
        int highest = sales[0];
        int lowest = sales[0];

        foreach (int s in sales)
        {
            total += s;
            if (s > highest) highest = s;
            if (s < lowest) lowest = s;
        }
        Console.WriteLine("\n--- Summary Statistics ---");
        Console.WriteLine($"Total Sales for the Month: {total}");
        Console.WriteLine($"Highest Single-Day Sales: {highest}");
        Console.WriteLine($"Lowest Single-Day Sales: {lowest}");
        Console.Write("\nEnter a sales value to search: ");
        int searchValue = int.Parse(Console.ReadLine());
        bool found = Array.Exists(sales, x => x == searchValue);
        Console.WriteLine(found ? "Sales value FOUND in the data." : "Sales value NOT found.");
        int[] backupSales = (int[])sales.Clone();
        Console.WriteLine("\nBackup copy created successfully.");
        Console.Write("\nEnter number of days for comparison data: ");
        int m = int.Parse(Console.ReadLine());
        int[] compareData = new int[m];
        Console.WriteLine("Enter comparison sales data:");
        for (int i = 0; i < m; i++)
        {
            compareData[i] = int.Parse(Console.ReadLine());
        }
        bool equal = (n == m);
        if (equal)
        {
            for (int i = 0; i < n; i++)
            {
                if (sales[i] != compareData[i])
                {
                    equal = false;
                    break;
                }
            }
        }
        Console.WriteLine(equal
            ? "\nBoth sales data sets are IDENTICAL."
            : "\nThe sales data sets are NOT identical.");
        Console.WriteLine("\n--- End of Report ---");
    }
}