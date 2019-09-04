using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
  public class Human : Player
  {
    public override void SetName()
    {
      name = UI.SetName("the player");
    }

    public override void SetStandName()
    {
      standName = UI.SetName($"{name}'s lemonade stand");
    }
  }
}