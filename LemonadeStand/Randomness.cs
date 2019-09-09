using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
  public static class Randomness
  {
    private static Random randomNumber = new Random();

    public static int RandomInt(int lowNumber, int highNumber)
    {
      if(lowNumber == highNumber)
      {
        return lowNumber;
      }
      else if(lowNumber > highNumber)
      {
        int actualHighNumber = lowNumber;
        lowNumber = highNumber;
        highNumber = actualHighNumber;
      }
      return randomNumber.Next(lowNumber, highNumber + 1);
    }
    
    public static double RandomDouble(double lowNumber, double highNumber)
    {
      if(lowNumber == highNumber)
      {
        return lowNumber;
      }
      else if(lowNumber > highNumber)
      {
        double actualHighNumber = lowNumber;
        lowNumber = highNumber;
        highNumber = actualHighNumber;
      }
      return Math.Round(randomNumber.NextDouble() * (highNumber - lowNumber) + lowNumber, 2);
    }
    public static int RandomTemperature()
    {
      int minimumTemperature = 50;
      int maximumTemperature = 100;
      return RandomInt(minimumTemperature, maximumTemperature);
    }
    public static double RandomCustomerMaximumPayThreshold()
    {
      double maximumPriceMinimum = .15;
      double maximumPriceMaximum = .50;
      return RandomDouble(maximumPriceMinimum, maximumPriceMaximum);
    }
  }
}
