// See https://aka.ms/new-console-template for more information
string Chuoi; //khai bao chuoi ban dau
string KyTu; //khai bao chuoi con can tim
int strt = 0;
int cnt = -1;
int idx = -1;

Console.Write("Nhap chuoi ban dau: ");
Chuoi = Console.ReadLine();
Console.Write("Nhap chuoi con can tim: ");
KyTu = Console.ReadLine();


while (strt != -1)
{
    strt = Chuoi.IndexOf(KyTu, idx + 1);
    cnt += 1;
    idx = strt;
}
Console.Write("Chuoi con '{0}' xuat hien " + cnt + " lan.\n", KyTu);

Console.ReadKey();
