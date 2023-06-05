namespace Files_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = "C:\\Tekshir\\.gitignore";
            if (File.Exists(file))
            {
                Console.WriteLine("has");
            }
            else
            {
            File.Create(file);
            }
        }
    }
}