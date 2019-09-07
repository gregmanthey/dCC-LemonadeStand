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
      UI.DisplayCurrentRecipe(this);
    }
  }
}