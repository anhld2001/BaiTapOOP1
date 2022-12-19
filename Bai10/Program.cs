// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

Console.WriteLine("Nhap so luong sinh vien : ");
int n = int.Parse(Console.ReadLine());
string[] msv= new string[n];
for (int i= 0; i<n; i++)
{
    Console.WriteLine("Moi nhap vao ma sinh vien : ");
    msv[i] = Console.ReadLine();
}
for (int i = 0; i< n; i++)
{

    string a = msv[i];
    bool match;
    match = Regex.IsMatch(a, "^B[1][7][0][1-9]");
    if (msv[i].Length == 8)
    {
        if (match == true)
        {
            Console.WriteLine("Ma sinh vien " + a + " hop le");
        }
        else
        {
            Console.WriteLine("Ma sinh vien thu " + i + " khong hop le");
        }
    }
    else
        Console.WriteLine("Ma sinh vien " + i + " khong hop le");
    
}
Console.ReadKey();