namespace _07.AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                float square_side = float.Parse(Console.ReadLine());
                var square_area = square_side * square_side;
                Console.WriteLine($"{square_area:F3}");
            }
            else if (figure == "rectangle")
            {
                float rectangle_lenght = float.Parse(Console.ReadLine());
                float rectangle_width = float.Parse(Console.ReadLine());
                var rectangle_area = rectangle_lenght * rectangle_width;
                Console.WriteLine($"{rectangle_area:F3}");
            }
            else if (figure == "circle")
            {
                float radius = float.Parse(Console.ReadLine());
                var circle_area = Math.PI * radius * radius;
                Console.WriteLine($"{circle_area:F3}");
            }
            else if (figure == "triangle")
            {
                float side = float.Parse(Console.ReadLine());
                float height = float.Parse(Console.ReadLine());
                var triangle_area = side * height / 2;
                Console.WriteLine($"{triangle_area:F3}");
            }
        }
    }
}