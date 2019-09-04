using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
  public class Recipe
  {
    public double pricePerCup;
    private byte icePerCup;
    private byte lemonsPerPitcher;
    private byte sugarPerPitcher;

    public Recipe()
    {
      pricePerCup = .15;
      icePerCup = 8;
      lemonsPerPitcher = 5;
      sugarPerPitcher = 5;
    }
  }
}