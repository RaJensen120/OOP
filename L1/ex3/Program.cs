// See https://aka.ms/new-console-template for more information

Console.WriteLine("Input size of pyramid: ");
int size = Int32.Parse(Console.ReadLine());
//int size = 5;

for (int i = 1; i < size + 1; i++)
{
    for (int j = 1; j < i + 1; j++)
    {

        //chars.Add('*');
        Console.Write("*");
    }
    Console.WriteLine();
}

for (int i = size; i > 0 ; i--)
{
    for (int j = 0; j < i ; j++)
    {

        //chars.Add('*');
        Console.Write("*");
    }
    Console.WriteLine();
}

