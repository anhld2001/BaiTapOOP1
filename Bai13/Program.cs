// See https://aka.ms/new-console-template for more information
Console.WriteLine("Nhap vao so phan tu cua mang: ");
int n = int.Parse(Console.ReadLine());
int[] mang = new int[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Nhap vao phan tu cua mang: ");
    mang[i] = int.Parse(Console.ReadLine());
}
int min = 0;
for (int i = 0; i < n; i++)
    {
        if (min > mang[i])
        {
            min = mang[i];
        }
    }
Console.WriteLine("So be nhat la: " + min);
Console.ReadKey();