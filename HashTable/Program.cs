namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HashTable");
            LinkedHashMap<string, int> hashMap = new LinkedHashMap<string, int>(5);
            string sentence = "to be or not to be";

            string[] words = sentence.ToLower().Split(" ");
            foreach (var word in words)
            {
                int value = hashMap.Get(word);
                if (value == default)
                    value = 1;
                else
                    value += 1;
                hashMap.Add(word, value);
            }

            int wordFrequency = hashMap.Get("to");
            Console.WriteLine("Frequency of the word 'to' is: "+wordFrequency);
        }
    }
}