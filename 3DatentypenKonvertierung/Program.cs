//Aufgabe 1
Console.WriteLine(short.MinValue);
Console.WriteLine(short.MaxValue);  
  
Console.WriteLine(int.MinValue);
Console.WriteLine(int.MaxValue);

Console.Write(long.MinValue); 
Console.WriteLine(long.MaxValue);

Console.WriteLine(float.MinValue);
Console.WriteLine(float.MaxValue);

Console.WriteLine(double.MinValue);
Console.WriteLine(double.MaxValue);

Console.Write(decimal.MinValue);
Console.WriteLine(decimal.MaxValue);

//Aufgabe 2
bool erste = true;
string vorname = "Alexander";
short alter = 16;

Console.WriteLine(erste);
Console.WriteLine(vorname);
Console.WriteLine(alter);

//Aufgabe 3
int DollarZahl = 36;


//Aufgabe 4
string value1 = Console.ReadLine();
string value2 = Console.ReadLine();

short short_number = Convert.ToInt16(value1);
double double_number = Convert.ToDouble(value2);

Console.WriteLine((short)short_number); 
Console.WriteLine((double)double_number);