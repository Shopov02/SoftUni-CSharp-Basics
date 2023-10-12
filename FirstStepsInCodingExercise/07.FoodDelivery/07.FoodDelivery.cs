namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chiken_menu = int.Parse(Console.ReadLine());
            int fish_menu = int.Parse(Console.ReadLine());
            int vegetarian_menu = int.Parse(Console.ReadLine());

            var price_chiken = chiken_menu * 10.35;
            var price_fish = fish_menu * 12.40;
            var price_vegetarian = vegetarian_menu * 8.15;
            var total_price_menu = price_chiken + price_fish + price_vegetarian;

            var price_desert = total_price_menu * 0.2;

            var total = total_price_menu + price_desert + 2.50;
            Console.WriteLine(total);
        }
    }
}