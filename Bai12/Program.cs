// See https://aka.ms/new-console-template for more information
bool check = false;
do
{
    Console.WriteLine("Nhap vao so phan tu cua mang: ");
    int n = int.Parse(Console.ReadLine());
    int[] mang = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Nhap vao phan tu cua mang: ");
        mang[i] = int.Parse(Console.ReadLine());
        if (mang[i] <= 0)
        {
            Console.WriteLine("Phan tu phai la so duong");
            check = true;
            break;
        }
        else
            check= false;
    }
    int max = 0;
    if(check == false)
    {
        for (int i = 0; i < n; i++)
        {
            if (max < mang[i])
            {
                max = mang[i];
            }
        }
        Console.WriteLine("So lon nhat la: " + max);
    }    
}
while (check == true);
Console.ReadKey();

