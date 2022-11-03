// See https://aka.ms/new-console-template for more information

var text = "Testing";
var text2 = "This text it is a test"
//Return an integer as a result, 0 to true and 1 to false
Console.WriteLine(text.CompareTo("Testing"));
Console.WriteLine(text.CompareTo("testing"));


//Return a booleans as an answear
Console.WriteLine(text.Contains("Testing"));
Console.WriteLine(text.Contains("testing"));

//Ignore case sensitive
Console.WriteLine(text.Contains("testing", StringComparison.OrdinalIgnoreCase));

//Verify if the first word of the sting finishe with the same string that was passed
Console.WriteLine(text2.StartsWith("This"));
Console.WriteLine(text2.StartsWith("this"));
Console.WriteLine(text2.StartsWith("Text"));

//Verify if the last word of the sting finishe with the same string that was passed
Console.WriteLine(text2.EndsWith("Test"));
Console.WriteLine(text2.EndsWith("test"));
Console.WriteLine(text2.EndsWith("Xland"));

//checks if the object passed it is identical the one comparing
Console.WriteLine(text2.Equals("This text it is a test"));
Console.WriteLine(text2.Equals("this text it is a test"));
Console.WriteLine(text2.Equals("This text it a test"));
