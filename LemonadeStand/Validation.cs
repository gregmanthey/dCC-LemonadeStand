using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace LemonadeStand
{
  public static class Validation
  {
    public static bool AlphanumericCharacters(string input)
    {
      Regex nonAlphaNumericChars = new Regex("[^a-zA-Z0-9 ]");
      if (!nonAlphaNumericChars.IsMatch(input))
      {
        return true;
      }
      Console.WriteLine("Please enter only numbers, letters and spaces.");
      return false;
    }
    public static bool AlphabetCharacters(string input)
    {
      Regex nonAlphabetChars = new Regex("[^a-zA-Z]");
      if (!nonAlphabetChars.IsMatch(input))
      {
        return true;
      }
      Console.WriteLine("Please enter only letters.");
      return false;
    }
    public static bool NumericCharacters(string input)
    {
      Regex nonNumericChars = new Regex("[^0-9]");
      if (!nonNumericChars.IsMatch(input))
      {
        return true;
      }
      Console.WriteLine("Invalid input. Please enter only a number.");
      return false;
    }
    public static bool NumericCharactersWithDecimal(string input)
    {
      Regex nonNumericOrDecimalChars = new Regex("[^0-9.]");
      if (!nonNumericOrDecimalChars.IsMatch(input) && input.Contains("."))
      {
        return true;
      }
      Console.WriteLine("Invalid input. Please enter a number with a decimal.");
      return false;
    }
    public static bool StoreItems(string input)
    {
      if (input.ToLower() == "cups"   ||
          input.ToLower() == "lemons" ||
          input.ToLower() == "sugar"  ||
          input.ToLower() == "ice")
      {
        return true;
      }
      Console.WriteLine("Please enter cups, lemons, sugar, or ice.");
      return false;
    }
    public static bool RecipeItems(string input)
    {
      if (input.ToLower() == "price" ||
          input.ToLower() == "lemons" ||
          input.ToLower() == "sugar" ||
          input.ToLower() == "ice")
      {
        return true;
      }
      Console.WriteLine("Please enter price, lemons, sugar, or ice.");
      return false;
    }
    public static bool YesNo(string input)
    {
      if (input.ToLower() == "yes" || input.ToLower() == "no")
      {
        return true;
      }
      Console.WriteLine("Please enter yes or no.");
      return false;
    }
  }
}