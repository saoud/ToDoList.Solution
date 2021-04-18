using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
  public class Program
  {
    public static void Main()
    {
     Console.WriteLine("please enter an item to add to ToDoList");
     string userInput = Console.ReadLine();
     Item newItem = new Item(userInput);
     List<Item> listOutput = Item.GetAll();
     foreach(Item item in listOutput) {
       Console.WriteLine(item.Description);
     }
     Console.WriteLine("Would you like to add another item to the list?");
     string userAnswer = Console.ReadLine();
     Continue(userAnswer);

    }
    public static void Continue(string userAnswer)
    { 
    Console.Write("Would you like to add another item? Type [y] for yes, type [n] to exit: ");
    if (userAnswer.Contains("y") || userAnswer.Contains("Y"))
    {
      Main();
    }
    else
    {
        Console.WriteLine("GoodBye");
    }
    }
  }
}