internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());
        int[] marks = new int[n];
        Console.WriteLine("\nEnter marks for each student:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Student {i + 1}: ");
            marks[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\n--- Original Marks ---");
        foreach (int m in marks)
            Console.Write(m + " ");
        Console.WriteLine();
        int[] sortedMarks = (int[])marks.Clone();
        Array.Sort(sortedMarks);
        Console.WriteLine("\n--- Sorted Marks ---");
        foreach (int m in sortedMarks)
            Console.Write(m + " ");
        Console.WriteLine();
        int total = 0;
        int highest = marks[0];
        int lowest = marks[0];
        foreach (int m in marks)
        {
            total += m;
            if (m > highest) highest = m;
            if (m < lowest) lowest = m;
        }
        Console.WriteLine("\n--- Summary Report ---");
        Console.WriteLine($"Total Marks: {total}");
        Console.WriteLine($"Highest Mark: {highest}");
        Console.WriteLine($"Lowest Mark: {lowest}");
        Console.Write("\nEnter a mark to search: ");
        int searchMark = int.Parse(Console.ReadLine());
        bool found = Array.Exists(marks, x => x == searchMark);
        Console.WriteLine(found ? "Mark FOUND in the list." : "Mark NOT found.");
        int[] backup = (int[])marks.Clone();
        Console.WriteLine("\nBackup copy of marks created successfully.");
        Console.Write("\nEnter number of students for comparison data: ");
        int mCount = int.Parse(Console.ReadLine());

        int[] compareData = new int[mCount];
        Console.WriteLine("Enter comparison marks:");
        for (int i = 0; i < mCount; i++)
        {
            compareData[i] = int.Parse(Console.ReadLine());
        }
        bool identical = (n == mCount);
        if (identical)
        {
            for (int i = 0; i < n; i++)
            {
                if (marks[i] != compareData[i])
                {
                    identical = false;
                    break;
                }
            }
        }
        Console.WriteLine(identical
            ? "\nBoth marks sets are IDENTICAL."
            : "\nThe marks sets are NOT identical.");
        Console.WriteLine("\n--- End of Marks Report ---");
    }
}