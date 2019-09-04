using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
  public static class UI
  {

    public static void DisplayLore()
    {
      throw new System.NotImplementedException();
    }

    public static void DisplayRules()
    {
      throw new System.NotImplementedException();
    }

    public static void DisplayStatus()
    {
      throw new System.NotImplementedException();
    }

    public static void DisplayTitleScreen()
    {
      Console.WriteLine("Welcome to Lemonade Stand Simulator 2020!");
      Console.WriteLine("Known by many to be the definitive version of the game.");
      Console.WriteLine("...\n...\n...or not. I leave that up to you to decide.");
    }

    public static byte SetGameLengthInDays()
    {
      byte userInput = byte.Parse(ReadLineFor("How many days do you want to simulate (up to 10)?", Validation.NumericCharacters));
      while (userInput < 1 || userInput > 10)
      {
        Console.WriteLine("Please enter a valid input from 1 to 10.");
        return SetGameLengthInDays();
      }
      return userInput;
    }

    public static void DisplayInventory()
    {
      throw new System.NotImplementedException();
    }
    public static string SetName(string context)
    {
      return ReadLineFor($"Please enter a name for {context}:", Validation.AlphabetCharacters);
    }
    public static string ReadLineFor(string context, Func<string, bool> valid)
    {
      string userInput;
      do
      {
        Console.WriteLine(context);
        userInput = Console.ReadLine().Trim();
      } while (userInput == null || userInput == "" || !valid(userInput));
      return userInput;
    }
  }
}