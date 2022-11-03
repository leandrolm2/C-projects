// See https://aka.ms/new-console-template for more information
using System.Text;

//When you create a variable and trying to manipulate them, you only get a copy of it and not the real variable.
//This can cause memory issues, so to avoid that we have the StringBuilder.
var text = new StringBuilder();

text.Append("This text it is a test");
text.Append("you can be");
text.Append("sure about");
text.Append("that");

Console.WriteLine( text.ToString() );
