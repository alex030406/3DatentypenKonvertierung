using System;
using System.Reflection.Metadata;

string a = "Hallo"; 
string b = "H";
b += "allo";

Console.WriteLine(b);

Console.WriteLine(b.Length);

Console.WriteLine(a == b);

Console.WriteLine((object)a == b);

double x = 2.0;

double y = x * x + 1 + x / 4;

double x1 = 2.0; 

double y1 = x * (x + 1 + x / 4);

bool b1 = true && false || 5 > 6;

int z = 50; bool numeric = z > 47 && z < 58;

Console.WriteLine(x);
Console.WriteLine(x1);
Console.WriteLine(y);
Console.WriteLine(y1);
Console.WriteLine(b1);
Console.WriteLine(z);
