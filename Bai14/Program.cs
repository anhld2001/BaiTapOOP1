// See https://aka.ms/new-console-template for more information
Console.WriteLine("Nhap vao so phan tu cua mang: ");
int n = int.Parse(Console.ReadLine());
int[] mang = new int[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Nhap vao phan tu cua mang: ");
    mang[i] = int.Parse(Console.ReadLine());
}
int[] tmp = new int[n];
for (int i = 0; i < n; i++)
{
    tmp[i] = mang[n-1-i];
}
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Phan tu thu " + (i + 1) + " cua mang la: " + mang[i]);
}
Console.ReadKey();
