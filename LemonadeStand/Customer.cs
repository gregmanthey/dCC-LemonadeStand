using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
  public class Customer
  {
    public int thirstLevel;
    public bool isBuying;
    public Customer(Weather weather, Recipe recipe)
    {
      thirstLevel = Randomness.RandomInt(0, 30);
      IsCustomerBuying(weather, recipe);
    }

    public void IsCustomerBuying(Weather weather, Recipe recipe)
    {
      int baseBuyingTemperature = 65;
      int successModifier = 25;
      int failureModifier = -5;
      int purchaseLevel = 50;

      if(weather.actualTemperature > baseBuyingTemperature)
      {
        thirstLevel += successModifier + weather.actualTemperature - baseBuyingTemperature;
      }

      int conditionIndex = weather.conditions.IndexOf(weather.actualCondition);
      if (conditionIndex < 2)
      {
        thirstLevel += successModifier;
      }
      thirstLevel -= failureModifier * conditionIndex;

      if (recipe.lemonsPerPitcher > 5 && recipe.sugarsPerPitcher > 5)
      {
        thirstLevel += successModifier;
      }
      
      if (recipe.icePerCup > 10 && weather.actualTemperature > 88)
      {
        thirstLevel += successModifier;
      }

      if(thirstLevel > purchaseLevel)
      {
        isBuying = true;
      }
      else
      {
        isBuying = false;
      }
    }
  }
}