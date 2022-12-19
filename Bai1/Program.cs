// See https://aka.ms/new-console-template for more information
using Bai1;

PhanSo ps1 = new PhanSo();
PhanSo ps2 = new PhanSo();
do
{
    Console.WriteLine("Nhap vao tu so 1");
    ps1.TuSo = int.Parse(Console.ReadLine());
    Console.WriteLine("Nhap vao mau so 1");
    ps1.MauSo = int.Parse(Console.ReadLine());
    Console.WriteLine("Nhap vao tu so 2");
    ps2.TuSo = int.Parse(Console.ReadLine());
    Console.WriteLine("Nhap vao mau so 2");
    ps2.MauSo = int.Parse(Console.ReadLine());
}
while (ps1.MauSo == 0 || ps2.MauSo == 0);
float TuCong = (ps1.TuSo * ps2.MauSo + ps2.TuSo * ps1.MauSo);
float MauCong = (ps1.MauSo * ps2.MauSo);
Console.WriteLine("Ket qua cong la: " + TuCong + "/" + MauCong);
float TuTru = (ps1.TuSo * ps2.MauSo - ps2.TuSo * ps1.MauSo);
float MauTru = (ps1.MauSo * ps2.MauSo);
Console.WriteLine("Ket qua tru la: " + TuTru + "/" + MauTru);
float TuNhan = (ps1.TuSo * ps2.TuSo);
float MauNhan = (ps1.MauSo * ps2.MauSo);
Console.WriteLine("Ket qua nhan la: " + TuNhan + "/" + MauNhan);
float TuChia = (ps1.TuSo * ps2.MauSo);
float MauChia = (ps2.TuSo * ps1.MauSo);
Console.WriteLine("Ket qua chia la: " + TuChia + "/" + MauChia);
Console.ReadKey();

