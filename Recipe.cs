using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design
{
    public delegate string CalWarning(double calory);
    public class Recipe
    {
        // Recipe object properties declaration
        private string name;
        private List<Ingredient> ingredients;
        private List<Step> steps;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Step> Steps
        {
            get { return steps; }
            set { steps = value; }
        }

        public List<Ingredient> Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }

        // method that scales and views the recipe
        public string DisplayRecipe(double scale)
        {
            double caloryCount = 0; // variable that counts the total number of calories for a recipe
            string finalOutput = "";
            string output = "";
            string name = Name;
            string[] recipeDetails = new string[ingredients.Count];

            // displaying the ingredients of a recipe
            for (int i = 0; i < Ingredients.Count; i++)
            {
                output = $"{i + 1}. {ingredients[i].Quantity * scale} {ingredients[i].Unit} of {ingredients[i].Name} " +
                    $"(Food Group: {ingredients[i].Group} | Calories: {ingredients[i].Calory * scale})";
                recipeDetails[i] = output;
                caloryCount += ingredients[i].Calory;
            }

            string ingredientOutput = String.Join('\n', recipeDetails);

            CalWarning warning = calWarn; // assigning the calWarn method to the CalWarning Delegate

            string[] stepArray = new string[Steps.Count];
            string stepper = "";
            for (int i = 0; i < Steps.Count; i++)
            {
                stepper = $"{i + 1}. {steps[i].Instruction}";
                stepArray[i] = stepper;
            }

            string stepsOutput = String.Join("\n", stepArray);

            finalOutput = $"            Recipe Name : {name}\n" +
                          $"********************************************************" +
                          $"\n                  Ingredients:\n{ingredientOutput}\n" +
                          $"********************************************************" +
                          $"\nTotal Calories: {caloryCount * scale}\n" +
                          $"{warning.Invoke(caloryCount * scale)}\n";
            return finalOutput;
        }
        // calory warning method that checks the total number of calories and issues a warning if the number of calories exceeds a count of 300
        public string calWarn(double calory)
        {
            string output = "";
            if (calory >= 300)
            {
                output = $"**********************************************************\n" +
                        $"Calory Warning! Recipe has MORE THAN 300 CALORIES\n" +
                        $"************************************************************";
            }
            return output;
        }
        
        // method to display the steps of a recipe
        public string displaySteps()
        {
            string[] stepArray = new string[Steps.Count];
            string stepper = "";
            for (int i = 0; i < Steps.Count; i++)
            {
                stepper = $"{i + 1}. {steps[i].Instruction}";
                stepArray[i] = stepper;
            }

            string stepsOutput = String.Join("\n", stepArray);

            string lastOutput = $"********************************************************" +
                          $"\n                  Steps: \n{stepsOutput}\n" +
                          $"************* End of Recipe ****************************";
            return lastOutput;
        }
    }
}
