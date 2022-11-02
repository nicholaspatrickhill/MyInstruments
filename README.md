### MyInstruments

**MyInstruments** is my capstone project for Code Kentucky's Software Development Part 1. 
This console application was developed to help me manage my collection of musical instruments. 
It is often difficult to recall specific details about each instrument in my collection from memory. 
I am often seeking out information like an instrument's string gauge, serial number and country or age of manufacture. 
An interactive console app makes this process easier, faster and more fun.

The app takes input from the user to print information about the instrument of their choosing on the screen. 
Additionally, it can print a list of all of the instruments recorded in its memory or it can print lists of the instruments by their type.

The long-term goal for this app is to develop a web and/or mobile version that outside users could utilize to store and retrieve data about their own collections.


#### FEATURES
Whenever a "Feature List" item is implemented it is designated in the code with a comment.

The following items from the "Feature List" are implemented:

⦁	Implement a "master loop" console application where the user can repeatedly enter commands/perform actions, including choosing to exit the program.

⦁	Create an additional class which inhereits one or more properties from its parent.

⦁	Create a dictionary or list, populate with several values, retrieve at least one value, and use it in your program.

⦁	Create 3 or more unit tests for your application.

⦁	Calculate and display data based on an external factor (ex: get the current date, and display how mant days remaining until some event).

⦁ Implement a log that records errors, invalid inputs, or other important events and writes them to a text file

#### NOTES
MyInstruments implements a master loop in the Main method where the user can enter different commands to review data about the instruments in my collection. 
The user can elect to review data specific to an individual instrument or may review data about the collection as a whole. 
The user can exit the master loop at any time by typing "Quit."

The user input is first looped through an If-Else block to search various dictionaries for a matching key. 
If the user elected to review a specific instrument, the program will call this information from the dictionary and print it to screen. 
If the user input is not pertaining to a specific instrument, it exits the If-Else block and enters a switch. 
The cases in the switch call various different methods, mostly pertaining to reviewing the collection as a whole. 
These Methods are contained in the Collection class. 
These methods allow the user to see lists of all of the instruments in the collection, or lists of each type of instrument, or to count all of the instruments, or to count each type of instrument, or to print all of the instruments to a text file. 
Additional methods are contained in the ConsoleWindow class. 
These include the methods to clear the console, to view a list of commands available to the user, to print an error message to the screen when invalid input is received and to print the header text to the screen to start the program. 

The abstract Musical Instrument class sets properties that are shared by the various instrument type classes. 
The InstrumentAge property uses an external factor (the current date) to calculate the age of the instrument. 
The StringedInstrument class inherits from MusicalInstrument and sets additional properties which are shared by the stringed instruments. 
Guitar, Bass and Ukulele classes inherit from StringedInstrument. 
Each of those classes contains a dictionary with all of the instrument objects available to the program. 
The object properties are defined in the dictionary. 
This data is called by the user in the master loop. 
These classes contain additional methods that are implementations of the signatures in the IMusicalInstrument interface.

The tests folder contains several unit tests for each instrument class. 
These quickly and safely test string concatenations and methods contained within the individual instrument classes and their base classes.

The log4net nuget package is configured in the program to record invalid user input and write it to a text file.

#### INSTRUCTIONS
The easiest way to get started is to type "All" to see a list of all the musical instruments available for review. 
Then you can review any individual instrument by typing its name exactly as it appears in the list. 
Please note that names are case specific and you will have to follow the case as indicated by the list for valid input (i.e. type "Fender Jazzmaster", "Fender USA Stratocaster", "Hofner Club Bass", etc. to see data about those individual instruments.) 
For a list of other commands, like those to count instruments and clear the console, type "Commands". 
Type "Quit" to exit the program.
