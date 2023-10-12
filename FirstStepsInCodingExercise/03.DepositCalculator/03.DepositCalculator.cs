namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float deposit = float.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            float year = float.Parse(Console.ReadLine());

            double present = year * 0.01;

            double interest = deposit * present;
            double interestMonth = interest / 12;
            double total = deposit + month * interestMonth;
            Console.WriteLine(total);

        }
    }
}