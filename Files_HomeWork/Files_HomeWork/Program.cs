namespace Files_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Tekshir";
            string[] file = Directory.GetFiles(path,"*.txt");
            foreach (string file2 in file)
            {
                string fileName = Path.GetFileName(file2);
                Console.WriteLine(fileName );
            }

        }
    }
}