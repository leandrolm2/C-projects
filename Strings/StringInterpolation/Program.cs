// See https://aka.ms/new-console-template for more information
var price = 10.2;
var text1 = "The product price is " + price + " Today only!";
var text2 = string.Format("The product price is {0} today only!", price);
var text3 = $"The product price is {price} today only!";

Console.WriteLine(text1);
Console.WriteLine(text2);
Console.WriteLine(text3);