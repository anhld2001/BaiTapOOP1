// See https://aka.ms/new-console-template for more information
int n;
Console.WriteLine("Nhap so nguyen n : ");
n = int.Parse(Console.ReadLine());
int[] Fi = new int[n+1];
Fi[0] = 1;
Fi[1] = 1;
for(int i = 2; i <= n;i++)
{
    Fi[i] = Fi[i - 1] + Fi[i - 2]; 
}
int a = Fi[n];
Console.WriteLine("So Fibonaci tuong ung la : " + a);
Console.ReadKey();