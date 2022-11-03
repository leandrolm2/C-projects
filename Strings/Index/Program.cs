// See https://aka.ms/new-console-template for more information
var text = "This text it is a test ";
var subString = "";

//The IndexOf can only find values of the same type that it is trying to find
Console.WriteLine(text.IndexOf("is"));

//Try to find the last index that the value as find inside the array
Console.WriteLine(text.LastIndexOf("s"));

Console.WriteLine(text.Insert(text.LastIndexOf("test") + 1, "okay"));
Console.WriteLine(text.Replace("a", "not a"));
Console.WriteLine(text.Length);

//Eliminate the white space at the begining and End of the string
Console.WriteLine(text.Trim());

//Will get the word text
subString = text.Substring(5, 5);
Console.WriteLine(subString);