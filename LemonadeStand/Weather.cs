using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
  public class Weather
  {
    public int forecastTemperature;
    public string forecastCondition;
    public int actualTemperature;
    public string actualCondition;

    public Weather()
    {
      SetTemperature();
      SetCondition();
    }

    private void SetTemperature()
    {
      forecastTemperature = Randomness.RandomTemperature();
      actualTemperature = forecastTemperature + Randomness.RandomInt(-5, 5);
    }

    private void SetCondition()
    {
      List<string> conditions = new List<string>() { "immaculately beautiful", "sunny", "partly sunny", "partly cloudy", "cloudy", "rainy", "thunderstormy", "nuclear wintery" };
      int randomIndex = Randomness.RandomInt(0, conditions.Count - 1);
      forecastCondition = conditions[randomIndex];
      int randomModifier = Randomness.RandomInt(-1, 1);
      if(randomIndex + randomModifier < 0 || randomIndex + randomModifier > conditions.Count)
      {
        actualCondition = conditions[randomIndex];
      }
      else
      {
        actualCondition = conditions[randomIndex + randomModifier];
      }
    }
  }
}