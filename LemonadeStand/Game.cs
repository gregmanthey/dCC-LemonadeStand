using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
  public class Game
  {
    public Player player;
    public byte numberOfDays;
    public List<Day> days;
    public List<Inventory> inventories;
    public List<Weather> weathers;

    public bool RunGame()
    {
      UI.DisplayTitleScreen();
      UI.DisplayLore();
      UI.DisplayRules();
      player = new Human();
      inventories = new List<Inventory>();
      numberOfDays = UI.SetGameLengthInDays();
      GenerateDaysAndWeathers();
      UI.DisplayCompleteWeatherForecast(weathers);
      for (byte i = 0; i < numberOfDays; i++)
      {
        inventories.Add(new Inventory(player.inventory));
        if (i + 1 < numberOfDays)
        {
          UI.DisplayWeatherForTomorrow(weathers[i + 1]);
        }
        days[i].RunDay(player, weathers[i]);
        UI.DisplayResults(inventories[i], player.inventory, InventoryDifference(inventories[i], player.inventory));
      }
      UI.DisplayResults(inventories[0], player.inventory, InventoryDifference(inventories[0], player.inventory));
      return UI.DoesUserWantTo("keep playing");
    }
    public Inventory InventoryDifference(Inventory startingInventory, Inventory endingInventory)
    {
      Inventory difference = new Inventory();
      difference.money = endingInventory.money - startingInventory.money;
      difference.cups = endingInventory.cups - startingInventory.cups;
      difference.lemons = endingInventory.lemons - startingInventory.lemons;
      difference.sugar = endingInventory.sugar - startingInventory.sugar;
      return difference;
    }
    public void GenerateDaysAndWeathers()
    {
      days = new List<Day>();
      weathers = new List<Weather>();
      for (int i = 0; i < numberOfDays; i++)
      {
        days.Add(new Day());
        weathers.Add(new Weather());
      }
    }
  }
}