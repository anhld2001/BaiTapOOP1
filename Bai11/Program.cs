// See https://aka.ms/new-console-template for more information
int n;
Console.WriteLine("Nhap vao so phan tu cua mang");
n = int.Parse(Console.ReadLine());
int[] Mang = new int[n];
int Tong = 0;
for (int i = 0; i< n; i++)
{
    Console.WriteLine("Nhap phan tu thu " + (i + 1) +" : ");
    Mang[i] = int.Parse(Console.ReadLine());
    Tong = Tong + Mang[i];
}
Console.WriteLine("Tong la: " + Tong);
Console.ReadKey();

