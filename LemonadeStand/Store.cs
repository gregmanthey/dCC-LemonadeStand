using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
  public class Store
  {
    private double[] pricesOfCups;
    private double[] pricesOfLemons;
    private double[] pricesOfSugar;
    private double[] pricesOfIce;

    public void SellItems(string item, int amount, Player player)
    {
      switch (item)
      {
        case "cups":
          //player.inventory.cups += amount;
          break;
        case "lemons":
          break;
        case "sugar":
          break;
        case "ice":
          break;
        default:
          break;
      }
    }
  }
}