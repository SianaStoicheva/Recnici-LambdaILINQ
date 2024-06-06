namespace SortShortWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[]
        {'.',',',':',';','(',')','[',']','\\','\"','\'','/','!','?',' '};

            string sentence = Console.ReadLine().ToLower();

            string[] words = sentence.Split(separators);

            var result = words
                .Where(w => w.Length > 0 && w.Length < 5) 
                .OrderBy(w => w) 
                .Distinct(); 
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
