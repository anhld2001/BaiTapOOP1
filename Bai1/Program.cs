// See https://aka.ms/new-console-template for more information
using Bai1;

PhanSo ps = new PhanSo();
do
{
    Console.WriteLine("Nhap vao tu so 1");
    ps.tuSo1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Nhap vao mau so 1");
    ps.mauSo1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Nhap vao tu so 2");
    ps.tuSo2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Nhap vao mau so 2");
    ps.mauSo2 = int.Parse(Console.ReadLine());
}
while (ps.mauSo2 == 0 || ps.mauSo1 == 0);
float cong = ps.CongPS();
Console.WriteLine("Ket qua cong la: " + cong);
float tru = ps.TruPS();
Console.WriteLine("Ket qua tru la: " + tru);
float nhan = ps.NhanPS();
Console.WriteLine("Ket qua nhan la: " + nhan);
float chia = ps.ChiaPS();
Console.WriteLine("Ket qua chia ela: " + chia);
Console.ReadKey();

