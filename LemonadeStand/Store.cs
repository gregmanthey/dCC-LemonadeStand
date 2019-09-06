using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
  public static class Store
  {
    private static double priceOfCups = .1;
    private static double priceOfLemons = .5;
    private static double priceOfSugar = .3;
    private static double priceOfIce = .05;

    public static void DisplayStoreItems()
    {
      UI.DisplayStoreInventory();
    }
    public static void SellItems(string item, ushort amount, Player player)
    {
      switch (item)
      {
        case "cups":
          player.inventory.money -= amount * priceOfCups;
          player.inventory.cups += amount;
          break;
        case "lemons":
          player.inventory.money -= amount * priceOfLemons;
          player.inventory.lemons += amount;
          break;
        case "sugar":
          player.inventory.money -= amount * priceOfSugar;
          player.inventory.sugar += amount;
          break;
        case "ice":
          player.inventory.money -= amount * priceOfIce;
          player.inventory.ice += amount;
          break;
        default:
          break;
      }
    }
  }
}