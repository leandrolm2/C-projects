// See https://aka.ms/new-console-template for more information

//You must specify the array length
Console.Clear();
var  arr = new int[5] {1,2,3,4,5};
var employers = new Employer[5];
employers[0] = new Employer() { Id = 2934, Name = "Leandro"};

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}

//we can use foreach as well

foreach (var i in employers)
{
    Console.WriteLine(i.Id);
    Console.WriteLine(i.Name);
}

public struct Employer
{
    public int Id { get; set; }
    public string Name { get; set; }
}