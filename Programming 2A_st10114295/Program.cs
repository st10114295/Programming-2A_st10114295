// See https://aka.ms/new-console-template for more information
using Programming_2A_st10114295;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Programming2A
{
    //START OF Program CLASS

    //Derived class (inherit from Ingredients)
    class Program
    {
        static void Main(string[] args)
        {
            Ingredient ingredient = new Ingredient();
            while (true)
            {

                Console.WriteLine("Add Your Recipe!!!");
                Console.WriteLine("1. Add An Ingredient");
                Console.WriteLine("2. Display Your Full Recipe!");
                Console.WriteLine("3. Clear Everything");
                Console.WriteLine("4. Request Scaled Recipe");
                Console.WriteLine("5. Reset Quantities Inserted");
                Console.WriteLine("6. Exit");

                int choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        ingredient.AddIngredients();
                        break;
                    case 2:
                        ingredient.DisplayRecipe();
                        break;
                    case 3:
                        ingredient.Clear();
                        break;
                    case 4:
                        ingredient.ScaleRequest(ingredient.GetHalfScale());
                        break;
                    case 5:
                        ingredient.ResetQuantity();
                        break;

                }
            }
        }
    }
}





