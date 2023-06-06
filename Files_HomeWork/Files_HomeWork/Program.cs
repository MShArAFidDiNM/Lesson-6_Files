namespace Files_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFile1 = "C:\\Tekshir\\nusxa.txt";  // Birinchi fayl nomi
            string inputFile2 = "C:\\Tekshir\\copy.txt";  // Ikkinchi fayl nomi
            string outputFile = "C:\\Tekshir\\Result.txt";  // Uchunchi fayl nomi

            MergeFiles(inputFile1, inputFile2, outputFile);

            Console.WriteLine("Fayllar birlashtirildi.");
        }

        static void MergeFiles(string inputFile1, string inputFile2, string outputFile)
        {
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                string content1 = File.ReadAllText(inputFile1);
                string content2 = File.ReadAllText(inputFile2);

                writer.Write(content1);
                writer.Write(content2);
            }
        }
    }
}