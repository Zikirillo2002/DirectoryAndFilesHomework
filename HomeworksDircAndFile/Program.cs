namespace HomeworksDircAndFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\github darslar\\Lesson006\\.gitignore\\";

            var directoryInfo = new DirectoryInfo(path);

            FileInfo[] files = directoryInfo.GetFiles("*.docx");

            if (!directoryInfo.Exists || files.Length == 0)
            {
                Console.WriteLine("Bunday addresli papka mavjud emas.");
                Console.WriteLine("Yoki bunday formatdagi fayl mavjud emas.");

                File.Create(path + "\\dokument1.docx");
                File.Create(path + "\\dokument2.docx");
                File.Create(path + "\\dokument3.docx");

                Console.WriteLine(" \\ .docx \\ formatdagi 3 ta fayl yaratildi. ");
            }

            foreach (FileInfo fileInfo in files)
            {
                Console.WriteLine($" -- {fileInfo.FullName} --");
            }
        }
    }
}