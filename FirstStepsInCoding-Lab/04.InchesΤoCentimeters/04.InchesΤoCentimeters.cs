namespace _04.InchesΤoCentimeters
{
    internal class InchesΤoCentimeters
    {
        static void Main(string[] args)
        {
            float inch = float.Parse(Console.ReadLine());

            var santimeters = inch * 2.54;
            Console.WriteLine(santimeters);
        }
    }
}