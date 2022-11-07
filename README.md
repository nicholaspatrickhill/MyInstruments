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
MyInstruments begins by calling the Start method.
Start creates an instance of MainMenu and calls RunMainMenu to generate an arrow-key driven menu in the console. 
The menu's functionality and design are established by the Menu class.
RunMainMenu prompts the user to move the cursor with the UP and DOWN arrow keys on their keyboard to highlight the function that they wish to perform.
To perform the desired function the user is prompted to push enter.
The user's input executes cases in a Switch that call methods that perform the function desired by the user.

Selecting "Review Instruments" calls the ReviewAnyInstrument method from the Collection class.
ReviewAnyInstrument prompts the user to input the key of the musical instrument that they wish to review.
ReviewAnyInstrument loops the user input through the SelectInstrument If-Else block in the UserSelection class to search various musical instrument dictionaries for a matching key. 
If there is a matching key in one of the dictionaries, the program calls the PrintInstrument method from the appropriate musical instrument class.
ReviewAnyInstrument then prompts the user to enter a new key.
If the user input is not a matching key, it exits the UserSelection If-Else block and enters the SelectCommand switch in the UserCommands class. 
The UserCommands switch searches its case names for a match to the user's input.
The switch executes cases based on whether or not it finds a match.
The user may use these commands to review the keys available to the program, to clear the console or to return to the main menu screen.
If the switch does not find a match it generates an invalid input response through its default case.
In the event of invalid input, the PrintErrorMessage method is called from the ConsoleWindow class and the invalid input is logged.
The log4net nuget package is configured within the program to record the invalid user input and write the log to a .txt file in the temp folder on the C:\ drive.
The user stays in the ReviewAnyInstrument loop until they elect to return to the main menu by typing "Menu".

Selecting any of "List Instruments", "Count Instruments", "Save Text File," "Instructions" and "About This App" calls corresponding methods from the Collection and ConsoleWindow classes. The various musical instrument dictionary keys are converted to Lists by the Collection class for repeated use by its methods.

Selecting "Exit" calls the ExitTheProgram method.
ExitTheProgram prompts the user to confirm that they wish to teriminate the program by first typing "Y" or "N" and then pressing enter.
ExitTheProgram cycles the user input through an If-Else block.
If the user typed "Y" the program is terminated by an Exit method.
If the user typed "N" the Start method is called to recycle the program.
Invalid input recalls the ExitTheProgram loop until the user inputs a valid command.
Invalid input is recorded in the error log.

The abstract MusicalInstrument class establishes properties that are shared by the various musical instrument classes. 
The InstrumentAge property uses an external factor (the current date) to calculate the age of the instrument. 
The StringInstrument class inherits from MusicalInstrument and establishes additional properties that are shared by the stringed musical instrument classes. 
The Guitar, Bass, and OtherStringInstrument classes inherit from StringInstrument.
KeyboardInstrument inherits from MusicalInstrument.
Each of those musical instrument classes contains a unique dictionary and may also contain additional properties. 
My musical instruments are instantiated as objects within each dictionary. 
The objects' properties are defined in the dictionary. 
These properties are returned in ReviewAllInstruments as a concatenated string when the user types in a matching key. 
This is achieved by calling the PrintInstrument method which is an implementation of the signature in the IPrintInstrument interface by each musical instrument class.

The Tests folder contains the Musical Instruments unit. 
These quickly and safely test the string concatenations, methods and lists contained within the musical instrument classes, their parent classes and other classes.

#### INSTRUCTIONS
Use the UP and DOWN arrow keys to highlight the function that you wish to perform and then press enter.

"Read Instructions" provides instructions for using the application.

In "Review Instruments" you may review any individual instrument in my collection by typing its key and pressing enter.  
---You may review the keys available by typing "Guitars", "Basses", "Keyboards" or "Other" and then pressing enter.  
---Please note that keys are case specific and you will need to follow the case as indicated by the list for valid input.
---If the console is becoming clogged with text you may refresh it by typing "Clear" and pressing enter.
---Type "Menu" and press enter to return to the Main Menu and select another option.

"List Instruments" provides a complete list of the keys available to the program.

"Count Instruments" provides a count of each instrument type and the total number of instruments in the collection.

"Save Text File" saves a list of the instrument keys to a .txt file in the temp folder on the C:\ drive.  
TIP: This can be a handy reference guide when woking in the "Review Instruments" module.

"About This App" provides some information about the application's purpose and author.

"Exit" will terminate the program upon confirmation.

