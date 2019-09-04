using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
  public class Inventory
  {
    public double money;
    public ushort cups;
    public ushort lemons;
    public ushort sugar;
    public ushort ice;

    public Inventory()
    {
      money = 20;
      cups = 0;
      lemons = 0;
      sugar = 0;
      ice = 0;
    }
  }
}