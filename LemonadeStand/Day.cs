using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
  public class Day
  {

    public Weather weather;

    public List<Customer> customers = new List<Customer>();
    private DateTime date = new DateTime();

    public Day()
    {

    }
    public void RunDay(Player player, byte day)
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
    }
  }
}