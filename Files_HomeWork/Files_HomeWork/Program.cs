namespace Files_HomeWork
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "C:\\Tekshir\\exehygyuh.txt";
            int LineCount = Count(fileName);
            Console.WriteLine(LineCount);
        }
        static int Count(string fileName)
        {
            int count = 0;
            using (StreamReader  reader= new StreamReader(fileName))
            {
                while (reader.ReadLine() != null)
                {
                    count++;
                }
            }
            return count;
        }
    }
}