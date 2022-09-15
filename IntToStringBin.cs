void IntToBinary(int x)
{
    char[] buff = new char[32];

    for (int i = 0; i < 32; i++)
    {
        int mask = 1 << i;
        buff[31 - i] = (x & mask) != 0 ? '1' : '0'; ;
    }
    Console.WriteLine(new string(buff));
}

IntToBinary(int.MaxValue);
Console.ReadKey();

//Игорь Осипов
//15.09.2022
//15 минут
