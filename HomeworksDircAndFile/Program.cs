namespace HomeworksDircAndFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path1 = "D:\\github darslar\\Lesson006";
            string path2 = "D:\\github darslar\\Lesson006";

            string[] filtr = Directory.GetDirectories(path1, "obj*.");
            string[] filtrs = Directory.GetDirectories(path2, "bin*.");

            if (!Directory.Exists("D:\\github darslar\\Lesson006\\bin\\") 
                || !Directory.Exists("D:\\github darslar\\Lesson006\\obj\\"))
            {
                Console.WriteLine("Bunday papka mavjud emas");
            }
            else
            {
                foreach (string filtr2 in filtr)
                {
                    Console.WriteLine($" ----- {filtr2} ----------");
                }

                foreach (string filtr3 in filtrs)
                {
                    Console.WriteLine($" ----- {filtr3} ----------");
                }
            }
        }
    }
}