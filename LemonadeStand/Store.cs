using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
  public class Store
  {
    private double priceOfCups = .1;
    private double priceOfLemons = .5;
    private double priceOfSugar = .3;
    private double priceOfIce = .05;

    public void DisplayStoreItems()
    {
      UI.DisplayStoreInventory();
    }
    public void SellItems(string item, ushort amount, Player player)
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