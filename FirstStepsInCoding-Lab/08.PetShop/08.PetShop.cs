namespace _08.PetShop
{
    internal class PetShop
    {
        static void Main(string[] args)
        {
            float countFoodDog = float.Parse(Console.ReadLine());
            float countFoodCat = float.Parse(Console.ReadLine());

            var dog = countFoodDog * 2.50;
            var cat = countFoodCat * 4;
            var all = cat + dog;

            Console.WriteLine($"{all} lv.");
        }
    }
}