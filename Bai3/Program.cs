// See https://aka.ms/new-console-template for more information
Console.WriteLine("Moi nhap vao so thu nhat : ");
float a  = float.Parse(Console.ReadLine());
Console.WriteLine("Moi nhap vao so thu 2: ");
float b = float.Parse(Console.ReadLine());
Console.WriteLine("Moi nhap vao si thu 3: ");
float c = float.Parse(Console.ReadLine());
if (a + b > c && a + c > b && b + c > a)
{
    Console.WriteLine("Day la 3 canh cua 1 tam giac ");
}
else
    Console.WriteLine("Day khong phai 3 canh cua 1 tam giac");
