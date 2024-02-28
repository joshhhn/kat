int food = 6;
Random r = new Random();
int x = 0;
int y = 0;

string[,] house = new string[20, 20];

for(int j = 0; j < house.GetLength(0); j++)
{
    for (int k = 0; k < house.GetLength(1); k++)
    {


        house[j, k] = "-";
    }
}

for(int i = 0; i < food; i++)
{
    int replace = r.Next(20);
    int replace2 = r.Next(20);
    house[replace, replace2] = "A";
}

while(true)

    {

    if (food == 0)
    {
        break;
    }

    for (int j = 0; j < house.GetLength(0); j++)
    {
        for (int i = 0; i < house.GetLength(1); i++)
        {

            Console.Write($"{house[j, i]} ");


        }
        Console.WriteLine();
    }

    Console.WriteLine($"Food left: {food}");

    ConsoleKeyInfo key = Console.ReadKey();
    string sel = key.KeyChar.ToString();

    if (house[x, y] == "A")
    {
        food--;

    }
    else

        house[x, y] = "-";
    switch(sel)
    {
        case "w":
            x--;
            
            break;
        case "a":
            y--; 
            
            break;
        case "s":
            x++;
 
            break;
        case "d":
            y++;
            
            break;

 
    }
    if (house[x, y] == "A")
    {
        food--;
        house[x, y] = ":3";
    }
    else { house[x, y] = ":3"; }







    

    Console.Clear();

}

Console.WriteLine("Grattis!");