////  Тема 20 урок 3

//Console.WriteLine("Введите число");
//long a= long.Parse(Console.ReadLine());
//Console.WriteLine("выберите операцию:\n[1] - логическое сложение \n[2] - логическое умножение \n[3] - шифрование\n[4] - инверсия");
//int n= int.Parse(Console.ReadLine());
//long Func(long x,long y)
//{
//    long result=0;
//    switch (y)
//    {
//        case 1:
//            {
//                result = x | x;
//            }
//            break;
//            case 2:
//            {
//                result = x & x;
//            }
//            break;
//            case 3:
//            {
//                Console.WriteLine("Введите ключ");
//                int key= int.Parse(Console.ReadLine());
//                result = x >> key;
//            }
//            break;
//            case 4:
//            {
//                result = ~x;
//            }
//            break;
//    }
//    return result;
//}

//Console.WriteLine(Func(a,n));


// Тема 20 урок 4

Random random = new Random();
int[,] mas1 = new int[4, 4];
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        mas1[i,j]=random.Next(-50,51);
        Console.Write(mas1[i,j]+" ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int[,] mas2 = new int[4, 4];
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        mas2[i, j] = random.Next(-50, 51);
        Console.Write(mas2[i, j]+" ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine();
long max=long.MinValue;
void SLozh(int[,]mas1,int[,] mas2, ref long max)
{
    int [,]mas3 = new int[4,4];
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            mas3[i, j] = mas1[i, j] + mas2[i,j];
            if (mas3[i,j]>max) max = mas3[i,j];
            Console.Write(mas3[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("Максимальное число = "+ max);
}

SLozh(mas1, mas2,ref max);
