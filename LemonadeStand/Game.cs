using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
  public class Game
  {
    public Player player;
    public List<Day> days = new List<Day>();
    public List<Inventory> inventories = new List<Inventory>();

    public void RunGame()
    {
      UI.DisplayTitleScreen();
      UI.DisplayLore();
      UI.DisplayRules();
      //TODO: UI.SetStandName(), UI.GetNumberofPlayers(), UI.SetGameMode() 
      byte numberOfDays = UI.SetGameLengthInDays();
      for (byte i = 0; i < numberOfDays; i++)
      {
        //TODO: display weather for today and tomorrow (if applicable)
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
        player.ChangeRecipe();

        inventories.Add(player.inventory);

        days.Add(new Day());
        days[i].RunDay(player, i);

        UI.DisplayResults(inventories[i], player.inventory, inventoryDifference(inventories[i], player.inventory));
      }
      //TODO: Display final results
      //Ask if user wants to play again
    }
    public Inventory inventoryDifference(Inventory startingInventory, Inventory endingInventory)
    {
      Inventory difference = new Inventory();
      difference.money = startingInventory.money - endingInventory.money;
      difference.cups = startingInventory.cups - endingInventory.cups;
      difference.lemons = startingInventory.lemons - endingInventory.lemons;
      difference.sugar = startingInventory.sugar - endingInventory.sugar;
      return difference;
    }
  }
}