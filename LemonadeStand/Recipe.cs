using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
  public class Recipe
  {
    private byte icePerCup;
    private byte lemonsPerPitcher;
    private byte sugarPerPitcher;

    public Recipe()
    {
      icePerCup = 8;
      lemonsPerPitcher = 5;
      sugarPerPitcher = 5;
    }
  }
}