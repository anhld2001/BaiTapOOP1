// See https://aka.ms/new-console-template for more information
Console.WriteLine("Nhap vao so phan tu cua mang: ");
int n = int.Parse(Console.ReadLine());
int[] Mang = new int[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Nhap vao phan tu cua mang: ");
    Mang[i] = int.Parse(Console.ReadLine());
}
int Min = Mang[0];
for (int i = 0; i < n; i++)
    {
        if (Min > Mang[i])
        {
            Min = Mang[i];
        }
    }
Console.WriteLine("So be nhat la: " + Min);
Console.ReadKey();