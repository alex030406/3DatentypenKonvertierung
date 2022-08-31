//Aufgabe 1
Console.WriteLine("Short:");
Console.WriteLine(short.MinValue);
Console.WriteLine(short.MaxValue);

Console.WriteLine("Integer:");
Console.WriteLine(int.MinValue);
Console.WriteLine(int.MaxValue);

Console.WriteLine("Long:");
Console.Write(long.MinValue); 
Console.WriteLine(long.MaxValue);

Console.WriteLine("Float:");
Console.WriteLine(float.MinValue);
Console.WriteLine(float.MaxValue);

Console.WriteLine("Double:");
Console.WriteLine(double.MinValue);
Console.WriteLine(double.MaxValue);

Console.WriteLine("Decimal:");
Console.Write(decimal.MinValue);
Console.WriteLine(decimal.MaxValue);

//Aufgabe 2
bool erste = true;
string vorname = "Alexander";
short alter = 16;

Console.WriteLine("Erste Pogrammiersprache:{0}",erste);
Console.WriteLine("Vorname:{0}",vorname);
Console.WriteLine("Alter:{0}",alter);

//Aufgabe 3
int DollarZahl = 36;
char Dollar = (char)DollarZahl;


//Aufgabe 4
string value1 = Console.ReadLine();
string value2 = Console.ReadLine();

short short_number = Convert.ToInt16(value1);
double double_number = Convert.ToDouble(value2);

Console.WriteLine("Konvertiert:{0}",short_number); 
Console.WriteLine("Konvertiert:{0}",double_number);