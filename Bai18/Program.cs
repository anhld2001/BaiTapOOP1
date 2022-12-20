// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

string Chuoi;
Console.WriteLine("Moi nhap chuoi: ");
Chuoi = Console.ReadLine();
bool Match = Regex.IsMatch(Chuoi, "[0-9]");
if (Match == true)
{
    Console.WriteLine("Co");
}
else
    Console.WriteLine("Khong");
Console.ReadKey();
