// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Evaluating equality and inequality

Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");

// Using variable(just symbols) and string interpolation

string aFriend = "Joy";
Console.WriteLine($"Hello {aFriend}");

// working with strings

string firstFriend = "Nyokabi";
string secondFriend = "Imani";
Console.WriteLine($"Such beautiful friends like {firstFriend} and {secondFriend} are hard to find!");

// looking at length(.length) is a property of a string and returns the number of characters in that string

Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters!");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters!");

// white space matters in c# and below is an example hence Trim() method comes in handy.

string greeting =  "Hello Friend!" ;
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting =  greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting =  greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

// Using another method .Replace() to replace a string.

string sayHello =  "Hello Friend!" ;
Console.WriteLine(sayHello);

sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);

Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());

// this does not change the state of our variable.

// Search strings. This is the other part of search and replace methods.
// To search a string we can use the contains method to find out if the string contains a substring inside it.
// Contains method returns boolean

string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("prince"));
Console.WriteLine(songLyrics.Contains("hello"));

// instead of chaining methods within methods we could also use a variable to store our method

var searchString = (songLyrics.Contains("prince"));
var start = (songLyrics.StartsWith("You"));
var ends = (songLyrics.EndsWith("Aran"));
var end = (songLyrics.EndsWith("hello"));


Console.WriteLine(searchString);
Console.WriteLine(start);
Console.WriteLine(ends);
Console.WriteLine(end);


// NUMBERS in C#
// Manipulate integral and floating point numbers in c#

int a = 10;
int b = 100;
int c = a + b;
int d = c*a;
int e = a/b;
int f = a%b;
Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(e);
Console.WriteLine(f);

// exploring order of operations
// BODMAS
// C# follows a particular order of operations
// to specify your own order you can use parenthesis around the operation that you want to start with.

int g = a + b*d - b/d+a - c;
int h = a + b*d - b/(d+a) - c;

Console.WriteLine(g);
Console.WriteLine(h);

// integer division always produces an integer even when you expect result to contain a decimal or fraction
// int div = int result
// integer and number precision.

int i = 7;
int j = 4;
int k = 3;
int m = (i + j)/k;
int n = (i + j)%k;
Console.WriteLine($"quotient: {m}");
Console.WriteLine($"remainder: {n}");

int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max} inclusive");

//exceeding this limits is what we call underflow or overflow.

// working with double type
// the double numeric type represents a double-precision floating point number
// floating point number is useful to represent non-integral-numbers that may be very large or small in magnitude.
// double precision means that these numbers are stored using greater precision than single-precision

double o = 5;
double p = 4;
double q = 2;
double r = (o + p) / q;
Console.WriteLine(r);

// double values have a max and min which are greater than those for integers.

double maxs = double.MaxValue;
double mins = double.MinValue;
Console.WriteLine($"The range of doubles is {mins} to {maxs} inclusive");

// decimal data types
// decimal type has a smaller range but greater precision than doubles
// Fixed point means that, the decimal point (or binary point) doesn't move.

// when we divide a double we get a long remainder.

double s = 1.0;
double t = 3.0;
Console.WriteLine(s/t);

// which is different from when we say which is even longer indicating grater precision.
// includes an m suffix which indicates that a constant should use the decimal point.
decimal u = 1.0m;
decimal v = 3.0m ;
Console.WriteLine(u/v);

// there is also a long and a short type.

// finding the area of a circle
double radius = 2.5;
double area = (radius*radius)*Math.PI;
Console.WriteLine(area);


















