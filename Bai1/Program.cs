// See https://aka.ms/new-console-template for more information
Console.WriteLine("Nhap vao so nguyen");
int n = int.Parse(Console.ReadLine());
if (n < 0)
{
    Console.WriteLine("Day la so duong");
}
else
{
    Console.WriteLine("Day la so am");
}
Console.ReadKey();