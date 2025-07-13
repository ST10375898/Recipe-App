## POE PART 3
## This repository contains a Windows FrameWork (WPF) application for a recipe system that is able to store a recipe with all its details(ingredients and steps) and allows users to have additional functionalities and actions that they can perfom on the recipes.

This application has been built for People of the culinary arts and food lovers who want to store and access their favorite recipes on their devices. The application is built to allow users to be able to perform the following actions when they are running the application:

* Create a new recipe by clicking the 'Add Recipe' button on the home screen of the application.
* Enter the Ingredients of a recipe by using the availabla controls.
* Enter the descriptions of the steps of the particular recipe.
* View the recipes that they have eneterd in the system.
* Change the recipe measurements to different scales using the scaling fuctions.
* Clearing all the recipes that are on the system by using the 'Clear Data' button.
* Filter the recipes by using the following criteria:
    1. Ingredient Name
    2. Food Group
    3. Max Calories.
All the functions listed above are fully described in the following sections of the ReadMe file.

## Changes and Improvements

This application has been developed from the POE PART 2 project with the following repository link (). PART 2 is a C# console application that performs the some of the fuctionalities that are listed above. This are the changes that have been made to the overall project:
* The appliation is now a WPF application that presents the same fuctionalities of the POE PART 2 in a user friendy user interface.
* The WPF application can now filter the recipes that a user wants see based on a search term the user enters.
* The applicaiton can now clear all recipes that are in the system.
* The user can now choose a unit of measure that they want to use instead of typing it into the system.
* The user can now alsoo choose a food group from a list of food groups instead of typing it into the system.

## Lecturer Recommendations

Our lecturer has made the following recommendations based on our POE PART2 that we should emplement in our POE PART 3. The recommendations and their emplementations are as follows:
* Storing unit tests correctly: This was a recommendation made dude to the poor storage techeniques that were used in storing the unit tests in part 2. This recommendation has been emplemeted by the emplementation of an MS Test project the that will implements all the unit tests of the appliation. All the usin tests have now been stored in the same MS Test project instead of two different projects that store each individual unit test.

That is all the recommendations and their emplementations according to the lecturer.

## User Instructions.

1. Clone project from git hub.
2. If you cannot clone project just download project as a file.zip and extract file contents once the are extracted.
3. Open Microsoft Visual studio or your IDE of choice that can run a C# console application that does of .NET VERSION 8 long-term support. (It is advisable to open project using Microsoft visual studio with .NET Version 8 to avoid running into any incompatibility issues that may arise.).
4. Once project is open view the solution on IDE and run solution.
5. Upon building the solution the WPF application will display the MainWindow which has been styled and emplemented to be the Home Window of the application. The user will have buttons on the top margin of the applicaiton which are desribed below:
    - Home button: This button displays the MainWindow of the application whenever it is clicked.
    - Add Recipe Button: This button displays the AddRecipePage that has all the necessary controls that all the user to enter the details of a recipe and save it..
    - View Recipe Button: This button has controls that allow the user to view recipes that are on the system.
    - Clear Button: This button deletes all the recipes that are on the system when it is clicked.

    * This is a screenshot of the application upon running the application: <img src="Screenshot (222).png" width="" height="500px" alt="Image of basic system functionalities.">
6. When the user clicks the Add Recipe button the application shows the Add Recipe page. This page consists of the followng controls that allow the user to enter the datails of a recipe:
    - Recipe Name text box that takes in the name of the recipe.
    - Ingredient Name text box that takes in the name of an ingredient.
    - Quantity text box that takes in the quantity of the ingredient.
    - Unit of Measure menu that allows the user to choose the unit of measure for the ingredient quantity.
    - Food group menu that allows user to choose the food group of the ingredient.
    - Calories text box that takes in the calory count of the ingredient.
    - Step description text box that takes in each step that the user enters.
    - Save ingredient button that adds theingredient to the ingredient generic collection.
    - Add next Ingredient button that clears all input text boxes for the ingredient details.
    - Save Step button that saves a step that the user enters
    - Add next step button that clears the step description text box.
    - Save recipe button that saves all the details that the user entered for that particular recipe.
    <img src="Screenshot (225).png" width="" height="500px">
    <img src="Screenshot (226).png" width="" height="500px">
7. When the user clicks the View recipe button the ViewRecipe Page is shown and has the following controls for view the recipe and manipulating it's measurements:
    - The Choose Recipe button that displays the names of all the availbale recipes that the user has entered.
    - The Recipe List that will display the names of the available recipes.
    - Display button which will display the details of the recipe that the user chooses from the list of recipes in the system.
    - Radio buttons that scale the recipe by changing it's measurement by the scale that has been chosen by the user.
    - The original scale radio button that will reset the measurements of the recipes.
<img src="Screenshot (227).png" width="" height="500px">
## Recipe Filter Fuctiontion
The application consists of a filter funtion that is able to filter the recipes of in the system by a specific ingredient name, food group or max number of calories. This are the steps that need to be taken to make full use of the this feature:

1. The user has to enter the item that they want to search for in all the recipes.
2. The user must then direct the system on how to filter the recipes. They can choose to filter either by ingredient name, food group or max calories.
3. The user must then click the search button to initiate the search function. If the particular search item is found then the name of the recipe with the search term is    listed on the list of recipes.

This process will successfully filter the recipe list to produce the necessary recipes that the user is looking for.
<img src="Screenshot (227).png" width="" height="500px">

## If you want to make changes to project
This is an open project and therefore any one is free to download and rename the file and make any kind of changes that they desire. Users can change the project to suit their own needs and even make vital improvements to the project that can help the project to fuction better than it does now.

## If you find a bug
In case that you find a but please put in a a file detailing the bug and a probable solution when you submit a pull request.

## Thank you for reading
I hope you enjoy using this project, Thank you.
## Github Repository Link
<<<<<<< HEAD
<a href="https://github.com/ST10375898/POE_PART3">Repository Link</a>
## Screeshot of Repository Commit
<img src="Screenshot (178).png" width="" height="500px">
=======
<a href="https://github.com/ST10375898/POE_PART2">Repository Link</a>
## Screeshot of Repository Commit
<img src="Screenshot (228).png" width="" height="500px">
>>>>>>> 0984b50bb60c77140a9c17d62be68a004e561bf7





