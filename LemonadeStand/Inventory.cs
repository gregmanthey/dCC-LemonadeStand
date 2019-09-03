using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
  public class Inventory
  {
    private decimal money;
    private ushort cups;
    private ushort lemons;
    private ushort sugar;
    private ushort ice;

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