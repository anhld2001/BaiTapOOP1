// See https://aka.ms/new-console-template for more information
using Bai3;


Student cn = new Student();
int choose;

do
{
    Console.WriteLine("Moi chon chuc nang :");
    Console.WriteLine("/**********************************************/");
    Console.WriteLine("1. Add a student.");
    Console.WriteLine("2. Edit student by id.");
    Console.WriteLine("3. Delete student by id.");
    Console.WriteLine("4. Sort students by gpa.");
    Console.WriteLine("5. Sort students by name.");
    Console.WriteLine("6. Show students.");
    Console.WriteLine("0. Exit");
    choose = int.Parse(Console.ReadLine());
    switch (choose)
    {
        case 1:
            cn.Nhap();
            break;
        case 2:
            cn.Sua();
            break;
        case 3:
            cn.Xoa();
            break;
        case 4:
            cn.SortByGPA();
            break;
        case 5:
            cn.SortByName();
            break;
        case 6:
            cn.hienThi();
            break;
        case 0:
            System.Environment.Exit(0);
            break;
    }
}
while (choose >= 0 && choose <= 6);
Console.ReadKey();