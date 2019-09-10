using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
  public class Inventory
  {
    public double money;
    public int cups;
    public int lemons;
    public int sugar;
    public int ice;

    public Inventory()
    {
      money = 20;
      cups = 0;
      lemons = 0;
      sugar = 0;
      ice = 0;
    }
    public Inventory(Inventory inventory)
    {
      money = inventory.money;
      cups = inventory.cups;
      lemons = inventory.lemons;
      sugar = inventory.sugar;
      ice = inventory.ice;
    }
  }
}