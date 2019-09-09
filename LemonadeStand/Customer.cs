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
      IsCustomerBuying(weather, recipe);
    }

    public void IsCustomerBuying(Weather weather, Recipe recipe)
    {
      int baseBuyingTemperature = 65;
      int successModifier = 25;
      int failureModifier = -25;
      int purchaseLevel = 60;

      if(weather.actualTemperature > baseBuyingTemperature)
      {
        thirstLevel += successModifier + weather.actualTemperature - baseBuyingTemperature;
      }

      if(weather.actualCondition == "sunny")
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