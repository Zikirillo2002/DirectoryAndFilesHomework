using System.IO;

namespace HomeworksDircAndFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\github darslar\\Lesson006\\.gitignore\\";

            string[] binfind = Directory.GetDirectories(path, "bin*.");
            string[] objfind = Directory.GetDirectories(path, "obj*.");

            if (!Directory.Exists(path) ||
                binfind.Length == 0 ||
                objfind.Length == 0)
            {
                Console.WriteLine("Bunday papka mavjud emas.");
            }

            else
            {
                foreach (string fileInfo in binfind)
                {
                    Console.WriteLine($"-------{fileInfo}------");
                    Directory.Delete(fileInfo);
                }

                foreach (string fileInfo in objfind)
                {
                    Console.WriteLine($"-------{fileInfo}------");
                    Directory.Delete(fileInfo);
                }

                Console.WriteLine("Fayllar muvaffaqiyatli o'chirildi.");
            }
        }
    }
}