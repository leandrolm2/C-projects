// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.Clear();
var date = new DateTime(2022,10,12,13,23,14);
var date2 = DateTime.Now;

//You can format data to better suit your neeeds, like use a diferent format from USA data.
var format = String.Format("{0:dd-MM-yyyy}", date2);

Console.WriteLine(format);
//Console.WriteLine(data2);

Console.WriteLine((int)date.DayOfWeek);

//you can also add and subtrat days by doing that:
Console.WriteLine(date.AddDays(14));

//compare date
//You can use the logic operators
if(date2.Date == DateTime.Now.Date)
{
    Console.WriteLine("The datetime are identical");
    Console.WriteLine(date2.Date);
}

// If you want the date to be formatted the same as a date from a specific region of the world, you can use CultureInfo
var pt = new CultureInfo("pt-PT"); 
var br = new CultureInfo("pt-BR");
var en = new CultureInfo("en-US");
var de = new CultureInfo("de-DE");

//If you use culture info, you will get the culture of the machine you are working on.
var now = CultureInfo.CurrentCulture;


Console.WriteLine(DateTime.Now.ToString("D",pt));
Console.WriteLine(DateTime.Now.ToString("D",br));
Console.WriteLine(DateTime.Now.ToString("D",en));
Console.WriteLine(DateTime.Now.ToString("D",de));


