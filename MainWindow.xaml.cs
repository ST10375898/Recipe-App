using System.Text;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Recipe> recipes = new List<Recipe>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // code to change the content property of the Frame called workSpace to a new AddRecipe page
            workSpace.Content = new AddRecipe();
        }

        private void workSpace_Navigated(object sender, NavigationEventArgs e)
        {
            // code to change the content property of the Frame called workSpace to a new AddRecipe page
            workSpace.Content = new AddRecipe();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // this generates a new HomePage window and also transfers the recipe objects of this window to page being generated
            HomePage homePage = new HomePage();
            homePage.recipes.AddRange(recipes);
            workSpace.Content = homePage;

            
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // this generates a new Display window and also transfers the recipe objects of this window to page being generated
            DisplayRecpe displayRecpe = new DisplayRecpe();
<<<<<<< HEAD
            var recipeOrder = from recipe in recipes orderby recipe.Name select recipe;
            displayRecpe.recipes.AddRange(recipeOrder);
=======
            var odererdRecipe = from recipe in recipes orderby recipe.Name select recipe;
            displayRecpe.recipes.AddRange(orderedRecipe);
>>>>>>> 0984b50bb60c77140a9c17d62be68a004e561bf7
            workSpace.Content = displayRecpe;

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            workSpace.Content = new AddRecipe();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            recipes.Clear();
            MessageBoxOptions options = MessageBoxOptions.DefaultDesktopOnly;
            MessageBox.Show("All Recipes have been cleared");
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.workSpace.Content = new AddRecipe();
        }
    }
}
