using System.Diagnostics;

namespace ValueReturningMethods
{
    internal class Program
    {
        private static int largestNumber = 0;
        static void Main(string[] args)
        {
            //Value Returning Methods
            //Program 1 - Write a program using four value-returning methods to produce
            //the square, cube, double, and half of a number. Call these methods from
            //your main method
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Square: {Square(number)}");
            Console.WriteLine($"Cube: {Cube(number)}");
            Console.WriteLine($"Double: {Double(number)}");
            Console.WriteLine($"Half: {Half(number)}");

            //Program 2 - Write a program that contains a value-returning method which accepts
            //as input three integers and then outputs the largest of the three numbers
            int[] numberArray = new int[3];
            LargestNumber(numberArray);

            Console.WriteLine($"\nYour largest numbers: {largestNumber}");

            //Program 3 - Write a program that will read in a real number and an integer,
            //then outputs the result of raising the real number to the power of the integer
            Console.WriteLine(CalculateNumber() + "\n\n");

            //Program 4 - Write a method that accepts two integer parameters and returns
            //true if the first parameter evenly divides into the second and fals otherwise
            //Have a message coming out in the body of your program saying number1 is
            //a multiple of number2 or number1 is not a multiple of number2
            int firstNumber, secondNumber;
            Console.Write("Enter your first number: ");
            firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter your second number: ");
            secondNumber = int.Parse(Console.ReadLine());
            if (SolveNumber(firstNumber, secondNumber) == true)
            {
                Console.WriteLine($"{firstNumber} is a multiple of {secondNumber}");
            }
            else
            {
                Console.WriteLine($"{firstNumber} is not a multiple of {secondNumber}");
            }


            //Program 5 - Word Jumble.
            //Write a method called PickWord that hard codes 10 words into an array type
            //of string, then randomly picks and returns one word from this array

            //Write a second method that acceps a string and returns that word jumbled.
            //The easiest way to do this if for a fixed number of times generate two numbers
            //between 1 and the length of the word, then swap two characters.

            //An individual character in a string cannot be easily changed so we will convert
            //the word to an array of characters:
            //char[] characters = word.ToCharArray();

            //To convert the char array back to a string
            //string jumbled = new string(characters);

            //Draw an activity diagram for the first two methods
            //in the main body, use these methods to create a word jumble game
            Console.WriteLine(PickWord());
            Console.WriteLine(JumbledWord());
            Console.ReadLine();
        }

        //Program 5 Methods
        public static string PickWord()
        {
            Random rand = new Random();
            int randomGenerator;
            string[] wordArray = new string[3];
            for(int i = 0; i < wordArray.Length; i++)
            {
                Console.Write("Enter a word: ");
                wordArray[i] = Console.ReadLine();
            }
            randomGenerator = rand.Next(1, wordArray.Length);
            return wordArray[randomGenerator];
            
        }

        public static string JumbledWord()
        {
            Random rand = new Random();
            int randomGenerator;
            char temp;
            Console.Write("Enter a word to be jumbled: ");
            string word = Console.ReadLine();
            char[] characters = word.ToCharArray();
            for (int i = 0; i < characters.Length; i++)
            {
                int randomIndexOne = rand.Next(0, characters.Length);
                int randomIndexTwo = rand.Next(0, characters.Length);

                temp = characters[randomIndexOne];
                characters[randomIndexOne] = characters[randomIndexTwo];
                characters[randomIndexTwo] = temp;
            }
            string jumbled = new string(characters);
            return jumbled;
        }

        //Program 4 Methods
        public static bool SolveNumber(int numberOne, int numberTwo){
            if(numberOne % numberTwo == 0){
                return true;
            }
            else
            {
                return false;
            }

        }

        //Program 3 Methods
        public static double CalculateNumber()
        {
            double result = 1;
            Console.Write("Enter your double number: ");
            double doubleNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter your integer number: ");
            int intNumber = int.Parse(Console.ReadLine());
            for(int i = 0; i < intNumber; i++)
            {
                result *= doubleNumber; 
            }
            
            return Math.Round(result, 2);
        }


        //Program 2 Methods
        public static int []ArrayNumbers(int[] numberArray)
        {
            Console.Write("Enter 3 numbers: ");
            for(int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = int.Parse(Console.ReadLine());
            }
            return numberArray;
        }

        public static int[] LargestNumber(int[] largestArray)
        {
            ArrayNumbers(largestArray);
            Console.WriteLine("Your numbers:");
            for(int i = 0; i < largestArray.Length; i++)
            {
                Console.Write($"{largestArray[i]}\t");
                if (largestArray[i] > largestNumber)
                {
                    largestNumber = largestArray[i];
                }
            }
            return largestArray;
        }

        //Program 1 Methods
        public static int Square(int square){
            return square * square;
        }

        public static int Cube (int cube)
        {
            return cube * cube * cube;
        }

        public static int Double(int doubleNumber)
        {
            return doubleNumber * 2;
        }

        public static double Half(double half)
        {
            return half / 2;
        }
    }
}
