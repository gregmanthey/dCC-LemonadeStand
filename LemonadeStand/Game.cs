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
    public Day Day;
    public UserInterface UI;
    public Store Store;

    public void RunGame()
    {
      UI.DisplayTitleScreen();
      UI.DisplayLore();
      UI.DisplayRules();

    }
  }
}