using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
  public class Recipe
  {
    public double pricePerCup;
    private ushort icePerCup;
    private ushort lemonsPerPitcher;
    private ushort sugarsPerPitcher;

    public Recipe()
    {
      pricePerCup = .15;
      icePerCup = 8;
      lemonsPerPitcher = 5;
      sugarsPerPitcher = 5;
    }

    public void ChangeRecipe()
    {
      do
      {
        ushort amount = 0;
        string toChange = UI.WhatRecipeItemIsUserChanging();
        if (toChange == "price")
        {
          pricePerCup = UI.WhatPriceDoYouWantToCharge();
        }
        else
        {
          amount = UI.HowManyItems("change the recipe to");
        }

        switch (toChange)
        {
          case "ice":
            icePerCup = amount;
            break;
          case "lemons":
            lemonsPerPitcher = amount;
            break;
          case "sugar":
            sugarsPerPitcher = amount;
            break;
          default:
            break;
        }
      } while (UI.DoesUserWantTo("keep changing the recipe"));
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