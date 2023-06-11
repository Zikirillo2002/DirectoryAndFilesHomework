namespace HomeworksDircAndFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            string[] searchFile = Directory.GetFiles(path,"*.exe",SearchOption.AllDirectories);

            if (!Directory.Exists(path) || searchFile.Length == 0)
            {
                Console.WriteLine("Yoki bunday formatdagi fayl mavjud emas.");

                File.Create(path + "\\new project.exe");

                Console.WriteLine(" \\ new project.exe \\ fayl yaratildi. ");
            }

            int i = 1;

            foreach (var file in searchFile)
            {
                Console.WriteLine($"{i++}). --- {file} ---");
            }
        }
    }
}