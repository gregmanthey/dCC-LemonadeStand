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
    public abstract void SetName();
    public abstract void SetStandName();
  }
}