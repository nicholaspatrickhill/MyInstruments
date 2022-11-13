### MyInstruments

**MyInstruments** is my capstone project for Code Kentucky's Software Development Course 1. 
This Windows console application was developed to help me manage my collection of musical instruments. 
It can be difficult to recall specific details about each instrument in my collection from memory. 
I am often seeking out information like an instrument's age, string gauge, serial number and country of manufacture. 
An interactive console app makes this process easier, faster and more fun.

The app takes input from the user and prints information about the instruments in my collection to the console.

#### FEATURES
The following items from the "Feature List" are implemented:

⦁	Implement a "master loop" console application where the user can repeatedly enter commands/perform actions, including choosing to exit the program.  
⦁	Create an additional class which inherits one or more properties from its parent.  
⦁	Create a dictionary or list, populate it with several values, retrieve at least one value, and use it in your program.  
⦁	Create 3 or more unit tests for your application.  
⦁	Calculate and display data based on an external factor (ex: get the current date, and display how many days remaining until some event).  
⦁ Implement a log that records errors, invalid inputs, or other important events and writes them to a text file.  
⦁ Visualize data in a graph, chart, or other visual representation of data.  
⦁ Use a LINQ query to retrieve information from a data structure (such as a list or array) or file.  

#### NOTES
MyInstruments uses the log4net and Spectre.Console NuGet packages.
The correct package references are in the project file.
Please restore the packages through NuGet (if it wasn't set to do so automatically) or through dotnet CLI by running dotnet build and dotnet run. 

MyInstruments begins by calling the Start method.
Start creates an instance of MainMenu and calls RunMainMenu to generate an arrow-key driven menu in the console. 
The menu's functionality and design are established by an If-Else block and a Do-While loop in the Menu class.
RunMainMenu prompts the user to move the cursor with the up and down arrow keys on their keyboard to highlight the function that they wish to perform.
The user is prompted to push enter to perform their desired function.
The user's input executes cases in a Switch that call methods that perform the function desired by the user.

Selecting "Review Instruments" calls the ReviewAnyInstrument method from the UserReview class.
ReviewAnyInstrument prompts the user to input the key of the musical instrument that they wish to review.
ReviewAnyInstrument loops the user input through the SelectInstrument If-Else block in the UserSelection class to search the various musical instrument dictionaries for a matching key.
The ToLower method is called on the user input which allows for input to be case insensitive as the program searches for a matching key.
If there is a matching key in one of the dictionaries, the program calls the PrintInstrument method from the appropriate musical instrument class.
ReviewAnyInstrument then prompts the user to enter a new key.
If the user input is not a matching key, it exits the UserSelection If-Else block and enters the SelectCommand switch in the UserCommands class. 
The UserCommands switch searches its case names for a match to the user's input.
The switch executes cases based on whether or not it finds a match.
The user may use these commands to call the help menu, review the keys available to the program, clear the console or return to the main menu screen.
If the switch does not find a match it generates an invalid input response through its default case.
In the event of invalid input, the console displays an error message and the invalid input is logged.
The log4net NuGet package is configured to record the invalid user input and write the log to a .txt file in the temp folder on the C:\ drive.
The user stays in the ReviewAnyInstrument loop until they elect to return to the main menu by typing "menu".

Selecting any of "List Instruments", "Count Instruments", "Save Text File," "Read Instructions" or "About This App" calls corresponding methods from the Collection and ConsoleMessage classes.

The various musical instrument dictionary keys are converted to arrays by methods in the Collection class.
Converting this data to arrays allows for the keys to be displayed as sorted and color-coded lists by other Collection methods.
By using sorted arrays in the Collection methods, the dictionaries in each musical instrument class can easily be appended with new acquistions.

If the user inputs "fenders" during the ReviewAnyInstrument loop, the SearchForFenderInstruments method is called from the Collection Class.
SearchForFenderInstruments initializes the allInstrumentsArray which concatenates the various musical instrument key arrays.
It then uses a linq query to search the new array for all instrument keys containing "fender".
The results of this search are printed to the console.
All instruments containing "fender" are displayed regardless of their type.

"Count Instruments" calls the methods from the CollectionCount class.
CollectionCount calls the Count method on the musical instrument dictionaries to generate the total counts of each instrument type.
PrintInstrumentBreakdownChart configures Spectre.Console to display the counts of each musical instrument type in a color-coded breakdown chart.
PrintTotalInstrumentCount displays the total count of all musical instruments by adding up all of the values returned by the Count method.
PrintInstrumentPercentages displays the percentage that each musical instrument type occupies in the collection by converting the musical instrument counts from ints to doubles, dividing the counts by the total and multiplying those numbers by 100.
Math.Round is then called to round the doubles back to the nearest integers for easier-to-read display on the console.

"Save Text File" initializes Streamwriter and calls ToUpper on each musical instrument array to write a capitalized, sorted list of all of the musical instrument keys to a .txt file in the temp folder on the C:\ drive.

Selecting "Exit" calls the ExitTheProgram method.
ExitTheProgram prompts the user to confirm that they wish to terminate the program by first typing "y" or "n" and then pressing enter.
The user's input executes cases in a switch by searching case names for a match.
An input of "y" terminates the program via an Exit method.
An input of "n" recycles the program by calling the Start method.
Invalid input recalls the ExitTheProgram loop until the user inputs a valid command.
Invalid input is recorded in the error log.

The abstract MusicalInstrument class establishes properties that are shared by the various musical instrument classes. 
The InstrumentAge property uses an external factor (the current date) to calculate the age of the instrument. 
The StringInstrument class inherits from MusicalInstrument and establishes additional properties that are shared by the stringed musical instrument classes. 
The Guitar, Bass, and OtherStringInstrument musical instrument classes inherit from StringInstrument.
KeyboardInstrument inherits from MusicalInstrument.
Each of those musical instrument classes contains a unique dictionary and may also contain additional properties. 
My musical instruments are instantiated as objects within each dictionary. 
The objects' values are assigned in their dictionary. 
These values are returned in ReviewAllInstruments as a concatenated string when the user types in a matching key. 
This is achieved by calling the PrintInstrument method which is an implementation of the signature in the IPrintInstrument interface by each musical instrument class.

The Tests folder contains the Musical Instruments unit tests. 
These tests quickly and safely check the string concatenations, methods, counts, arrays and math used by the musical instrument classes, their parent classes and other classes.

#### INSTRUCTIONS
Use the UP and DOWN arrow keys to highlight the function that you wish to perform and then press enter.

In REVIEW INSTRUMENTS you may review any individual instrument in my collection by typing its key and pressing enter.  
⦁ You may review the keys available by typing "guitars", "basses", "keyboards", "other" or "fenders" and pressing enter.     
⦁ If the console is becoming clogged with text you may refresh it by typing "clear" and pressing enter.  
⦁ Type "menu" and press enter to return to the Main Menu and select another option.

LIST INSTRUMENTS provides a complete list of instruments in the collection. These names also serve as the keys in "Review Instruments"

COUNT INSTRUMENTS displays a breakdown chart with the counts of each instrument type and displays the total number of instruments in the collection.

SAVE TEXT FILE saves a list of the instrument keys to a .txt file in the temp folder on the C:\ drive.  
⦁ TIP: This can be a handy reference guide when woking in the "Review Instruments" module.

ABOUT THIS APP provides some information about the application's purpose and author.

EXIT will terminate the program upon confirmation.

