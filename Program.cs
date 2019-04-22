using System;
using System.Collections.Generic;
// using System.Linq;


public class Program
{
  public static void Main ()
  {
    Random rand = new Random();

    Console.WriteLine("Would you like to play the Higher/Lower game? ([Y]es/[N]o)");
    //if yes move if no repeat question
    string wantToPlay = Console.ReadLine().ToLower();
    if (wantToPlay == "y")
    {
      int randomGuess = 0;
      Console.WriteLine("Then let the fun commence. Choose a number 1-100 and I will guess that mother fucker!");
      randomGuess += rand.Next(0,101);
      Console.WriteLine("I Guess: " + randomGuess + ". Is your number [H]igher/[L]ower/[C]orrect?");
      string userAnswer = Console.ReadLine().ToLower();

      if (userAnswer =="c")
      {
        Console.WriteLine("Your number is " + randomGuess + " I'm smart as hell.");
      }

      while (userAnswer != "c")
      {
        if (userAnswer == "h" && randomGuess >= 0)
        {
          randomGuess = rand.Next(randomGuess,101);
          Console.WriteLine("I Guess: " + randomGuess + ". Is your number [H]igher/[L]ower/[C]orrect?");
          string userAnswerTwo = Console.ReadLine().ToLower();
        }
        else if (userAnswer == "l" && randomGuess <=100)
        {
          randomGuess = rand.Next(0,randomGuess);
          Console.WriteLine("I Guess: " + randomGuess + ". Is your number [H]igher/[L]ower/[C]orrect?");
          string userAnswerThree = Console.ReadLine().ToLower();
        }
        else
        {
        }
      }






    }
    else
    {
      // Main();
    }
  }
}
