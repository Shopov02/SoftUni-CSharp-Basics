namespace _05.SuppliesforSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int package_pens = int.Parse(Console.ReadLine());
            int package_markers = int.Parse(Console.ReadLine());
            int preparation = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            var prasent = discount * 0.01;

            var price_pens = package_pens * 5.80;
            var price_markers = package_markers * 7.20;
            var price_preparation = preparation * 1.20;

            var price_matirials = price_markers + price_pens + price_preparation;

            var price_discount = price_matirials - (price_matirials * prasent);

            Console.WriteLine(price_discount);
        }
    }
}