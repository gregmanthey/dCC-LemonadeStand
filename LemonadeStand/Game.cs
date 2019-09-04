using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
  public class Game
  {
    private string standName;
    public Player player;
    public Day currentDay;
    public Store lemonadeEmporium;

    public void RunGame()
    {
      UI.DisplayTitleScreen();
      UI.DisplayLore();
      UI.DisplayRules();
      //TODO: UI.SetStandName(), UI.GetNumberofPlayers(), UI.SetGameMode() 
      byte numberOfDays = UI.SetGameLength();
      for (byte i = 0; i < numberOfDays; i++)
      {
        UI.DisplayInventory();
        //TODO: Player buys from store lemonadeEmporium.
        //TODO: Player sets recipe
        currentDay.RunDay(player, i);
        //TODO: Display day results and cumulative results
      }
    }
  }
}