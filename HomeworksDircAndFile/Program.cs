namespace HomeworksDircAndFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetDirectoryContent("D:\\github darslar\\Lesson006\\.gitignore\\"));
        }

        public static string GetDirectoryContent(string path)
        {
            if (Directory.GetFiles(path).Length == 0 && Directory.GetDirectories(path).Length == 0)
            {
                return "Papka bo'sh";
            }
            else if (Directory.GetFiles(path).Length == 0)
            {
                return "Papkalr bor";
            }
            else if (Directory.GetDirectories(path).Length == 0)
            {
                return "Fayllar bor";
            }
            else
            {
                return "Papkalar va fayllar bor";
            }
        }
    }
}