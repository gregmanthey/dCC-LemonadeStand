using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
  public abstract class Player
  {
    public string name;
    public Inventory inventory;
    public string standName;
    public Recipe recipe;

    public Player()
    {
      inventory = new Inventory();
      recipe = new Recipe();
      SetName();
      SetStandName();
    }
    public abstract void ChangeRecipe();
    public void AdjustInventoryAfterSale()
    {
      Console.WriteLine("Cup sold, money total before selling: " + inventory.money);
      inventory.money += recipe.pricePerCup;
      Console.WriteLine("Cup sold, money total after selling: " + inventory.money);
      inventory.cups--;
      inventory.ice -= recipe.icePerCup;
      inventory.lemons -= recipe.lemonsPerPitcher;
      inventory.sugar -= recipe.sugarsPerPitcher;
    }
    public bool RanOutOfInventoryItems()
    {
      bool ranOutOfAnItem = false;
      if (inventory.cups == 0)
      {
        Console.WriteLine($"{standName} ran out of cups!");
        ranOutOfAnItem = true;
      }
      if (inventory.ice - recipe.icePerCup < 0)
      {
        Console.WriteLine($"{standName} ran out of ice!");
        ranOutOfAnItem = true;
      }
      if (inventory.lemons - recipe.lemonsPerPitcher < 0)
      {
        Console.WriteLine($"{standName} ran out of ice!");
        ranOutOfAnItem = true;
      }
      if (inventory.sugar - recipe.sugarsPerPitcher < 0)
      {
        Console.WriteLine($"{standName} ran out of ice!");
        ranOutOfAnItem = true;
      }
      return ranOutOfAnItem;

    }
    public abstract void SetName();
    public abstract void SetStandName();
  }
}