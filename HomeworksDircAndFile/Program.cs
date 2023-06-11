namespace HomeworksDircAndFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Fayl manzilini kiriting" +
                "(Misol : D:\\papka nomi\\...\\ fayl nomi.txt) : ");

            string path = Console.ReadLine();

            TextSearchLine(path);
        }

        static void TextSearchLine(string path)
        {

            if(File.Exists(path))
            {
                Console.WriteLine($" Fayl ichidagi textni qatorlari soni :" +
                    $" {File.ReadAllLines(path).Length}."); 
            }

            else
            {
                Console.WriteLine($"Bunday fayl [ {path} ] mavjud emas.");
            }
        }
    }
}