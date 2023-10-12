namespace _08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year_basketball = int.Parse(Console.ReadLine());

            var basketball_shoes = year_basketball - (year_basketball * 0.40);
            var basketball_cloths = basketball_shoes - (basketball_shoes * 0.20);
            var basketball_ball = basketball_cloths / 4;
            var basketball_accessories = basketball_ball / 5;

            var total_price = year_basketball + basketball_shoes + basketball_cloths + basketball_ball + basketball_accessories;

            Console.WriteLine(total_price);

        }
    }
}