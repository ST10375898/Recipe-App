using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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
    /// Interaction logic for DisplayRecipe.xaml
    /// </summary>
    public partial class DisplayRecpe : Page
    {
        public List<Recipe> recipes = new List<Recipe>();
        public DisplayRecpe()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {
            // this is the code that will search through each recipe for a particular ingredient, food group or number of calories
           /* recipeList.Items.Clear();
            bool itemFound = false;
            if (searchIngrdient.IsChecked == true)
            {
                foreach (var recipe in recipes)
                {
                    // outer loop gives us the recipes then inner loop is for getting the ingredients of each recipe
                    foreach (var ingredient in recipe.Ingredients)
                    {
                        // if a recipe with the name of a particular ingredient is found then that recipe is put on the list of recipes
                        if (ingredient.Name.Trim().ToUpper() == searchTerm.Text.Trim().ToUpper())
                        {
                            itemFound = true;
                            recipeList.Items.Add(recipe.Name);
                            MessageBox.Show($"Recipe List Filtered Successfully");
                        }
                        else
                        {
                            itemFound = false;
                        }
                    }
                }
                // using a boolean flag or check if a search was successful or unsuccessful
                if (itemFound == false)
                {
                    MessageBox.Show($"No Recipe contains '{searchTerm.Text}' ingredient.");
                    foreach (var recip in recipes)
                    {
                        recipeList.Items.Add(recip.Name);
                    }
                }
            }
            else if(searchGroup.IsChecked == true)
            {
                foreach (var recipe in recipes)
                {
                    foreach (var ingredient in recipe.Ingredients)
                    {
                        if (ingredient.Group.Trim().ToUpper() == searchTerm.Text.Trim().ToUpper())
                        {
                            itemFound = true;
                            recipeList.Items.Add(recipe.Name);
                            MessageBox.Show($"Recipe List Filtered Successfully");
                        }
                        else
                        {
                            itemFound = false;
                        }
                    }
                }
                if (itemFound == false)
                {
                    MessageBox.Show($"No Recipe contains '{searchTerm.Text}' food group.");
                    foreach (var recip in recipes)
                    {
                        recipeList.Items.Add(recip.Name);
                    }
                }
            }
            else if(searchCalory.IsChecked == true)
            {
                try
                {
                    foreach (var recipe in recipes)
                    {
                        foreach (var ingredient in recipe.Ingredients)
                        {
                            if (ingredient.Calory == double.Parse(searchTerm.Text.Trim()))
                            {
                                itemFound = true;
                                recipeList.Items.Add(recipe.Name);
                                MessageBox.Show($"Recipe List Filtered Successfully");
                            }
                            else
                            {
                                itemFound = false;
                            }
                        }
                    }
                    if (itemFound == false)
                    {
                        MessageBox.Show($"No Recipe contains '{searchTerm.Text}' Number of Calories.");
                        foreach (var recip in recipes)
                        {
                            recipeList.Items.Add(recip.Name);
                        }
                    }
                }catch(FormatException ex)
                {
                    MessageBox.Show($"Invalid Search Term Please enter a number");
                    return;
                }
               
            }*/
           
            

        }

        private void outputRecipeDisplay_Click(object sender, RoutedEventArgs e)
        {
            // this is the code runs when the scaling is happening
            foreach(var recipe in recipes)
            {
                if (recipe.Name.Equals(recipeList.SelectedItem))
                {
                    // the scaling factor is changed according to the scale the user selects
                    if(origionalScale.IsChecked == true)
                    {
                        display.Items.Clear();
                        display.Items.Add( recipe.DisplayRecipe(1));
                        display.Items.Add(recipe.displaySteps());

                    }
                    else if(doubleScale.IsChecked == true)
                    {
                        display.Items.Clear();
                        display.Items.Add(recipe.DisplayRecipe(2));
                        
                        display.Items.Add(recipe.displaySteps());
                    }
                    else if(tripleScale.IsChecked == true)
                    {
                        display.Items.Clear();
                        display.Items.Add(recipe.DisplayRecipe(3));
                        display.Items.Add(recipe.displaySteps());
                    }
                    else if(halfScale.IsChecked == true)
                    {
                        display.Items.Clear();
                        display.Items.Add(recipe.DisplayRecipe(0.5));
                        display.Items.Add(recipe.displaySteps());
                    }
                }
            }
        }

        private void chooseRecipe_Click(object sender, RoutedEventArgs e)
        {
            // when user clicks this button the system will display all the available recipes in a list view
            recipeList.Items.Clear();
            foreach(var recipe in recipes)
            {
                recipeList.Items.Add(recipe.Name);
            }
        }

        private void searchIngrdient_Click(object sender, RoutedEventArgs e)
        {
            recipeList.Items.Clear();
            bool itemFound = false;
            filter.Header = "Ingredient";
            foreach (var recipe in recipes)
            {
                // outer loop gives us the recipes then inner loop is for getting the ingredients of each recipe
                foreach (var ingredient in recipe.Ingredients)
                {
                    // if a recipe with the name of a particular ingredient is found then that recipe is put on the list of recipes
                    if (ingredient.Name.Trim().ToUpper() == searchTerm.Text.Trim().ToUpper())
                    {
                        itemFound = true;
                        recipeList.Items.Add(recipe.Name);
                        MessageBox.Show($"Recipe List Filtered Successfully");
                    }
                    else
                    {
                        itemFound = false;
                    }
                }
            }
            // using a boolean flag or check if a search was successful or unsuccessful
            if (itemFound == false)
            {
                MessageBox.Show($"No Recipe contains '{searchTerm.Text}' ingredient.");
                foreach (var recip in recipes)
                {
                    recipeList.Items.Add(recip.Name);
                }
            }
        }

        private void searchGroup_Click(object sender, RoutedEventArgs e)
        {
            filter.Header = "Food Group";

            recipeList.Items.Clear();
            bool itemFound = false;
            filter.Header = "Ingredient";
            foreach (var recipe in recipes)
            {
                // outer loop gives us the recipes then inner loop is for getting the ingredients of each recipe
                foreach (var ingredient in recipe.Ingredients)
                {
                    // if a recipe with the name of a particular ingredient is found then that recipe is put on the list of recipes
                    if (ingredient.Group.Trim().ToUpper() == searchTerm.Text.Trim().ToUpper())
                    {
                        itemFound = true;
                        recipeList.Items.Add(recipe.Name);
                        MessageBox.Show($"Recipe List Filtered Successfully");
                    }
                    else
                    {
                        itemFound = false;
                    }
                }
            }
            // using a boolean flag or check if a search was successful or unsuccessful
            if (itemFound == false)
            {
                MessageBox.Show($"No Recipe contains '{searchTerm.Text}' ingredient.");
                foreach (var recip in recipes)
                {
                    recipeList.Items.Add(recip.Name);
                }
            }
        }

        private void searchCalory_Click(object sender, RoutedEventArgs e)
        {
            filter.Header = "Calories";
            recipeList.Items.Clear();
            bool itemFound = false; 
            
           
            try
            {
                foreach (var recipe in recipes)
                {
                    foreach (var ingredient in recipe.Ingredients)
                    {
                        if (ingredient.Calory == double.Parse(searchTerm.Text.Trim()))
                        {
                            itemFound = true;
                            recipeList.Items.Add(recipe.Name);
                            MessageBox.Show($"Recipe List Filtered Successfully");
                        }
                        else
                        {
                            itemFound = false;
                        }
                    }
                }
                if (itemFound == false)
                {
                    MessageBox.Show($"No Recipe contains '{searchTerm.Text}' Number of Calories.");
                    foreach (var recip in recipes)
                    {
                        recipeList.Items.Add(recip.Name);
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Invalid Search Term Please enter a number");
                return;
            }
        }

        private void origionalScale_Click(object sender, RoutedEventArgs e)
        {
            // this code prints the output of the recipe details as the recipe is being scaled by the user.
            foreach (var recipe in recipes)
            {
                display.Items.Clear();
                display.Items.Add(recipe.DisplayRecipe(1));
                display.Items.Add(recipe.displaySteps());
            }
        }

        private void doubleScale_Click(object sender, RoutedEventArgs e)
        {
            foreach (var recipe in recipes)
            {
                display.Items.Clear();
                display.Items.Add(recipe.DisplayRecipe(2));
                display.Items.Add(recipe.displaySteps());
            }
        }

        private void tripleScale_Click(object sender, RoutedEventArgs e)
        {
            foreach (var recipe in recipes)
            {
                display.Items.Clear();
                display.Items.Add(recipe.DisplayRecipe(3));
                display.Items.Add(recipe.displaySteps());
            }
        }

        private void halfScale_Click(object sender, RoutedEventArgs e)
        {
            foreach (var recipe in recipes)
            {
                display.Items.Clear();
                display.Items.Add(recipe.DisplayRecipe(0.5));
                display.Items.Add(recipe.displaySteps());
            }
        }
    }
}
