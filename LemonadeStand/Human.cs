using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
  public class Human : Player
  {
    public override void ChangeRecipe()
    {
      throw new NotImplementedException();
    }

    public override void SetName()
    {
      string context = "the player";
      name = UI.SetName(context);
    }

    public override void SetStandName()
    {
      string context = $"{name}'s lemonade stand";
      standName = UI.SetName(context);
    }
  }
}