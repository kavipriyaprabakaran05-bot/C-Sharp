internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter number of consumers: ");
        int N = int.Parse(Console.ReadLine());
        int domesticCount = 0, commercialCount = 0;
        decimal totalRevenue = 0;
        decimal highestBill = 0;
        string highestBillConsumer = "";
        for (int i = 0; i < N; i++)
        {
            Console.Write("\nEnter ConsumerID: ");
            string consumerId = Console.ReadLine();
            Console.Write("Units Consumed: ");
            int units = int.Parse(Console.ReadLine());
            Console.Write("Connection Type (1=Domestic, 2=Commercial): ");
            int type = int.Parse(Console.ReadLine());
            string typeName = (type == 1) ? "Domestic" : "Commercial";
            if (type == 1) domesticCount++;
            else commercialCount++;
            decimal baseCharge = 0;
            if (type == 1) 
            {
                if (units <= 100) baseCharge = units * 1.50m;
                else if (units <= 300) baseCharge = units * 2.50m;
                else baseCharge = units * 4.00m;
            }
            else // Commercial
            {
                if (units <= 200) baseCharge = units * 5.00m;
                else if (units <= 500) baseCharge = units * 6.50m;
                else baseCharge = units * 8.00m;
            }
            decimal surcharge = baseCharge * 0.03m;
            decimal penalty = (units > 500) ? 200m : 0m;
            decimal total = baseCharge + surcharge + penalty;
            decimal discount = (total > 2000) ? total * 0.05m : 0m;
            decimal finalBill = total - discount;
            if (finalBill > highestBill)
            {
                highestBill = finalBill;
                highestBillConsumer = consumerId;
            }
            totalRevenue += finalBill;
            Console.WriteLine($"\n{consumerId} {typeName} Units:{units}");
            Console.WriteLine($"BaseCharge: {baseCharge:F2}");
            Console.WriteLine($"Surcharge: {surcharge:F2}");
            Console.WriteLine($"Penalty: {penalty:F2}");
            Console.WriteLine($"Discount: {discount:F2}");
            Console.WriteLine($"Final Bill: {finalBill:F2}");
        }
        Console.WriteLine("\n--- Summary ---");
        Console.WriteLine($"Total Consumers: {N}");
        Console.WriteLine($"Total Revenue: ₹{totalRevenue:F2}");
        Console.WriteLine($"Highest Bill: {highestBillConsumer} ₹{highestBill:F2}");
        Console.WriteLine($"Domestic: {domesticCount}  Commercial: {commercialCount}");
    }
}


    