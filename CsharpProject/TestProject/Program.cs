/*
string input = "Pad this";
 Console.WriteLine(input.PadLeft(12));
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));

string paymentId = "769C";
 string payeeName = "Mr. Stephen Ortega";
 string paymentAmount = "$5,000.00";

 var formattedLine = paymentId.PadRight(6);
 formattedLine += payeeName.PadRight(24);
 formattedLine += paymentAmount.PadLeft(10);

 Console.WriteLine("1234567890123456789012345678901234567890");
 Console.WriteLine(formattedLine); */

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

System.Console.WriteLine("Dear {1} \nAs a customer of our {0} offering we are excited to tell you about a new financial product that would dramataically increase your return.", currentProduct, customerName);
System.Console.WriteLine(($"\nCurrently, you own {currentShares} shares at a return of {currentReturn:P} \n Our new product, {newProduct} offers a return of {newReturn:P} given your current volume, your potential profit would be {newProfit:C}"));

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";
comparisonMessage += $"{currentProduct.PadRight(20)}{currentReturn:P}  {currentProfit:c}\n";
comparisonMessage += $"{newProduct.PadRight(20)}{newReturn:P}  {newProfit:c}";

Console.WriteLine(comparisonMessage);