namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to HashTable Program");
            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            FrequencyOfWords.GetFrequencyOfWords(paragraph);
        }
    }
}