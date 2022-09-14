//Aufgabe 1

Console.WriteLine("Bitte geben Sie die erste Zahl ein:");
string input1= Console.ReadLine();
Console.WriteLine("Bitte geben Sie die zweite Zahl ein:");
string input2 = Console.ReadLine();

int input11 = Convert.ToInt32(input1);
int input22 = Convert.ToInt32(input2);

if (input11 > input22)

Console.WriteLine(input22);


 else 

    Console.WriteLine(input11);

//Aufgabe 2

Random random = new Random();
int randomNumber = random.Next(0, 1000);

Console.WriteLine("Bitte geben Sie die Zahl ein:");
string guess = Console.ReadLine();

int guessint = Convert.ToInt16(guess);

if (guessint > randomNumber) { 
    Console.WriteLine("zu hoch");
Console.WriteLine("Die richtige Zahl war: {0}", randomNumber);

}


else


    Console.WriteLine("zu niedrig");
    Console.WriteLine("Die richtige Zahl war: {0}", randomNumber);
//Aufgabe 3



//Aufgabe 4

    Console.WriteLine("Bitte geben Sie die erste Zahl ein:");
    string Eingabe1 = Console.ReadLine();
    Console.WriteLine("Bitte geben Sie die zweite Zahl ein:");
    string Eingabe2 = Console.ReadLine();
    Console.WriteLine("Was möchten Sie berechnen?");

    Console.WriteLine("1.Addition");
    Console.WriteLine("2.Subtraktion");
    Console.WriteLine("3.Multiplikation");
    Console.WriteLine("4.Division");
    Console.WriteLine("5.Potenz");

    string Eingabe3 = Console.ReadLine();
    int Eingabe3int = Convert.ToInt32(Eingabe3);

    int Eingabe2int = Convert.ToInt32(Eingabe2);

    int Eingabe1int = Convert.ToInt32(Eingabe1);
    
    if (Eingabe3int == 1)
    Console.WriteLine("Das Ergebnis ist: {0}",Eingabe1int + Eingabe2int);

    if (Eingabe3int == 2)
    Console.WriteLine("Das Ergebnis ist: {0}", Eingabe1int - Eingabe2int);

    if (Eingabe3int == 3)
    Console.WriteLine("Das Ergebnis ist: {0}", Eingabe1int * Eingabe2int);

    if (Eingabe3int == 4)
    Console.WriteLine("Das Ergebnis ist: {0}", Eingabe1int / Eingabe2int);

if (Eingabe3int == 5) {

    double x = Math.Pow(Eingabe1int, Eingabe2int);
    Console.WriteLine("Das Ergebnis ist: {0}",x);

}


