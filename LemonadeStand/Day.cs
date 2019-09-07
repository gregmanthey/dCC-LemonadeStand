using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
  public class Day
  {

    public Weather Weather;

    public Customer Customer;
    private DateTime date = new DateTime();

    public void RunDay(Player player, byte day)
    {
      UI.DisplayPlayerInventory(player);
      while (UI.DoesUserWantTo("buy anything from the store"))
      {
        UI.DisplayStoreInventory();
        string item = UI.WhatStoreItemIsUserBuying();
        int amount = UI.HowManyItems("buy");
        Store.SellItems(item, amount, player);
        UI.DisplayPlayerInventory(player);
      }
      player.recipe.DisplayRecipe();
      while (UI.DoesUserWantTo("change the recipe"))
      {
        player.recipe.ChangeRecipe();
        player.recipe.DisplayRecipe();
      }
    }
  }
}