// See https://aka.ms/new-console-template for more information
int n;
Console.WriteLine("Nhap vao so phan tu cua mang");
n = int.Parse(Console.ReadLine());
int[] mang = new int[n];
int tong = 0;
for (int i = 0; i< n; i++)
{
    Console.WriteLine("Nhap phan tu thu " + (i + 1) +" : ");
    mang[i] = int.Parse(Console.ReadLine());
    tong = tong + mang[i];
}
Console.WriteLine("Tong la: " + tong);
Console.ReadKey();

