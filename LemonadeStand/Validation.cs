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
  }
}