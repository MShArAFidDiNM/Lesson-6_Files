namespace Files_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Tekshir";
            string[] binclear = Directory.GetDirectories(path,"bin*.");
            foreach (string bin in binclear)
            {
                Console.WriteLine(bin + "  DELETED");
                Directory.Delete(bin,true);
            }
            string[] objdeleted = Directory.GetDirectories(path, "obj*.");
            foreach(string obj in objdeleted)
            {
                Console.WriteLine(obj + "  DELETED");
                Directory.Delete(obj, true);
            }
        }
    }
}