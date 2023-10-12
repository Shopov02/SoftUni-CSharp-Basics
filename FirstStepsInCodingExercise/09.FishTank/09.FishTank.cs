namespace _09.FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            float percentage = float.Parse(Console.ReadLine());

            var dis = percentage * 0.01;

            var volume = length * width * height;
            var volume_liters = volume * 0.001;
            var need_liters = volume_liters * (1 - dis);
            Console.WriteLine(need_liters);
        }
    }
}