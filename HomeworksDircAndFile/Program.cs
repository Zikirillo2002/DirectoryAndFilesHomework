namespace HomeworksDircAndFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path1 = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            string[] find = 
            {
              Path.Combine(path1,"bin"),
              Path.Combine(path1,"obj")
            };

            foreach (string filtr1 in find)
            {
                string findDirectory = filtr1;

                if (!Directory.Exists(findDirectory))
                {
                    Console.WriteLine("Bunday papka mavjud emas");
                    break;
                }
                        
                        Console.WriteLine($" ----- {findDirectory} ----------");
                    
            }
        }
    }
}