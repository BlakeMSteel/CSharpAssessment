using System;
//1.1
var a = 0;
var b = true;
var c = "Wow";
double d = 3.2;
decimal e = 3.2M;
//1.2
public string Wow(string x, double y)
{
    return $"I have {y} {x}s.";
}
//1.3
Console.WriteLine(Wow(c, d));
//1.4
var friends = new string[] { "Me", "Gregory", "Me again", "Sydney", "Me once more"};
//1.5
foreach (var friend in friends)
{
    Console.WriteLine(friend);
}
