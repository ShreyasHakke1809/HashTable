namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to HashTable Program");
            string paragraph = "To be or not to be or not";
            FrequencyOfWords.GetFrequencyOfWords(paragraph);
        }
    }
}