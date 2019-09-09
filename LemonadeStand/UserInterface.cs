using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
  public static class UI
  {

    public static void DisplayLore()
    {
      //throw new System.NotImplementedException();
    }

    public static void DisplayRules()
    {
      //throw new System.NotImplementedException();
    }

    public static void DisplayResults(Inventory startingInventory, Inventory endingInventory, Inventory difference)
    {
      Console.WriteLine("        Results");
      Console.WriteLine("--------------------------");
      Console.WriteLine(" Starting money: $" + startingInventory.money);
      Console.WriteLine("   Ending money: $" + endingInventory.money);
      Console.WriteLine("       You made: $" + difference.money);
      Console.WriteLine("--------------------------");
      Console.WriteLine("  Starting cups: " + startingInventory.cups);
      Console.WriteLine("    Ending cups: " + endingInventory.cups);
      Console.WriteLine("       You used: " + difference.cups);
      Console.WriteLine("--------------------------");
      Console.WriteLine("Starting lemons: " + startingInventory.lemons);
      Console.WriteLine("  Ending lemons: " + endingInventory.lemons);
      Console.WriteLine("       You used: " + difference.lemons);
      Console.WriteLine("--------------------------");
      Console.WriteLine(" Starting sugar: " + startingInventory.sugar);
      Console.WriteLine("   Ending sugar: " + endingInventory.sugar);
      Console.WriteLine("       You used: " + difference.sugar);
      Console.WriteLine("--------------------------");
      Console.WriteLine("Press Enter to continue");
      Console.ReadLine();
    }
    public static void DisplayErrorNotEnoughInInventory()
    {
      Console.WriteLine("There is not enough in your inventory.");
    }
    public static void NotEnoughMoneyFor(string context)
    {
      Console.WriteLine($"Sorry, but you don't have enough money to purchase {context}.");
      Console.WriteLine("   If you want to take out a loan, check in with your bank.");
      Console.WriteLine("                This is but a simple store.");
      Console.WriteLine("----------------------------------------------------------------");
    }
    public static void DisplayPlayerInventory(Player player)
    {
      Console.WriteLine($"   {player.name}'s Inventory");
      Console.WriteLine("------------------------------------");
      Console.WriteLine("       Money: $" + player.inventory.money);
      Console.WriteLine("        Cups: " + player.inventory.cups);
      Console.WriteLine("      Lemons: " + player.inventory.lemons);
      Console.WriteLine("       Sugar: " + player.inventory.sugar);
      Console.WriteLine("------------------------------------");
    }

    public static void DisplayCurrentRecipe(Recipe recipe)
    {
      Console.WriteLine("            Current Recipe");
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("        Price per cup: " + recipe.pricePerCup);
      Console.WriteLine("    Ice cubes per cup: " + recipe.icePerCup);
      Console.WriteLine("   Lemons per pitcher: " + recipe.lemonsPerPitcher);
      Console.WriteLine("   Sugars per pitcher: " + recipe.sugarsPerPitcher);
      Console.WriteLine("-----------------------------------------");
    }
    public static void DisplayStoreInventory()
    {
      Console.WriteLine("     Welcome to Stan's Lemonade Emporium!");
      Console.WriteLine("------------------------------------------------");
      Console.WriteLine("Currently, we have 4 different items in stock, they are available in infinite quantities.");
      Console.WriteLine($"       Ice: {Store.priceOfIce * 100} cents per cube");
      Console.WriteLine($"     Sugar: {Store.priceOfSugar * 100} cents per cube");
      Console.WriteLine($"    Lemons: {Store.priceOfLemons * 100} cents each");
      Console.WriteLine($"      Cups: {Store.priceOfCups * 100} cents each");
      Console.WriteLine("------------------------------------------------");

    }
    public static bool DoesUserWantTo(string context)
    {
      string userInput = ReadLineFor($"Do you want to {context}?", Validation.YesNo);
      if (userInput == "yes")
      {
        return true;
      }
      return false;
    }
    public static string WhatStoreItemIsUserBuying()
    {
      return ReadLineFor("What item would you like to buy? Please enter cups, sugar, lemons, or ice.", Validation.StoreItems);
    }
    public static int HowManyItems(string context)
    {
      return int.Parse((ReadLineFor($"How many would you like to {context}?", Validation.NumericCharacters)));
    }
    public static string WhatRecipeItemIsUserChanging()
    {
      return ReadLineFor("What recipe item would you like to change? Please enter price, sugar, lemons, or ice.", Validation.RecipeItems);
    }
    public static double WhatPriceDoYouWantToCharge()
    {
      return double.Parse(ReadLineFor($"What would you like to charge?", Validation.NumericCharactersWithDecimal));
    }
    public static void DisplayTitleScreen()
    {
      Console.WriteLine("Welcome to Lemonade Stand Simulator 2020!");
      Console.WriteLine("Known by many to be the definitive version of the game.");
      Console.WriteLine("...\n...\n...or not. I leave that up to you to decide.");
    }

    public static byte SetGameLengthInDays()
    {
      byte userInput = byte.Parse(ReadLineFor("How many days do you want to simulate (up to 10)?", Validation.NumericCharacters));
      while (userInput < 1 || userInput > 10)
      {
        Console.WriteLine("Please enter a valid input from 1 to 10.");
        return SetGameLengthInDays();
      }
      return userInput;
    }


    public static string SetName(string context)
    {
      return ReadLineFor($"Please enter a name for {context}:", Validation.AlphabetCharacters);
    }
    public static string ReadLineFor(string context, Func<string, bool> valid)
    {
      string userInput;
      do
      {
        Console.WriteLine(context);
        userInput = Console.ReadLine().Trim();
      } while (userInput == null || userInput == "" || !valid(userInput));
      return userInput;
    }
  }
}