namespace _06.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            var nylon_price = (nylon + 2) * 1.50;
            var paint_price = (paint + (paint * 0.10)) * 14.50;
            var thinner_price = thinner * 5.00;
            var material_price = nylon_price + paint_price + thinner_price + 0.40;
            var master_price = (material_price * 0.30) * hours;
            var total_price = material_price + master_price;
            Console.WriteLine(total_price);
        }
    }
}