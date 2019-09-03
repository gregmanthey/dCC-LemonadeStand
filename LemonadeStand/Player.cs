using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
  public abstract class Player
  {
    private Inventory inventory;
    private string name;

    public Inventory Inventory
    {
      get => default;
      set
      {
      }
    }
  }
}