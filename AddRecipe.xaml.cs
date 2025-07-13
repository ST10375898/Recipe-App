using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace design
{
    /// <summary>
    /// Interaction logic for AddRecipe.xaml
    /// </summary>
    public partial class AddRecipe : Page
    {
        // object generic list instantiations that will be used in recording of recipe details
        public List<Recipe> recipes = new List<Recipe>();
        public List<Ingredient> ingredients = new List<Ingredient>();
        public List<Step> steps = new List<Step>();
        public AddRecipe()
        {
            InitializeComponent();
        }

        private void SaveIngredient_Click(object sender, RoutedEventArgs e)
        {
            // This code will save the details of a new ingredient into the recipe array 
            // try catch block is catch any a format error that can occur of the user enters letters instead of numbers on the calories and quantity
            try
            {
                ingredients.Add(new Ingredient
                {
                    Name = ingredientName.Text,
                    Quantity = double.Parse(quantity.Text),
                    Unit = unitOfMeasure.Header.ToString(),
                    Group = group.Header.ToString(),
                    Calory = double.Parse(calories.Text),
                });
                MessageBox.Show($"Ingredient {ingredients.Count} successfully added!");
            }catch(FormatException ex)
            {
                MessageBox.Show($"Input INVALID. Please enter a Number!");
                return;
            }
           
            
        }

        private void AddIngredient_Click(object sender, RoutedEventArgs e)
        {
            // this code serves the purpose of clearing all text fields so the user can enter the details of a new recipe
            ingredientName.Text = string.Empty;
            quantity.Text = string.Empty;
            unit.Text = string.Empty;
            foodGroup.Text = string.Empty;
            calories.Text = string.Empty;
            unitOfMeasure.Header = "Unit Of Measure";
            group.Header = "Food Group";
            ingredientName.Focus();
            int recipeCount = ingredients.Count;
            ingredientCounter.Content = $"~Ingredient {recipeCount+1} Details~";
        }

        private void SaveStep_Click(object sender, RoutedEventArgs e)
        {
            // this code adds a new step to a recipe
            steps.Add(new Step { Instruction = stepInstruction.Text, });
            MessageBox.Show($"Step {steps.Count} Successfully Added");
        }

        private void AddStep_Click(object sender, RoutedEventArgs e)
        {
            stepInstruction.Text = string.Empty;
            stepInstruction.Focus();

            int stepCount = steps.Count;
            stepCounter.Content = $"~Step {stepCount+1} Description~"; 
        }

        private void saveRecipe_Click(object sender, RoutedEventArgs e)
        {
            // this section of code serves to add a new recipe with its ingredient and steps to the recipe array

            if (ingredients.Count != 0)
            {
                recipes.Add(new Recipe
                {
                    Ingredients = ingredients,
                    Name = recipeName.Text,
                    Steps = steps
                });
                try
                {
                    MessageBox.Show($"{recipes[recipes.Count - 1].Name} Recipe Successfully Added.");
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("No recipes on system yet");
                }

                ingredientName.Text = string.Empty;
                quantity.Text = string.Empty;
                unit.Text = string.Empty;
                foodGroup.Text = string.Empty;
                calories.Text = string.Empty;
                stepInstruction.Text = string.Empty;
                recipeName.Text = string.Empty;
                recipeName.Focus();


                MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
                mainWindow.recipes.AddRange(recipes);
                mainWindow.workSpace.Content = new AddRecipe();
            }
            else
            {
                MessageBox.Show("Please Enter at least one Ingredient and step!");
            }

            
        }

        // the following fuctions listen for when the user clicks on a specific unit of measure
        private void other_Click(object sender, RoutedEventArgs e)
        {
            unitOfMeasure.Header = other.Header;
        }

        private void kiloGrams_Click(object sender, RoutedEventArgs e)
        {
            unitOfMeasure.Header = kiloGrams.Header;
        }

        private void milliGrams_Click(object sender, RoutedEventArgs e)
        {
            unitOfMeasure.Header = milliGrams.Header;
        }

        private void grams_Click(object sender, RoutedEventArgs e)
        {
            unitOfMeasure.Header = grams.Header;
        }

        private void tspoons_Click(object sender, RoutedEventArgs e)
        {
            unitOfMeasure.Header = tspoons.Header;
        }

        private void cups_Click(object sender, RoutedEventArgs e)
        {
            unitOfMeasure.Header = cups.Header;
        }

        private void kiloLitres_Click(object sender, RoutedEventArgs e)
        {
            unitOfMeasure.Header = kiloLitres.Header;
        }

        private void milliLitres_Click(object sender, RoutedEventArgs e)
        {
            unitOfMeasure.Header = milliLitres.Header;
        }

        private void litres_Click(object sender, RoutedEventArgs e)
        {
            unitOfMeasure.Header = litres.Header;
        }

        // the following functions listen for when the user chooses a particular food group
        private void fats_Click(object sender, RoutedEventArgs e)
        {
            group.Header = fats.Header;
        }

        private void oil_Click(object sender, RoutedEventArgs e)
        {
            group.Header = oil.Header;
        }

        private void fruits_Click(object sender, RoutedEventArgs e)
        {
            group.Header = fruits.Header;
        }

        private void veg_Click(object sender, RoutedEventArgs e)
        {
            group.Header = veg.Header;
        }

        private void carbs_Click(object sender, RoutedEventArgs e)
        {
            group.Header = carbs.Header;
        }

        private void liqs_Click(object sender, RoutedEventArgs e)
        {
            group.Header = liqs.Header;
        }

        private void sugar_Click(object sender, RoutedEventArgs e)
        {
            group.Header = sugar.Header;
        }

        private void otherfood_Click(object sender, RoutedEventArgs e)
        {
            group.Header = otherfood.Header;
        }

        private void proteins_Click(object sender, RoutedEventArgs e)
        {
            group.Header = proteins.Header;
        }
    }
}
