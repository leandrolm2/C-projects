// See https://aka.ms/new-console-template for more information
var id = Guid.NewGuid();
string newGuidGenerated = id.ToString();

id = new Guid(newGuidGenerated);
if (id == Guid.NewGuid())
    Console.WriteLine(id.ToString().Substring(0,8));
Console.WriteLine(id);