using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
  public abstract class Weather
  {
    public short temperature;
    public string condition;

    public Weather()
    {
      SetTemperature();
      SetCondition();
    }

    private void SetTemperature()
    {
      temperature = 77;
    }

    private void SetCondition()
    {
      condition = "sunny";
    }
  }
}