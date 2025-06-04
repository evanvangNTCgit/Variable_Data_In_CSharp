string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderList = orderStream.Split(",");

foreach (var str in orderList)
{
    if (str.Length != 4)
    {
        System.Console.WriteLine($"{str} -- Error");
    }
    else
    {
        System.Console.WriteLine(str);
    }
}