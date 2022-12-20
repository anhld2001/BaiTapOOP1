// See https://aka.ms/new-console-template for more information
Console.WriteLine("Nhap vao so phan tu cua mang: ");
int n = int.Parse(Console.ReadLine());
int[] Mang = new int[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Nhap vao phan tu cua mang: ");
    Mang[i] = int.Parse(Console.ReadLine());
}
int[] Tmp = new int[n];
for (int i = 0; i < n; i++)
{
    Tmp[i] = Mang[n-1-i];
}
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Phan tu thu " + (i + 1) + " cua mang la: " + Tmp[i]);
}
Console.ReadKey();
