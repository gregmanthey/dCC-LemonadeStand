using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
  class Program
  {
    static void Main(string[] args)
    {
      bool keepPlaying = false;
      do
      {
        Game lemonadeStand = new Game();
        keepPlaying = lemonadeStand.RunGame();
      } while (keepPlaying);
      System.Environment.Exit(0);
    }
  }
}
