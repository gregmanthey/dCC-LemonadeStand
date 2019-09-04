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