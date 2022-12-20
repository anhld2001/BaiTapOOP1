// See https://aka.ms/new-console-template for more information
string Chuoi;
string KyTu;
Console.WriteLine("Moi nhap chuoi: ");
Chuoi = Console.ReadLine();
Console.WriteLine("Moi nhap ky tu: ");
KyTu = Console.ReadLine();
int Position = Chuoi.IndexOf(KyTu);
if(Position == -1)
{
    Console.WriteLine("Phan tu khong ton tai trong chuoi");
}
else
    Console.WriteLine("Phan tu xuat hien o vi tri thu: " + (Position +1) );
Console.ReadKey();
