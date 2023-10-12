namespace _09.YardGreening
{
    internal class YardGreening
    {
        static void Main(string[] args)
        {
            float yard = float.Parse(Console.ReadLine());

            var priceGreen = yard * 7.61;
            var discount = priceGreen * 0.18;
            var finalPrice = priceGreen - discount;

            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}