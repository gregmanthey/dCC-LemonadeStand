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
      //System.Threading.Thread.Sleep(50);
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
      //System.Threading.Thread.Sleep(50);
      return Math.Round(randomNumber.NextDouble() * (highNumber - lowNumber) + lowNumber, 2);
    }
  }
}
