// See https://aka.ms/new-console-template for more information

Console.WriteLine("Nhap vao so n: ");
int n = int.Parse(Console.ReadLine());
int tong = 0;
for (int i = 0; i <= n; i++)
{
    int d = i % 2;
    if (d == 0)
        tong = tong + i;
}
Console.WriteLine("Tong la: " + tong);
Console.ReadKey();