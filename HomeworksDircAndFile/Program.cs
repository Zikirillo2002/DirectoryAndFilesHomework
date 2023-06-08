namespace HomeworksDircAndFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory();

            DirectoryInfo parentDirectory = Directory.GetParent(path);

            parentDirectory = parentDirectory.Parent.Parent.Parent;

            File.Create($"{parentDirectory}\\.gitignore");
        }
    }
}