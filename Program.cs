// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
int a = 20;
string b = "Sathwik";
float c = 10.3f;
double d = 20.4444d;
char e = b[0];
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(e);
int f = 20, g = 35;
Console.WriteLine(f + g);
Console.WriteLine(f > g);
Console.Write("Enter your value: ");
int Value = Convert.ToInt32(Console.ReadLine());
if (Value > 100)
{
    Console.WriteLine(true);
}
else
{
    Console.WriteLine(false);
}


int ans;

do
{
    Console.Write("Enter your otp: ");
    ans = Convert.ToInt32(Console.ReadLine());

    if (ans != 1234)
    {
        Console.WriteLine("Wrong otp. Please try again.");
    }

} while (ans != 1234);

Console.WriteLine("Correct otp!");

for (int q = 10; q <= 20; q++)
{
    Console.WriteLine(q);
}

int[] numbers = { 1, 2, 3, 4, 5 };
foreach (int num in numbers)
{
    Console.WriteLine(num);
}
string player_name = "Sathwik";
Console.WriteLine(player_name[0]);
Console.WriteLine(player_name.Substring(0, 4));
Console.WriteLine(player_name.Length);
Console.WriteLine(player_name.ToUpper());
Console.WriteLine(player_name.ToLower());
Console.WriteLine(player_name.Replace('S', 's'));
Console.WriteLine(player_name);
Console.WriteLine(" " + player_name + " Pabba ");
string surname = " " + player_name + " Pabba ";
Console.WriteLine(surname.Trim());
Console.WriteLine(player_name.Contains('a'));
Console.WriteLine(surname.StartsWith(" "));
Console.WriteLine(surname.EndsWith('d'));
Console.WriteLine(surname.IndexOf('a'));
Console.WriteLine(surname.IndexOf("sat"));
Console.WriteLine(surname.IndexOf("Sat"));
Console.WriteLine(surname.LastIndexOf("a"));
char[] values = { 'a', 'b', 'c' };
Console.WriteLine(player_name.IndexOfAny(values));
char[] characters = { 'a', 'k', 'w', 'i', 'S', 't', 'p' };
Console.WriteLine(player_name.LastIndexOfAny(characters));
string Name = "Pabba Sathwik";
string [] parts = Name.Split();
foreach (string part in parts)
{
    Console.WriteLine(part);
}

string joined = string.Join(" ", parts);
Console.WriteLine(joined);



Console.WriteLine("The end");

