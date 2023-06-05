namespace Files_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Tekshir";
            string[] folder = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);
            if (folder.Length > 0 && files.Length > 0)
            {
                Console.WriteLine("Papka va fayllar mavjud");
            }
            else if (files.Length > 0)
            {
                Console.WriteLine("Faqat fayllar bor");
            }
            else if (folder.Length > 0)
            {
                Console.WriteLine("Faqat papakalar bor");
            }
        }
    }
}