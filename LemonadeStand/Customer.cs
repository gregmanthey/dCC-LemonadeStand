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
    public Customer(Weather weather)
    {
      IsCustomerBuying(weather);
    }

    public void IsCustomerBuying(Weather weather)
    {
      int baseBuyingTemperature = 65;
      int successModifier = 25;
      int purchaseLevel = 60;

      if(weather.temperature > baseBuyingTemperature)
      {
        thirstLevel += successModifier + weather.temperature - baseBuyingTemperature;
      }

      if(weather.condition == "sunny")
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