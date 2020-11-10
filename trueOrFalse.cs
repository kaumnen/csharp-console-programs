using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // Type your code below

      string[] questions = new string[] {"are you human? ", "are you male?", "are you a dog?", "are you an alien?", "are you a fish?"};

      bool[] answers = new bool[] {true, true, false, false, false};

      bool[] responses = new bool[answers.Length];

      if (questions.Length != answers.Length)
      {
        Console.WriteLine("ERROR. QUESTION AND ANSWER LENGTHS ARE NOT EQUAL!");
      }

      int askingIndex = 0;

      foreach (string question in questions)
      {
        string input;
        bool isBool;
        bool inputBool;

        Console.WriteLine(question);
        Console.WriteLine("True or false? ");

        input = Console.ReadLine();

        isBool = Boolean.TryParse(input, out inputBool);

        while (!isBool)
        {
          Console.WriteLine("Please respond with 'true' or 'false'.");
          input = Console.ReadLine();

          isBool = Boolean.TryParse(input, out inputBool);
        }

        responses[askingIndex] = inputBool;
        askingIndex++;

      }

      /*foreach (bool answer in responses)
      {
        Console.WriteLine(answer);
      }*/

      int scoringIndex = 0;
      int score = 0;
      
      foreach (bool answer in answers)
      {
        bool tempBool = responses[scoringIndex];
        Console.WriteLine($"{scoringIndex + 1}. Input: {tempBool} | Answer: {answer}");

        if (tempBool == answer)
        {
          score += 1;
        }

        scoringIndex += 1;
      }

      Console.WriteLine($"You got {score} out of 5 correct!");
    }
  }
}
