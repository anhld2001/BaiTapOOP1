// See https://aka.ms/new-console-template for more information
bool Check = false;
do
{
    Console.WriteLine("Nhap vao so phan tu cua mang: ");
    int n = int.Parse(Console.ReadLine());
    int[] Mang = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Nhap vao phan tu cua mang: ");
        Mang[i] = int.Parse(Console.ReadLine());
        if (Mang[i] <= 0)
        {
            Console.WriteLine("Phan tu phai la so duong");
            Check = true;
            break;
        }
        else
            Check= false;
    }
    int Max = Mang[0];
    if(Check == false)
    {
        for (int i = 0; i < n; i++)
        {
            if (Max < Mang[i])
            {
                Max = Mang[i];
            }
        }
        Console.WriteLine("So lon nhat la: " + Max);
    }    
}
while (Check == true);
Console.ReadKey();

