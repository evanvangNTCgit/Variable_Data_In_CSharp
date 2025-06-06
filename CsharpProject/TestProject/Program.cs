/*
string message = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message}");
char[] openSymbols = { '[', '{', '(' };
int startPosition = 5;
int openingPosition = message.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

openingPosition = message.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");
*/
/*
string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);
*/
/*
string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);
*/

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
int spanIndex = input.IndexOf("<span>") + 6;
int spanClosingIndex = input.IndexOf("</span>");
quantity = input.Substring(spanIndex, (spanClosingIndex - spanIndex));



Console.WriteLine(quantity);
Console.WriteLine(output);