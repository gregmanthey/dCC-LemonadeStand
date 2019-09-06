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
    public Store lemonadeEmporium;

    public void RunGame()
    {
      UI.DisplayTitleScreen();
      UI.DisplayLore();
      UI.DisplayRules();
      //TODO: UI.SetStandName(), UI.GetNumberofPlayers(), UI.SetGameMode() 
      byte numberOfDays = UI.SetGameLengthInDays();
      for (byte i = 0; i < numberOfDays; i++)
      {
        while (UI.DoesUserWantToBuyStoreItems())
        {
          UI.DisplayInventory();
          UI.DisplayStoreInventory();
          string item = UI.WhatStoreItemIsUserBuying();
          ushort amount = UI.HowManyStoreItemsIsUserBuying();
          lemonadeEmporium.SellItems(item, amount, player);
          //TODO: Player buys from store lemonadeEmporium.
          //TODO: keepBuyingStuff = Ask if player would like to buy more
        }
        //TODO: List current recipe
        //TODO: Player sets recipe
        days.Add(new Day());
        days[i].RunDay(player, i);
        //TODO: Display day results and cumulative results
      }
    }
  }
}