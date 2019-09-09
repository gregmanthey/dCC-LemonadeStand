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

    public void RunGame()
    {
      UI.DisplayTitleScreen();
      UI.DisplayLore();
      UI.DisplayRules();
      player = new Human();
      inventories = new List<Inventory>();
      numberOfDays = UI.SetGameLengthInDays();
      GenerateDaysAndWeathers();
      //TODO: UI.DisplayCompleteWeatherForecast(weathers);
      for (byte i = 0; i < numberOfDays; i++)
      {
        inventories.Add(player.inventory);
        days[i].RunDay(player, weathers[i]);
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