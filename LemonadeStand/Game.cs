using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
  public class Game
  {
    public Player player;
    public Day currentDay;
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
        bool keepBuyingStuff = true;
        while (keepBuyingStuff)
        {
          UI.DisplayInventory();
          //TODO: UI.DisplayStoreItems();
          //TODO: UI.AskPlayerToBuyItems();
          //TODO: Player buys from store lemonadeEmporium.
          //TODO: keepBuyingStuff = Ask if player would like to buy more
        }
        //TODO: List current recipe
        //TODO: Player sets recipe
        currentDay.RunDay(player, i);
        //TODO: Display day results and cumulative results
      }
    }
  }
}