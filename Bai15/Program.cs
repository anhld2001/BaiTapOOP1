// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

string[] Ms = new string[5];
bool Match;

for(int i = 0; i < 5; i++)
{
    Console.WriteLine("Moi nhap vao ma: ");
    Ms[i] = Console.ReadLine();
    if (Ms[i].Length == 8)
    {
        Match = Regex.IsMatch(Ms[i], "[0][0][2-5][L][0-9]");
        if(Match == true)
        {
            Console.WriteLine("Dung roi");
        }
        else
        {
            Console.WriteLine("Sai roi");
            Environment.Exit(0);
            Console.ReadKey();
        }
    }
    else
    {
        Console.WriteLine("Sai roi");
        Environment.Exit(0);
        Console.ReadKey();

    }
}

