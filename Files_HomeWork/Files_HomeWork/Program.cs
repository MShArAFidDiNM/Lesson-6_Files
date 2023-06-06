namespace Files_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string SourceDirname = "C:\\Tekshir\\Text Document.txt";
            string DestDirname = "C:\\Tekshir\\kel\\Nusxa.txt";
            File.Copy(SourceDirname, DestDirname, true);
            Console.WriteLine("Fayl nusxalandi");

        }
    }
}