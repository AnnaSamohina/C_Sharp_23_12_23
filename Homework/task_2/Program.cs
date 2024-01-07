//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

int x = int.Parse(Console.ReadLine()!);
int y = int.Parse(Console.ReadLine()!);

    if (x == 0 || y == 0)
        {Console.WriteLine("не может быть == 0.");}
        else
            if (x > 0 && y > 0)
                 {Console.WriteLine("ч1");}
        else
            if (x < 0 && y > 0)
                    {Console.WriteLine("ч2.");}
        else
            if (x < 0 && y < 0)
                    {Console.WriteLine("ч3");}
        else
            if (x > 0 && y < 0)
                    {Console.WriteLine("ч4");}