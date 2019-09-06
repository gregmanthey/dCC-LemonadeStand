using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
  public class Recipe
  {
    public double pricePerCup;
    public int icePerCup;
    public int lemonsPerPitcher;
    public int sugarsPerPitcher;

    public Recipe()
    {
      pricePerCup = .15;
      icePerCup = 8;
      lemonsPerPitcher = 5;
      sugarsPerPitcher = 5;
    }

    public void ChangeRecipe()
    {
    
    }
    public void DisplayRecipe()
    {
      Console.WriteLine("         Current Recipe");
      Console.WriteLine("------------------------------------");
      Console.WriteLine("     Price per cup: " + pricePerCup);
      Console.WriteLine(" Ice cubes per cup: " + icePerCup);
      Console.WriteLine("Lemons per pitcher: " + lemonsPerPitcher);
      Console.WriteLine("Sugars per pitcher: " + sugarsPerPitcher);
      Console.WriteLine("------------------------------------");
    }
  }
}