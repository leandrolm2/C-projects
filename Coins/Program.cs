// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.Clear();

decimal valor = 10.27m;

Console.WriteLine(valor);

//Convert the value to the currency of the country you specify
Console.WriteLine(
    valor.ToString(
        "C",
        CultureInfo.CreateSpecificCulture("pt-BR")
    )
);

//You can round the number
Console.WriteLine(Math.Round(valor));
Console.WriteLine(Math.Ceiling(valor));
Console.WriteLine(Math.Floor(valor));