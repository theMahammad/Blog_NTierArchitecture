using System.Text.RegularExpressions;
string pattern = @"^9\d+\S";
Regex regex = new(pattern);
string text = "914a50 92e 94 heç o ";
var a = regex.Matches(text);
Console.WriteLine();