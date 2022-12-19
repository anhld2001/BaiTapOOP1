// See https://aka.ms/new-console-template for more information
Console.WriteLine("Nhap vao so n: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= 20; i++)
{
    int tich = i * n;
    Console.WriteLine("Tich la: " + tich);
}
Console.ReadKey();