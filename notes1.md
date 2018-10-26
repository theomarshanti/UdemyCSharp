
---------------------------------------------------------------------------

1) Intro to C# & .NET


C# is a programming language; .NET is a framework for building applications on Windows
	- .NET isn't limited to C#, can use F# or VB.net too

.NET consists of :
	(1) CLR (Command language runtime)
	(2) Class Library

(1) CLR:
To explain CLR, must look at the history of C#:
Before C# had C & C++; with either of these, when we compiled the code, the compiler compiled the code for the machine it was running.
	- Compiler translates it to native code.
	- This is a problem with different hardwares and architectures
With C#, they copied Java. Java doesn't ocmpile to Machine code directly, they combine to an intermediary Byte Code.
Same with C#; you get Intermediate Language Code (IL) that is independent of the machine its running on.
The CLR (Command Language Runtime) translates the IL Code into the Native machine code; this is Just-In-Time Compilation (JIT)
	- As long as a machine has CLR it can run our application.

(2) Class Library:
A C# app consists of multiple classes. A class is comprised of Methods & Members
As the # of classes grows, we need a way to organize the classes. 
	- To do so we use NAMESPACES; a NAMESPACE is a container of related classes
Now as these namespaces grow, we need a new way to divide the operation; so we use Assemblies (either EXEs or DLLs)

Assembly: a file, in the form of an executable or a DLL, that contains one or more namespaces & classes

C# is a "STATICALLY TYPED LANGUAGE"



-------------------------

2) Initial Project Architecture


Now Section 2 Lesson 11; Move to Visual Studio
File -> New  -> Project -> Console Application (simply doesn't have a UI)
Note "Solution" can hold multiple projects


Looking at Solution Explorer, our screen is different from his; but we've attached a screenshot to show his & will explain it below.
The top level is a Solution; then the project; then:
	(1) `Properties`. It holds AssemblyInfo.cs which is a description of the executable that follows compilation
	(2) `References`. Any assemblies that this proj is referencing. By default it ha a few.
		- This is likely replaced by `Dependencies` in our version
	(3) `App.config`. Holds the XML configuration for the application; maybe settings, etc...
	(4) `Program.cs`. Our C# file; where we write our code.

Let's analyze `Program.cs`:
	- At the top we see a bunch of `using` statements
		- This allows us to use classes in different namespaces than they are declared 
		- System is a namespace in the .NET framework
	- C# automatically creates a namespace for us with our project name (here HelloWorld)
		- When we write code in a namespace, we have access to all of the classes within that namespace
		- To use code from classes in different namespaces, we must import it.
	- By default, we have a class named Program within our app, and a function called Main within that
		- By default too, `Main` is the first thing that gets run when we launch our app
			- CLR executes the code inside `Main` method first; it is Point of Entry of our app.
	`static void Main(string[] args)`; straight-forward. Just note we specify return type before function name
	`Console.WriteLine()` uses the Console class defined in the System namespace
	Can then run `ctrl+F5`



-------------------------

3) Primitive Types


Variable: A name given to a storage location in memory, where we can store the value
Constant: An immutable value

We use constants for safety in our application. Example, in Physics we need Pi to be a constant.

To declare a var in C#, can do the following:
`int number;`
`int Number = 1;`
`const float Pi = 3.14f;`

*note Mosh refers to the varname as an Identifier*
If you need to use an Identifier that clashes with a built-in C# keyword, can prefix it with an '@', ex: int @int =3;

Naming Conventions:
For local vars, Camel Case: 		`int number;`
For constants, Pascal Case:			`const int MaxZoom = 5;` 

Primitive Types include: 						{byte; short; int; long; float; double; decimal; char; bool;}
These types map to a type in .NET framework: 	{Byte; Int16; Int32; Int64; Single; Double; Decimal; Char; Boolean}

By default, compiler considers all real numbers to be `double`. To change this, we must specify;
`float number = 1.2f;` | `decimal number = 1.2m;`
Without the f or m, then the compiler will think we are passing a double to a var of a different type and will therefore throw an error.

Overflowing:
	- By default in C# there is no overflow checking.
	- `byte number = 255; number++;` Now number will be set to 0.
	- To put in overflow checking, we must use the `checked` block:
	 `checked{byte number = 255; number++;}`. Here, an exception will be thrown.
		- But in practice this isn't really used.


Type-Converstion:
	Implicit & Explicit
	Implicit: 
		`byte b = 1; int i = b;` We can do this; there is no data-loss. Simply need to add 3 bytes of 0's
		`int i = 1; byte b = i;` We can't do this; an int is 4 bytes, a byte is 1 byte; if we do this there'll be data loss.
		- In situations like that we must do it explicitly ("Casting")
	Explicit:
		In the 2nd ex, above, we must do `int i = 1; byte b = byte(i)`
		Add'ly `float f = 1.0f; int i = (int)f;`
		This signals to the compiler that we are aware of the data-loss & wish to proceed anyway.
		`string s = "1"; int i = int(s)` WON'T COMPILE; instead need: `int i = Convert.ToInt32(s);` or `int i = int.Parse(s);`

Operators:
	1) Arithmetic : + - * /  ++ -- etc
		- Note: can go a++ or ++a
		- Note: If you divide 2 integers you get an integer; 10/3 = 3.. 
		- PEMDAS applies!!
	2) Comparison : == > < >= <= !=
	3) Assignment : = += -= /=   
	4) Logical : && || !
	5) Bitwise : & |

Comments: Either `//` or `/* ... */` if multiple lines.



-------------------------

3) Non-Primitive Types


`public class person {}` 
where Public is 'access modifier'

To create objects in C#, must first allocate memory for it. Unlike in languages like C & C++ thoigh, don't need to worry about allocating that 
 memory yourse;f the CLR will take care of it for you. The process is known as Garbage Collection
`Person person = new Person();
Person.name = "Omar"`

The `static` modifier:
`int result = Calculator.Add(1,2);`
This pevents all instances of Calculator class from having to store the same functionality. Here, it is only stored in 1 place and therefore is 
 more efficient.
The method/member is accesible from the class itself, not the objects within it.


In C#, also have STRUCTS - Small lightweight structure
`struct myColor { int red; int blue; int green; } `

Arrays:
`int[] numbers = new int[4]; numbers[0]=1;`
`int[] numbers = new int[4]{ 1, 2, 3, 4};`
	- must have memory allocation (hence the "new" keyword)
	- have fixed size that can't be expanded

Strings:
	`string firstName = "test"`
	`string test = string.Format("{0} {1}", firstName, lastName});`
	` `
	`var numbers = new int[3] {1,2,3};`
	`string list = string.Join(",", numbers);`
	
 	- In C# Strings are immutable!!
 	In C#, we have verbatim strings! These avoid need for backslash escape character
 	`string path = @"c:\proj\proj1\folde"` 

Enums: 
	- Use enums where you have a # of related constants; 
	- An enum is intenrally an integer:
	const int a = 1; const int b = 2; const int c = 3;


2 types from where all objects are derived: {Structs, Classes}
All primitive types are defined as Structures as well as all custom structs
Classes include Arrays, Strings, Custom Classes
Structures are "value TYpes" while Classes are "reference types"

Structures: {Allocated on Stack; Memory allocation done automatically; Immediately removed when out o scope }
Classes: { You need to allocate memory (new keyword); memory allocated on heap; Garbage collected by CLR}



-------------------------

4) Control Flow

If/else statements; Switch/Case statements; cond'l operator a? b:c

if {} else if {} else {}

switch(role){ case a: .. break; case b: .. break; default : .. break; }

`var random = new Random();`
`random.Next();` generates a random #.



-------------------------

5) Arrays and Lists


Fixed # of elements of a given type

Single Dimension Arrays - var numbers = new int[5];

2 types of MultiDimensional arrays: 
Rectangular - all rows have the same # of elements
Jagged - all rows have independent #s of elements
	- This can be thought of best as an array of arrays; each row being its own independent array

To declare a rectangular array:
`var matrix = new int[3,5]` -> 3 rows, 5 columns
`var matrix = new int[3,5,4]` 3D array, etc....


To declare a jagged array:
`var array = new int[3][];` -> 3 rows


Lists: Use when we dont know how many objects we need.
var numbers = new List<int>();

Add() AddRange() Remove() RemoveAt() IndexOf() Contains() Count



-------------------------

5) Dates and Times




-------------------------

6) Strings

Formatting:
toLower() 	toUpper()	Trim()

Search:
indexOf()	LastIndexOf()

Substrings:
Substring(statIndex)	substring(start, length)

Replace:
Replace('a', '!')

IsNullOrEmpty 		IsNullOrWhiteSpace

str.Split(' ')

Converting to Nums:
int.Parse(s); 	Convert.ToInt32(s); [the latter is better]

Converting from Nums:
int i = 1234; i.ToString();

StringBuilder
A class defined in System.Text namespace that wllows you to modify a string
It is not too fast, but it allows for quick manipulation
To use it must declare `using System.Text`


Procedural Programming: A programming paradigm based on procedure calls.
	- Rather than have all the code in the `Main` function, break it down into a # of functions




-------------------------

6) Files & Directories:

We have a namespace called System.IO which is where all the relevnt classes that work with files & directories are located

A few common classes: 
File & FileInfo: Create Copy move, deleting, opening files
	- FileInfo provides Instance Methods
	- File provides Static Methods
		reate() Copy() DElete() Exists() GEtATtribute() etc...

		** Security checking is done only during instantiation of FileInfo, and thats why its more efficient than File if you're
		 executing multiple operations on a given File as security checing will be done only once

Directory & DirectyInfo:
	- Very similar, only used to work with directory
	- CreateDirectory) Exists() Move() GetFiles() GetCurrentDirectory()

Path:
	- Methods to work w/ string that contains path info
	- GetDirectoryName() GetFileName() GetExtension() etc

	Note that all comes from System.IO



-------------------------

7) Debugging:

F5 - run in debug move
ctrl+F5 - run in not debug move
Set a break point before running F5

F9 : Break point
F10 : Step Over
F11 : Step into
Shift + F11: Step out
Shift + F5 : Stop debugging
The watch window is important. Can put the vars we want to keep track of the value of there.


var buffer = new List<int>(list);


throw new ArgumentOutOfRangeException("count", "Count can't be grater than the number of elements in the list")

-------------------------

VS Shorcuts:


`ctrl+F5` runs the app
`ctrl+shift+B` compiles/'builds' the project. 

In VS, there are a number of built-in code snippets that we can use t oavoid writing the full command
ex: can write `cw` and then click tab & we get `console.writeLine(.)`

Can put the mouse over and then hold `ctrl` and click -> Object Browser explorer.

Using ReSharper, can move a class definition from 1 file to its own .cs file.
To do so, select the class name and then go `ctrl`+Enter. 
Then you'll se an option to move it to a new file.
Hwoever, if you dont want to do this, can also Right Click on the Project in SOl'n Explorer & click New Class there.
We created a new folder called Math from there to house our Calculator also.
- But then, you need to change the namespace of that moved class to recognize the directory. `calculator.math`







