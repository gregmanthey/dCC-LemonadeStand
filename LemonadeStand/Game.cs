using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
  public class Game
  {
    private string standName;
    public Player Player;
    public Day currentDay;
    public Store Store;

    public void RunGame()
    {
      UI.DisplayTitleScreen();
      UI.DisplayLore();
      UI.DisplayRules();
      //TODO: UI.GetNumberofPlayers(), UI.SetGameMode() 
      byte numberOfDays = UI.SetGameLength();
      for (byte i = 0; i < numberOfDays; i++)
      {
        UI.DisplayInventory();
        //TODO: Player buys from store
        //TODO: Player sets recipe
        //TODO: Day happens
        //TODO: Display day results and cumulative results
      }
    }
  }
}