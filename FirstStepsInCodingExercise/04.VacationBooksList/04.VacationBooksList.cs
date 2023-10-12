namespace _04.VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pages_num = int.Parse(Console.ReadLine());
            int pages = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            var total_time_reading = pages_num / pages;
            var hourse = total_time_reading / days;
            Console.WriteLine(hourse);
        }
    }
}