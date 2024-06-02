# C# Notes

These are some notes I took for C# to prepare for this interview.
I'm familiar with C# and have used it several times, but never at a workplace, so I'm a bit rusty.

To start, Visual C# and C# are the same thing. Visual C# is just a marketing name for it, or sometimes used to refer to C# when used in conjunction with Visual Studio.

It's commonly used for:
- Mobile and desktop apps
- Web apps and services
- Games, including VR
- Database applications and business logic

OOP, big community, lots of first and third-party support. Familiar with Java and C++, making it easier for developers to switch between them.

## Basic Syntax
Start a program by importing required libraries, called "Namespaces" in C#. This almost always includes the `System` namespace.
```csharp
using System;
```

Then declare a namespace and your classes, methods, and logic:
```csharp
using System

namespace HellowWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}
}
```

> Hint: If you left out `using System` you could just call the `WriteLine` method using `System.Console.WriteLine`. The `Write` method is similar, but doesn't add a new line feed to the end of the output.

**C# is case sensitive.**

The name of the file does not have to match the name of the class, but they do, for organization. Save the file with the extension `.cs`.

C# has both inline comments:
```csharp
// I'm a C# Comment
```

And block comments:
```csharp
/*
Multi-line comment
*/
```

## Common Datatypes
C# uses `int`, `long`,`float`,`double`, `char`, `string`, and `bool`, to start.


| Type   | Size                  | Description                                                |
| ------ | --------------------- | ---------------------------------------------------------- |
| int    | 4 bytes               | Stores whole numbers from -2,147,483,648 to 2,147,483,647  |
| long   | 8 bytes               | -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807    |
| float  | 4 bytes               | fractional numbers, can store 6 to 7 decimal digits.       |
| double | 8 bytes               | sufficient for storing 15 decimal digits                   |
| bool   | 1 bit                 | Stores true or false values                                |
| char   | 2 bytes               | Stores a single character, or letter, surrounded by quotes |
| string | 2 bytes per character | A sequence of characters, surrounded by double quotes.     |


## Variables
Declare a variable using:
```csharp
// type varName = value;
string name = "John"
```

`double` types will need to be ended with a 'D':
```csharp
double myNum = 5.99D
```

`floating` types will need to be ended with a 'F':
```csharp
float myNum = 5.75F
```

These are called **literal suffixes**. Use `m` to create a literal decimal.

They can also represent scientific numbers:
```csharp
float f1 = 35e3F;
double d1 = 12E4D;
```
### Constants
Declare a constant using:
```csharp
const int myNum = 15
```

Can't be changed.

### Output a variable
Output a variable by concatenating to a string:
```csharp
string name = "John";
Console.WriteLine("Hello " + name);
```

### Declare many vars
```
int x = 5, y = 4, z = 3;
```

### Naming Convention
- Can contain letters, digits, and underscore
- Must begin with lowercase or an underscore
- Should start with a lowercase letter
- Are case sensitive
- Reserved keywords cannot be var names

### Casting
- **Implicit Casting** (automatically) - converting a smaller type to a larger type size  
	- `char` -> `int` -> `long` -> `float` -> `double`  
- **Explicit Casting** (manually) - converting a larger type to a smaller size type  
	- `double` -> `float` -> `long` -> `int` -> `char`
### Type Conversion Methods
- `Convert.ToString`
- `Convert.ToDouble`
- `Convert.ToInt32`
## User Input
Accept input from users.

### Get User Input
`Console.ReadLine`

### User Input and Numbers
`ReadLine` returns a string, so you have to cast it to an int or whatever. If the user enters the wrong value though and can't be converted, expect this and catch the error.

## Operators

### Arithmetic

| Operator | Name           | Description                            | Example |
| -------- | -------------- | -------------------------------------- | ------- |
| +        | Addition       | Adds together two values               | x + y   |
| -        | Subtraction    | Subtracts one value from another       | x - y   |
| *        | Multiplication | Multiplies two values                  | x * y   |
| /        | Division       | Divides one value by another           | x / y   |
| %        | Modulus        | Returns the division remainder         | x % y   |
| ++       | Increment      | Increases the value of a variable by 1 | x++     |
| --       | Decrement      | Decreases the value of a variable by 1 | x--     |
Funny thing about arithmetic in C#...

When you are writing a formula using literal numbers, make sure the numbers you are using are the same data type as the variable they are being assigned to.

For example, if you are storing the result in a float, ensure that your literal numbers are using the 'f' suffix. Example:
```csharp
int fahrenheit = 94;

float cels = (fahrenheit - 32f) * (5f/9f);

Console.WriteLine(cels);
```

### Assignment
| Operator | Example | Same As    |
| -------- | ------- | ---------- |
| =        | x = 5   | x = 5      |
| +=       | x += 3  | x = x + 3  |
| -=       | x -= 3  | x = x - 3  |
| *=       | x *= 3  | x = x * 3  |
| /=       | x /= 3  | x = x / 3  |
| %=       | x %= 3  | x = x % 3  |
| &=       | x &= 3  | x = x & 3  |
| \|=      | x \|= 3 | x = x \| 3 |
| ^=       | x ^= 3  | x = x ^ 3  |
| >>=      | x >>= 3 | x = x >> 3 |
| <<=      | x <<= 3 | x = x << 3 |
### Comparison
| Operator | Name                     | Example |
| -------- | ------------------------ | ------- |
| ==       | Equal to                 | x == y  |
| !=       | Not equal                | x != y  |
| >        | Greater than             | x > y   |
| <        | Less than                | x < y   |
| >=       | Greater than or equal to | x >= y  |
| <=       | Less than or equal to    | x <= y  |
## Escape Sequences
| Escape sequence | Character name                                                      | Unicode encoding                                                               |
| --------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------------------ |
| \\'             | Single quote                                                        | 0x0027                                                                         |
| \\"             | Double quote                                                        | 0x0022                                                                         |
| \|Backslash     | 0x005C                                                              |                                                                                |
| \0              | Null                                                                | 0x0000                                                                         |
| \a              | Alert                                                               | 0x0007                                                                         |
| \b              | Backspace                                                           | 0x0008                                                                         |
| \f              | Form feed                                                           | 0x000C                                                                         |
| \n              | New line                                                            | 0x000A                                                                         |
| \r              | Carriage return                                                     | 0x000D                                                                         |
| \t              | Horizontal tab                                                      | 0x0009                                                                         |
| \v              | Vertical tab                                                        | 0x000B                                                                         |
| \u              | Unicode escape sequence (UTF-16)                                    | `\uHHHH` (range: 0000 - FFFF; example: `\u00E7` = "ç")                         |
| \U              | Unicode escape sequence (UTF-32)                                    | `\U00HHHHHH` (range: 000000 - 10FFFF; example: `\U0001F47D` = "👽")            |
| \x              | Unicode escape sequence similar to "\u" except with variable length | `\xH[H][H][H]` (range: 0 - FFFF; example: `\x00E7` or `\x0E7` or `\xE7` = "ç") |
## Interview Questions and Answers practice
>Can `this` be 
>used in a static method?

>No. It references the current instance, and a static method does not belong to any particular instance.
---
> Different types of classes

> Partial - members can be divided or shared with multiple .cs files.
> Sealed - class cannot be inherited.
> Abstract - class whose object cannot be instantiated, only inherited. Should contain at least one method.
> Static - does not allow inheritance. Members of the class are static.
---
> difference between struct and class

> struct is a value type. Inherits from System.Value.
> Usually for smaller amounts of data
> Can't be inherited to another type.
> Can't be abstract.

> Class is ref type. Inherits from System.Object.
> Usually for larger amounts of data.
> Can be inherited.
> Can be abstract.
> Can create a default constructor.
---
> What is the virtual keyword for

> Use while defining a class to specify methods and props of class can be overridden in derived classes
--- 
> finally block

> used at the end of a try-catch-finally block, good for cleanup tasks such as disconnect from DB, or releasing file handlers.
---
> Use throw or throw ex to throw an exception.
> throw `ex` (where ex is the var from the catch block) will throw the exception and begin the output of the error at that exception, where throw will give you the whole stacktrace.

```csharp
try {
...
} catch(Exception ex){
throw ex;
// or just throw
}
```
---
> How would you reverse the order of a sentence?

>Reverse the whole string, then reverse each individual work. So reverse the string, then break the string into an array, each word being it's own element, and reverse each of them one at a time, then combine them back into a single string. Instead of an array, you could also just loop through the string and track the index of each space so you can find the start/end of each word, but coming from a more "javascript" approach, it's easier to break into an array and iterate through each element.
---
> Difference between == and Equals()

>== (Reference Equals) compares the ref identity while Equals (virtual equals) method compares if two objects are equivalent.
---
> Use of ??

> Null coalescing operator, defines a default value for nullable types or ref types. The code below will output "Evan" because name is null.
```csharp
string name = null;
string myname = name ?? "Evan";
Console.WriteLine(myname);
```
---
> 