/*
 switch(выражение)
{
    case const1:
        последовательность операторов
    break;

    case const2:
        последовательность операторов
    break;

    case const3:
        последовательность операторов
    break;

    ...
    default:
        последовательность операторов
    break;
}
 */

int a = Convert.ToInt32(Console.ReadLine());

switch (a)
{
    case 1:
    case 2:
        Console.WriteLine("Vi vveli chislo 1 ili");
        Console.WriteLine("Vi vveli chislo 2");
        break;
    default:
        Console.WriteLine("Vi vveli neizvestnoe chislo");
        break;
}

Console.ReadKey();