### MyInstruments

**MyInstruments** is my capstone project for Code Kentucky's Software Development Part 1. 
This console application was developed to help me manage my collection of musical instruments. 
It can be difficult to recall specific details about each instrument in my collection from memory. 
I am often seeking out information like an instrument's string gauge, serial number and country or age of manufacture. 
An interactive console app makes this process easier, faster and more fun.

The app takes input from the user to print information about the instrument of their choosing, or information pertaining to the entire collection, on the screen.

The long-term goal for this app is to develop a web and/or mobile version using an external database that users could utilize to store and retrieve data about their own collections.


#### FEATURES
The following items from the "Feature List" are implemented:

⦁	Implement a "master loop" console application where the user can repeatedly enter commands/perform actions, including choosing to exit the program.

⦁	Create an additional class which inherits one or more properties from its parent.

⦁	Create a dictionary or list, populate with several values, retrieve at least one value, and use it in your program.

⦁	Create 3 or more unit tests for your application.

⦁	Calculate and display data based on an external factor (ex: get the current date, and display how many days remaining until some event).

⦁ Implement a log that records errors, invalid inputs, or other important events and writes them to a text file.

#### NOTES
MyInstruments begins by creating an instance of MainMenu to call RunMainMenu which generates an arrow-key driven menu in the console. The menu's properties are established in the Menu class. The user can select an action by moving the cursor with the UP and DOWN arrows keys to the desired command and pressing enter. The user's arrow key input calls cases in a Switch which call methods to the corresponding action desired by the user.

Selecting "Review Instruments" calls the ReviewAll method which generates a master loop where the user can enter a key to review data about the instruments in my collection. 
The user input is looped through an If-Else block in the UserSelection class to search various dictionaries for a matching key. 
If the user elected to review a specific instrument, the program will call this information from the dictionary and print it to the console.
The console will then prompt the user to enter a new key.
The user will stay in this loop until they elect to return to the main menu.
If the user input is not a matching key, it exits the UserSelection If-Else block and enters a switch in the UserCommands class. 
The UserCommands switch allows the user to clear the console, return to the main menu screen or generates an Invalid Input response. 
The log4net nuget package is configured within the program to record invalid user input and write the log to a .txt file in the temp folder on the C drive.

Selecting "List Instruments", "Count Instruments", "Save Text File," and "About This App" call corresponding methods from the Collection and ConsoleWindow classes.

Selecting "Exit" uses an Exit method to terminate the program.

The abstract MusicalInstrument class sets properties that are shared by the various instrument classes. 
The InstrumentAge property uses an external factor (the current date) to calculate the age of the instrument. 
The StringInstrument class inherits from MusicalInstrument and sets additional properties which are shared by the stringed instrument classes. 
The Guitar, Bass, and OtherStringInstrument classes inherit from StringInstrument.
KeyboardInstrument inherits from MusicalInstrument.
Each of those classes contains a unique dictionary. 
My musical instruments are instantiated as objects within each dictionary. 
The objects' properties are defined in the dictionary. 
This data is what is called by the user in the master loop. 
These classes contain additional methods that are implementations of the signatures in the IMusicalInstrument interface.

The Tests folder contains several unit tests for each instrument class. 
These quickly and safely test the string concatenations and methods contained within the instrument classes and their parent classes.

#### INSTRUCTIONS
The easiest way to get started is to select "List Instruments" to see a list of the keys that correspond to the musical instruments that are available for review.

Then return to the main menu and select "Review Instruments."
Here you can review any individual instrument in my collection by typing the key exactly as it appeared in the list.

**Please note that keys are case specific and you will have to follow the case as indicated by the list for valid input (i.e. type "Fender Jazzmaster", "Fender USA Stratocaster", "Hofner Club Bass", etc. to see data about those individual instruments.)

If the console is becoming clogged with user input and information you may refresh it by typing "Clear."

Type "Menu" to return to the Main Menu and select another option.

"Count Instruments" will provide a count of each instrument type and the total number of instruments in the collection.

"Save Text File" will save a list of the instrument keys to a .txt file in the temp folder on the C drive.
This can be a handy reference guide when woking in the "Review Instruments" component.

"About This App" provides some information about the application's purpose and author.

"Exit" will exit the program.

