using System;

namespace Cafe_ClassLibrary
{
    public class Menu
    {

        public int Number { get; set; }
        public string Name { get; set; }
        public string Descriptor { get; set; }
        public string Ingredients { get; set; }
        public decimal Price { get; set; }

        public Menu() { }
        public Menu(int number, string name, string descriptor, string ingredients, decimal price)
        {
             Number = number;
             Name = name;
             Descriptor = descriptor;
             Ingredients = ingredients;
             Price = price;
        }
        
        


       




        //A meal number, so customers can say "I'll have the #5"
        //A meal name
        //A description
        //A list of ingredients,
        //A price


        //Create a Menu Class with properties, constructors, and fields.
        //Create a MenuRepository Class that has methods needed.
        //Create a Test Class for your repository methods. (You don't need to test your constructors or objects, just your methods)
        //Create a Program file that allows the cafe manager to add, delete, and see all items in the menu list.
    }
}
