// See https://aka.ms/new-console-template for more information

// This is my Learing Progressing For C# it was all on gitHub and separte but I change My mind
// and put them all into one Cs file.

//This is my first C# program I hope you enjoy it on reagular outputs.
Console.WriteLine(" The Apple OS Sucks ");
Console.WriteLine("It Really dose it is so trash");
/* I dont care if that made you mad I really do not care
 * and also Windows rules. */
Console.WriteLine("My name is DarthManny");
//Speacial commands to tab or backspace
Console.WriteLine("\tManny is the best");//tab 
Console.WriteLine("M\banny is th worst");//backspace
Console.WriteLine("\nThis world is wonderful");//newline
Console.WriteLine("\aYou are getting an alert");//bell(alert) this also plays after the Beep
Console.WriteLine("\fWhat are you doing");//Form Feed dunno what this dose
Console.WriteLine("\vNothing but the sky");//vertial tab same with this
Console.Beep();

//Start of int Demo
// Int can only be whole numbers


int a = 23;
int x = 21;
int y = a + x;
int z = 45;
int w = 67;
int d = z * w;

// Here I am adding Ints 
Console.WriteLine(a);
Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);
Console.WriteLine(w);
Console.WriteLine(d);
// Here I demstright doubles which are decimal and chars which are single charaters and bools
// Which can only be read in true or flase and strings as well.
int year = 2023;
int age = 16;
double height = 123.5;
bool dead = false;
char symbol = '#';
String name = "DarthManny";
String userName = symbol + name;
String password = "None of your wax";
String birthday = "June 1 2006";
int month = 06;
String eyecolor = "blue";


// Now time to combine what I wrote This is gonna be cool

Console.WriteLine("Hello I am " + name);
Console.WriteLine("The Year is " + year);
Console.WriteLine("Am I alive " + dead);
Console.WriteLine("My height is " + height + "cm");
Console.WriteLine("My Gamertag is: " + userName);
Console.WriteLine("The Pc UserNames is " + userName + " and the Password is " + password);
Console.WriteLine("I was born on " + birthday);
// This Code Will be a demo to constants are stuff that do not change for the life of the program

const double pi = 3.14159;
const int c = 345;
const double g = c + pi;


Console.WriteLine(pi);
Console.WriteLine(c);
Console.WriteLine(g);



Console.ReadKey();