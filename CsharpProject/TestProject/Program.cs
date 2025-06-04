/*
string[] values = { "12.3", "45", "ABC", "11", "DEF" };
string message = "";
decimal total = 0;

foreach (var str in values)
{
    decimal currentstr;
    if (decimal.TryParse(str, out currentstr))
    {
        total += currentstr;
    }
    else
    {
        message += str;
    }
}

System.Console.WriteLine($"\n Message: {message} \n Total: {total}");
*/

int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = (int)Math.Round(value1 / value2);
// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3;
// Your code here to set result2
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / (float)value1;
// Your code here to set result3
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");