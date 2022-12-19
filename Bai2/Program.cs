// See https://aka.ms/new-console-template for more information
using Bai2;

double n;
Console.WriteLine("Moi nhap vao so: ");
n = Convert.ToDouble(Console.ReadLine());
ChangeToText num = new ChangeToText();
string chu = num.Change(n);
Console.WriteLine(chu);
Console.ReadKey();
