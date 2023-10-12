namespace _07.ProjectsCreation
{
    internal class ProjectsCreation
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int countProject = int.Parse(Console.ReadLine());

            int project = countProject * 3;

            Console.WriteLine($"The architect {name} will need {project} hours to complete {countProject} project/s.");
        }
    }
}