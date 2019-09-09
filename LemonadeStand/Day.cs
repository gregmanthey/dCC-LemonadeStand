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

      List<Customer> buyingCustomers = GenerateCustomerList(weather, player.recipe);

      foreach (Customer buyingCustomer in buyingCustomers)
      {
        if (buyingCustomer.isBuying == true)
        {
          if (player.RanOutOfInventoryItems())
          {
            break;
          }
          player.AdjustInventoryAfterSale();
        }
      }
    }
    private List<Customer> GenerateCustomerList(Weather weather, Recipe recipe)
    {
      List<Customer> buyingCustomers = new List<Customer>();

      for (byte i = 0; i < Randomness.RandomInt(50, 200); i++)
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