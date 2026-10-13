using System.Diagnostics;

namespace ValueReturningMethods
{
    internal class Program
    {
        private static int largestNumber = 0;
        static void Main(string[] args)
        {
            string chosenWord = PickWord(); 
            string jumbledWord = JumbledWord(chosenWord);
            string guess;
            Console.Write($"Guess the correct word from {jumbledWord}: ");
            guess = Console.ReadLine();
            if (guess.Equals(chosenWord))
            {
                Console.WriteLine("You are correct!");
            }
            else
            {
                Console.WriteLine("You are wrong!");
            }
                Console.ReadLine();
        }

        //Program 5 Methods
        public static string PickWord()
        {
            Random rand = new Random();
            int randomGenerator;
            string[] wordArray = ["chrysanthemum", "antagonize", "telescopes", "technology", "skateboard", "government", "buttermilk", "characters", "metamorphosis", "photosynthesis"];
            
            randomGenerator = rand.Next(0, wordArray.Length);
            return wordArray[randomGenerator];
            
        }

        public static string JumbledWord(string word)
        {
            Random rand = new Random();
            int randomGeneratorOne, randomGeneratorTwo;
            char temp;
            char[] characters = word.ToCharArray();
            for (int i = 0; i < characters.Length; i++)
            {
                //assigning
                randomGeneratorOne = rand.Next(characters.Length);
                randomGeneratorTwo = rand.Next(characters.Length);
                temp = characters[randomGeneratorTwo];

                //swapping
                characters[randomGeneratorTwo] = characters[randomGeneratorOne];
                characters[randomGeneratorOne] = temp;
            }
            string jumbled = new string(characters);
            return jumbled;
        }

        
    }
}
