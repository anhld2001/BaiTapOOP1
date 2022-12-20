// See https://aka.ms/new-console-template for more information
string Chuoi;
string KyTu;
Console.WriteLine("Moi nhap chuoi: ");
Chuoi= Console.ReadLine();
Console.WriteLine("Moi nhap ky tu: ");
KyTu= Console.ReadLine();
bool Match = Chuoi.Contains(KyTu);
if (Match == true)
{
    Console.WriteLine("Co");
}
else
    Console.WriteLine("Khong");
Console.ReadKey();
