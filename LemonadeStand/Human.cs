using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
  public class Human : Player
  {
    public override void ChangeRecipe()
    {
      do
      {
        int amount = 0;
        string toChange = UI.WhatRecipeItemIsUserChanging();
        
        if (toChange == "price")
        {
          recipe.pricePerCup = UI.WhatPriceDoYouWantToCharge();
        }
        else if (toChange != "cancel")
        {
          amount = UI.HowManyItems("change the recipe to");
        }

        switch (toChange)
        {
          case "ice":
            if (amount < inventory.ice)
            {
              recipe.icePerCup = amount;
            }
            else
            {
              UI.DisplayErrorNotEnoughInInventory();
            }
            break;
          case "lemons":
            if (amount < inventory.lemons)
            {
              recipe.lemonsPerPitcher = amount;
            }
            else
            {
              UI.DisplayErrorNotEnoughInInventory();
            }
            break;
          case "sugar":
            if (amount < inventory.sugar)
            {
              recipe.sugarsPerPitcher = amount;
            }
            else
            {
              UI.DisplayErrorNotEnoughInInventory();
            }
            break;
          default:
            break;
        }
      } while (UI.DoesUserWantTo("keep changing the recipe"));
    }

    public override void SetName()
    {
      string context = "the player";
      name = UI.SetName(context);
    }

    public override void SetStandName()
    {
      standName = $"{name}'s Lemonade Stand";
    }
  }
}