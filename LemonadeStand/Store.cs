using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
  public static class Store
  {
    public static double priceOfCups = .1;
    public static double priceOfLemons = .5;
    public static double priceOfSugar = .3;
    public static double priceOfIce = .05;

    public static void DisplayItemsForSale()
    {
      UI.DisplayStoreInventory();
    }
    public static void ProcessOrder(Player player)
    {
      string item = UI.WhatStoreItemIsUserBuying();
      int amount = UI.HowManyItems("buy");
      Store.SellItems(item, amount, player);
    }
    public static void SellItems(string item, int amount, Player player)
    {
      switch (item)
      {
        case "cups":
          if (player.inventory.money < amount * priceOfCups)
          {
            UI.NotEnoughMoneyFor($"{amount} cups");
          }
          else
          {
            player.inventory.money -= amount * priceOfCups;
            player.inventory.cups += amount;
          }
          break;
        case "lemons":
          if (player.inventory.money < amount * priceOfLemons)
          {
            UI.NotEnoughMoneyFor($"{amount} lemons");
          }
          else
          {
            player.inventory.money -= amount * priceOfLemons;
            player.inventory.lemons += amount;
          }
          break;
        case "sugar":
          if (player.inventory.money < amount * priceOfSugar)
          {
            UI.NotEnoughMoneyFor($"{amount} sugars");
          }
          else
          {
            player.inventory.money -= amount * priceOfSugar;
            player.inventory.sugar += amount;
          }
          break;
        case "ice":
          if (player.inventory.money < amount * priceOfSugar)
          {
            UI.NotEnoughMoneyFor($"{amount} sugars");
          }
          else
          {
            player.inventory.money -= amount * priceOfIce;
            player.inventory.ice += amount;
          }
          break;
        default:
          break;
      }
    }
  }
}