namespace HomeworksDircAndFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\github darslar\\Lesson006\\.gitignore";


            if (Directory.Exists(path))
            {
                File.Create("D:\\github darslar\\Lesson006\\.gitignore\\.gitignore.tex");

                Console.WriteLine("[Lesson006] papkadagi [.gitignore] papkaga" +
                    " [gitignore.tex] fayl muvaffaqiyatli qo'shildi");
            }

            else
            {
                Directory.CreateDirectory(path);

                File.Create("D:\\github darslar\\Lesson006\\.gitignore\\.gitignore.tex");
                Console.WriteLine("[Lesson006] papkaga [.gitignore] papkasi yaratildi" +
                    " va unga [gitignore.tex] fayl muvaffaqiyatli qo'shildi");
            }
        }
    }
}