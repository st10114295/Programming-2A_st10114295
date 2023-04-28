Name: Nicole Willemse
Student Number: ST10114295

Programming 2A

Aim:
To create a standalone command line application, that allows the user to enter details about ingredients and the steps it takes create recipes, using C# and Visual Studio.

The user shall be able to enter the details for a single recipe:
a. The number of ingredients.
b. For each ingredient: the name, quantity, and unit of measurement.
c. The number of steps.
d. For each step: a description of what the user should do.
e. The software displays the full recipe.
f. The user is able to request that the recipe is scaled by a factor of 0.5 (half), 2 (double) or 3 (triple).
g. The user can request that the quantities be reset to the original values.
h. The user is able to clear all the data to enter a new recipe.
6. The software does not persist the user data between runs. The data shall only be stored in memory while the software is running.

1. To start compiling the application, I installed Visual Studio 2022. 
2. On the start I chose the option that said Create a new project.
3. Next You need to search for the word console in the search box, choose C# or Visual Basic from the language list, and then choose All platforms from the platform list. 
4. Then, you need to go ahead and click the correct template, which is the Console App template. Proceed to click on Next
5. Where you need to insert a project name, you need to come up with a name; for example, "Programming2A_st10114295'.
6. In the Additional information dialog, select .NET 6 (Long-term support), and select Create.

The code that I used to compile the project:
1) For the program class:

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
                        ingredient.ScaleRequest(                        ingredient.GetHalfScale());
                        break;
                    case 5:
                        ingredient.ResetQuantity();
                        break;
                        
                }
            }
        }
    }
}


2) Next I added an "Ingredient" Class:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



//START OF Ingredient CLASS
namespace Programming_2A_st10114295
{
    class Ingredient
    {
        // class variables for details of the ingredients and steps
        int[] numOfIngre;
        int[] scaleFactor;
        int[] quantity;
        string[] descriptions;
        string[] name;
        string[] unitOfMeasure;
        int[] steps;
        string[] display;
        int[] opt;
        int i, j = 0;
        int[] halfScale;
        int[] doubleScale;
        int[] tripleScale;
        float[] result;

        public Ingredient()
        {
            numOfIngre = new int[0];
            scaleFactor = new int[0];
            quantity = new int[0];
            descriptions = new string[0];
            name = new string[0];
            unitOfMeasure = new string[0];
            steps = new int[0];
            display = new string[1];
            opt = new int[0];
            halfScale = new int[0];
            doubleScale = new int[0];
            tripleScale = new int[0];
            result = new float[0];
        }

        

        //START OF AddIngredients METHOD
        public void AddIngredients()
        {

            Console.Write("Please enter the number of ingredients:");
            int numOfIngre = int.Parse(Console.ReadLine());

            name = new string[numOfIngre];
            quantity = new int[numOfIngre];
            unitOfMeasure = new string[numOfIngre];

            for (int i = 0; i < numOfIngre; i++)
            {
                Console.Write($"Please enter the name of the ingredient#{i + 1}:");
                Console.Write("Name Of The Ingredient: ");
                name[i] = Console.ReadLine();
                Console.Write("Quantity of that ingredient: ");
                quantity[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Indicate the unit of measurement: ");
                unitOfMeasure[i] = Console.ReadLine();
                break;
                Console.Write("--------------------------------------------------------------------------------");
                break;
            }


            Console.WriteLine("Please enter the number of steps needed to complete the recipe:");
            int steps = int.Parse(Console.ReadLine());

            descriptions = new string[steps];

            for (int i = 0; i < steps; i++)
            {
                Console.Write($"Please explain how to do the steps #{i + 1}: ");
                descriptions[i] = Console.ReadLine();
                break;
                Console.Write("--------------------------------------------------------------------------------");
                break;
            }

        }




        //START OF DisplayRecipe METHOD
        public void DisplayRecipe()
        {

            Console.Write("--------------------------------------------------------------------------------");
            Console.WriteLine("Enjoy This Step, By Step, Recipe");



            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine($"- {quantity[i]} {unitOfMeasure[i]} of {name[i]} ");
            }

            Console.WriteLine("Descriptions:");

            for (int i = 0; i < descriptions.Length; i++)
            {
                Console.WriteLine($"- {descriptions[i]}");
            }


        }

        public int[] GetHalfScale()
        {
            return halfScale;
        }

        //START OF ScaleRequest METHOD
        public void ScaleRequest(int[] halfScale)
        {

            Console.Write("\nPlease enter a scale factor of 0.5 (half), 2 (double) or 3 (triple:\t).");
            Console.WriteLine("1) Scale quantities by 0.5 (half)");
            Console.WriteLine("2) Scale quantities by 2 (double)");
            Console.WriteLine("3) Scale quantities by 3 (triple)");
            int opt = Convert.ToInt32(Console.ReadLine());

            if (opt == 1)
            {
                
                Console.WriteLine("\n{0} x {1} = {2}", quantity, halfScale, result);
            }
            else
                if (opt == 2)
            {
                
                Console.WriteLine("\n{0} x {1} = {2}", quantity, doubleScale, result);
            }
            else
                if (opt == 3)
            {
                
                Console.WriteLine("\n{0} x {1} = {2}", quantity, tripleScale, result);
            }
            else
            {
                Console.WriteLine("Invalid option. Try again");
            }
            Console.ReadLine();
        }

        //START OF ResetQuantity METHOD
        public void ResetQuantity()
        {
            
            quantity = new int[0];
            Console.WriteLine("Your quantity has been reset");

            for (int i = 0; i < numOfIngre.Length; i++)
            {
                quantity[i] /= 2;
            }
            Console.WriteLine("Your quantity has been reset");


        }

        //START OF Clear METHOD
        public void Clear()
        {

            numOfIngre = new int[0];
            scaleFactor = new int[0];
            quantity = new int[0];
            descriptions = new string[0];
            name = new string[0];
            unitOfMeasure = new string[0];
            steps = new int[0];
            display = new string[1];
            opt = new int[0];
            halfScale = new int[0];
            doubleScale = new int[0];
            tripleScale = new int[0];
            result = new float[0];

            Console.WriteLine("Would you like to clear your data and start a new recipe? (Y/N)");
            string answer = Console.ReadLine();

            if (answer == "Y")
            {

                
                Console.WriteLine("Your data has been cleared");
            }
            else
            {
                Console.WriteLine("Cancelled");
            }
        }

        private static void ClearIngredient()
        {
            throw new NotImplementedException();
        }
    }
}


To Run the Application:

1) To run the standalone command line application, you need to select Run on the start view or press F5. 

2) To Debug the standalone command line application, you need to select Debugon the start view or press F5 and VS Code will try to run your currently active file.
        




        








