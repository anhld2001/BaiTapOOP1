// See https://aka.ms/new-console-template for more information
using Bai1;

PhanSo ps1 = new PhanSo();
PhanSo ps2 = new PhanSo();
do
{
    Console.WriteLine("Nhap vao tu so 1");
    ps1.tuSo = int.Parse(Console.ReadLine());
    Console.WriteLine("Nhap vao mau so 1");
    ps1.mauSo = int.Parse(Console.ReadLine());
    Console.WriteLine("Nhap vao tu so 2");
    ps2.tuSo = int.Parse(Console.ReadLine());
    Console.WriteLine("Nhap vao mau so 2");
    ps2.mauSo = int.Parse(Console.ReadLine());
}
while (ps1.mauSo == 0 || ps2.mauSo == 0);
float cong = (ps1.tuSo * ps2.mauSo + ps2.tuSo * ps1.mauSo) / (ps1.mauSo * ps2.mauSo);
Console.WriteLine("Ket qua cong la: " + cong);
float tru = float cong = (ps1.tuSo * ps2.mauSo - ps2.tuSo * ps1.mauSo) / (ps1.mauSo * ps2.mauSo);
Console.WriteLine("Ket qua tru la: " + tru);
float nhan = float cong = (ps1.tuSo * ps2.tuSo) / (ps1.mauSo * ps2.mauSo);
Console.WriteLine("Ket qua nhan la: " + nhan);
float chia = float cong = (ps1.tuSo * ps2.mauSo) / (ps2.tuSo * ps1.mauSo);
Console.WriteLine("Ket qua chia ela: " + chia);
Console.ReadKey();

