// See https://aka.ms/new-console-template for more information
using System.Globalization;
using Microsoft.VisualBasic;

// Print a simple message
Console.WriteLine("Hello, World!");      

// Variable declarations with different data types
int a = 20;                              // Integer variable 'a'
string b = "Sathwik";                    // String variable 'b'
float c = 10.3f;                         // Float variable 'c' (suffix 'f' required)
double d = 20.4444d;                     // Double variable 'd' (suffix 'd' optional)
char e = b[0];                           // Char variable 'e' taking first character of string 'b'

// Printing variables to the console
Console.WriteLine(a);                    // Print value of 'a'
Console.WriteLine(b);                    // Print value of 'b'
Console.WriteLine(c);                    // Print value of 'c'
Console.WriteLine(d);                    // Print value of 'd'
Console.WriteLine(e);                    // Print value of 'e'

// Declare multiple variables of the same type in a single line
int f = 20, g = 35;                      // Two integers 'f' and 'g'

// Arithmetic and comparison operations
Console.WriteLine(f + g);                // Print sum of f and g
Console.WriteLine(f > g);                // Print result of comparison f > g (Boolean)

// Taking user input and checking if it's greater than 100
Console.Write("Enter your value: ");     // Ask for user input
int Value = Convert.ToInt32(Console.ReadLine());  // Read input and convert to int
if (Value > 100)                         // Check if value is greater than 100
{
    Console.WriteLine(true);            // Print true if condition is met
}
else
{
    Console.WriteLine(false);           // Print false otherwise
}

// OTP verification using do-while loop
int ans;                                 // Declare variable for storing OTP
do
{
    Console.Write("Enter your otp: ");   // Ask for OTP
    ans = Convert.ToInt32(Console.ReadLine());    // Read OTP input

    if (ans != 1234)                     // Check if OTP is incorrect
    {
        Console.WriteLine("Wrong otp. Please try again.");  // Ask user to try again
    }

} while (ans != 1234);                   // Repeat until correct OTP is entered

Console.WriteLine("Correct otp!");       // Print success message when OTP is correct

// For loop from 10 to 20
for (int q = 10; q <= 20; q++)
{
    Console.WriteLine(q);                // Print numbers from 10 to 20
}

// Foreach loop with an array of integers
int[] numbers = { 1, 2, 3, 4, 5 };       // Declare an array
foreach (int num in numbers)
{
    Console.WriteLine(num);             // Print each element in the array
}

// String operations
string player_name = "Sathwik";         
Console.WriteLine(player_name[0]);      // Print first character of string
Console.WriteLine(player_name.Substring(0, 4)); // Print substring from index 0 to 3
Console.WriteLine(player_name.Length);  // Print length of the string
Console.WriteLine(player_name.ToUpper()); // Convert to uppercase
Console.WriteLine(player_name.ToLower()); // Convert to lowercase
Console.WriteLine(player_name.Replace('S', 's')); // Replace 'S' with 's'
Console.WriteLine(player_name);         // Print original string
Console.WriteLine(" " + player_name + " Pabba "); // Concatenate strings with spaces

// More string operations
string surname = " " + player_name + " Pabba ";
Console.WriteLine(surname.Trim());          // Remove leading/trailing spaces
Console.WriteLine(player_name.Contains('a')); // Check if 'a' exists in string
Console.WriteLine(surname.StartsWith(" ")); // Check if string starts with space
Console.WriteLine(surname.EndsWith('d'));   // Check if string ends with 'd'
Console.WriteLine(surname.IndexOf('a'));    // First index of 'a'
Console.WriteLine(surname.IndexOf("sat"));  // Index of "sat" (case-sensitive)
Console.WriteLine(surname.IndexOf("Sat"));  // Index of "Sat" (case-sensitive)
Console.WriteLine(surname.LastIndexOf("a")); // Last index of 'a'

// Search using multiple characters
char[] values = { 'a', 'b', 'c' };
Console.WriteLine(player_name.IndexOfAny(values)); // Index of any character from array

char[] characters = { 'a', 'k', 'w', 'i', 'S', 't', 'p' };
Console.WriteLine(player_name.LastIndexOfAny(characters)); // Last index of any character from array

// Splitting and joining strings
string Name = "Pabba Sathwik";
string[] parts = Name.Split();          // Split string by space
foreach (string part in parts)
{
    Console.WriteLine(part);            // Print each part (first name, last name)
}

string joined = string.Join(" ", parts); // Join parts back into a full name
Console.WriteLine(joined);               // Print the joined name

// Final outputs
Console.WriteLine("The end");            // Final message
Console.WriteLine("Welcome back to my project"); // Another message

// Another array and foreach loop
int[] answer = { 1, 2, 3, 4, 5 };       
foreach (int nums in answer)
{
    Console.WriteLine(nums);            // Print each element
}

// int[] i; // Declare an array of integers
// string[] b; // Declare an array of strings

int[] o = new int[5]; // Array size 5, default values: 0

int[] p = new int[] { 10, 20, 30, 40, 50 };
int[] l = { 10, 20, 30, 40, 50 };
foreach (int q in l)
{
    Console.WriteLine(q);
}



// Step 1: Declare the jagged array (3 rows)
int[][] jagged = new int[3][];

// Step 2: Initialize each row with different sizes
jagged[0] = new int[] { 1, 2 };           // 2 elements
jagged[1] = new int[] { 3, 4, 5 };        // 3 elements
jagged[2] = new int[] { 6, 7, 8, 9 };     // 4 elements

// Step 3: Access and print elements
for (int i = 0; i < jagged.Length; i++)
{
    Console.Write("Row " + i + ": ");
        for (int j = 0; j < jagged[i].Length; j++)
    {
        Console.Write(jagged[i][j] + " ");
    }
        Console.WriteLine();
}

/*

| Jagged Array                  | Multidimensional Array             |
| ----------------------------- | ---------------------------------- |
| `int[][]`                     | `int[,]`                           |
| Rows can have different sizes | All rows and columns are same size |
| Faster and memory efficient   | Simpler if rectangular data        |
| Uses `arr[i][j]`              | Uses `arr[i, j]`                   |

*/

// Another example of Jagged_array below //
int[][] jagged_array = new int[4][];
jagged_array[0] = new int[] { 100, 200, 300 };
jagged_array[1] = new int[] { 400, 500 };
jagged_array[2] = new int[] { 5600, 700, 800, 900 };
jagged_array[3] = new int[] { 1000 };

Console.WriteLine(jagged_array[0][1]);

// Multi-dimensional arrays //

// Declares a empty 2-D Arrays "int[,] u; "//

// Declares a 2-D Array with size: "int[,] array_2d = new int[2, 3];" //
int[,] x = { { 1, 2, 3 }, { 4, 5, 6 } };
Console.WriteLine(x[0, 1]);

int[,,] z = { { { 10, 20, 30 }, { 40, 50, 60 } }, { { 70, 80, 90 }, { 100, 110, 120 } } }; // 3-D array //
Console.WriteLine(z[1,1,2]);

foreach (int t in z)
{
    Console.WriteLine(t);
}

for (int kk = 0; kk < x.GetLength(0); kk++)    // 🧠 matrix.GetLength(0) → Rows //
{
    for (int nn = 0; nn < x.GetLength(1); nn++)  // 🧠 matrix.GetLength(1) → Columns //
    {
        Console.WriteLine(x[kk, nn]);
    }
}

// Arrays Methods //

int[] yy = { 1, 2, 4, 6, 2, 4, 5 };

// Reverse the array
Array.Reverse(yy);  // Modifies 'yy' directly

// Print the reversed array
foreach (int num in yy)
{
    Console.Write(num + " ");
}
Console.WriteLine(" ");

// Sort the array
Array.Sort(yy);    // Modifies 'yy' directly

// Print the sorted array
foreach (int num in yy)
{
    Console.Write(num + " ");
}
Console.WriteLine(" ");

Console.WriteLine("Sorted Array");