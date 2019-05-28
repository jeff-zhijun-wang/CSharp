using System;
using System.Collections.Generic;

namespace _03_BuilderPattern
{

    class Program
    {
        static void Main(string[] args)
        {
            MealBuilder mealBuilder = new MealBuilder();

            Meal vegMeal = mealBuilder.prepareVegMeal();
            vegMeal.showItems();
            Meal nonVegMeal = mealBuilder.prepareNonVegMeal();
            nonVegMeal.showItems();
            Console.WriteLine("Hello World!");
        }
    }
}
