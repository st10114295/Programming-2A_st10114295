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
                Console.Write("Indicate the unit of measurement(for example, two cups of sugar: ");
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
