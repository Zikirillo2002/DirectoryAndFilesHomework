namespace HomeworksDircAndFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Fayl manzilini kiriting" +
                "(Misol : D:\\papka nomi..\\Fayl nomi.docx) : ");

            string path = Console.ReadLine();

            Console.Write(" Nusxani ko'chirmoqchi bo'lgan" +
                " fayl manzilini kiriting" +
                "(Misol : D:\\papka nomi..\\) : ");

            string newPath = Console.ReadLine();

            CopyToFiels(path, newPath);
        }

        static void CopyToFiels(string path, string newPath)
        {
            var fileinfo = new FileInfo(path);

            if(!File.Exists(newPath))
            {
                File.Create(newPath);
            }

            if(fileinfo.Exists)
            {
                fileinfo.CopyTo( newPath,true);
                
                Console.WriteLine($" {path} fayldan {newPath} " +
                    $"faylga nusxa ko'chirildi.");
            }
            else
            {
                Console.WriteLine($"Bunday fayl {path} mavjud emas");
            }
        }
    }
}