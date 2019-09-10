using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
  public class Day
  {

    public Day()
    {
    }
    public void RunDay(Player player, Weather weather)
    {
      UI.DisplayActualWeatherForToday(weather);
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
        player.ChangeRecipe();
        player.recipe.DisplayRecipe();
      }

      int cupsSold = 0;
      if (player.RanOutOfInventoryItems())
      {
        return;
      }
      player.MakePitcherOfLemonade();
      List<Customer> buyingCustomers = GenerateCustomerList(weather, player.recipe);
      foreach (Customer buyingCustomer in buyingCustomers)
      {
        if (buyingCustomer.isBuying == true)
        {
          if (player.RanOutOfInventoryItems())
          {
            break;
          }
          cupsSold++;
          player.AdjustInventoryAfterSale(cupsSold);
        }
      }
    }
    private List<Customer> GenerateCustomerList(Weather weather, Recipe recipe)
    {
      List<Customer> buyingCustomers = new List<Customer>();
      int numberOfCustomers = Randomness.RandomInt(100, 200);
      for (int i = 0; i < numberOfCustomers; i++)
      {
        Customer customer = new Customer(weather, recipe);
        if (customer.isBuying)
        {
          buyingCustomers.Add(customer);
        }
      }

      return buyingCustomers;
    }
  }
}