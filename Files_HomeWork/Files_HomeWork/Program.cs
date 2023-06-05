namespace Files_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Tekshir";
            string[] bin = Directory.GetDirectories(path, "bin*.");
            string[] obj = Directory.GetDirectories(path, "obj*.");
            foreach (string dir in bin)
            {
                Console.WriteLine(dir);
            }
            foreach (string dir in obj)
            {
                Console.WriteLine(dir);
            }
        }

    }
}
