// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

Console.WriteLine("Moi nhap vao ma sinh vien : ");
string msv = Console.ReadLine();
bool match;
match = Regex.IsMatch(msv, "^B[0-9]");
if (msv.Length == 8)
{
    if (match == true)
    {
        Console.WriteLine("Ma sinh vien hop le");
    }
    else
    {
        Console.WriteLine("Ma sinh vien " + msv + "khong hop le"); 
    }
}
else
    Console.WriteLine("Ma sinh vien khong hop le");
Console.ReadKey();