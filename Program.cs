namespace SalaryAppUJ
{
    internal class Program
    {
        //program execution begins here
        static void Main(string[] args)
        {
            double revenue;
            double cost;
            double profit;

            Console.WriteLine("Enter revenue");
            revenue = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter cost");
            cost = Convert.ToDouble(Console.ReadLine());

            profit = revenue - cost;

            Console.WriteLine("Profit is \tR" + profit.ToString("F2"));

        }//end main
    }//end class
}//end namespace