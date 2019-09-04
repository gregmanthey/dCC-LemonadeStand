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
      throw new System.NotImplementedException();
    }

    public static byte SetGameLengthInDays()
    {
      throw new System.NotImplementedException();
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
    }
  }
}