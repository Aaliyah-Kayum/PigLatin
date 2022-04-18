class Program
{
    public static void Main()
    {
        static void PigLatinTranslator()
        {
            Console.WriteLine("Welcome to the Pig Latin Translator!");
        }

        do

        {
            Console.WriteLine("Please enter something to be translated into Pig Latin ");

            string input = Console.ReadLine();

            int v = -1;
            foreach (char c in input)
            {
                v = v + 1;
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    break;
                }

            }

            string PigLatin = "";
            string before = "";
            string after = "";

            switch (v)

            {
                case 0:
                    PigLatin = input + "way";
                    string inputs = Console.ReadLine();
                    break;
                case 1:
                    before = input.Substring(0, 1);
                    after = input.Substring(1);
                    PigLatin = after + before + "ay";
                    break;
                case 2:
                    before = input.Substring(0, 2);
                    after = input.Substring(2);
                    PigLatin = after + before + "ay";
                    break;
                case 3:
                    before = input.Substring(0, 3);
                    after = input.Substring(3);
                    PigLatin = after + before + "ay";
                    break;
                default:
                    PigLatin = "I'm sorry, I didn't understand. Please try again.";
                    break;

                    string[] sentence = "".Split();

                    string translation = "";
                    foreach (string words in sentence)
                    {
                        translation = translation + input;
                    }
                    Console.WriteLine(translation.Substring(0, translation.Length - 1));
            }


            {
                //Result
                Console.WriteLine("Translation:" + PigLatin);

                //Loop
                Console.WriteLine("Do you want to play again? y/n");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    continue;
                }
                else if (answer == "n") ;
                {
                    break;
                }
            }
        }
        while (true);
    }
}