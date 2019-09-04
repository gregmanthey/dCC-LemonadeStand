using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
  public abstract class Player
  {
    private string name;
    public Inventory inventory;
    private string standName;
    public Recipe recipe;
  }
}