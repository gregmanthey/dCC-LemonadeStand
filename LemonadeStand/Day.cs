using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
  public class Day
  {
    public Weather weather;

    public Day()
    {
      weather = new Weather();
    }
    public void RunDay(Player player)
    {
      UI.DisplayPlayerInventory(player);
      while (UI.DoesUserWantTo("buy anything from the store"))
      {
        Store.DisplayItemsForSale();
        Store.ProcessOrder(player);
        UI.DisplayPlayerInventory(player);
      }
      player.recipe.DisplayRecipe();
      while (UI.DoesUserWantTo("change the recipe"))
      {
        player.recipe.ChangeRecipe();
        player.recipe.DisplayRecipe();
      }
      List<Customer> customers = new List<Customer>(Randomness.RandomInt(50, 200));
      for (int i = 0; i < customers.Count; i++)
      {
        customers[i] = new Customer(weather, player.recipe);
      }
      foreach (Customer customer in customers)
      {
        if(customer.isBuying == true)
        {
          if (player.RanOutOfInventoryItems())
          {
            break;
          }
          player.AdjustInventoryAfterSale();
        }
      }
    }
  }
}