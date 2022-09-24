// Задача 68: Напишите программу вычисления функции Аккермана 
//с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29
 
int Ackerman(int n, int m)
{
    int result;
    if (n == 0) 
        result= m + 1;
    else
    if ( m == 0) 
        result= Ackerman(n - 1,1 );
    else 
        result = Ackerman(n - 1, Ackerman(n, m - 1));
    return result;
}
Console.Write("Введите первое неотрицательное число: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите второе неотрицательное число: ");
int m = int.Parse(Console.ReadLine());
if (m < 0 || n < 0)
{
    Console.WriteLine("Неверно введены числа");
}
else
{
    Console.Write($"Значение функции Аккермана от {n} и {m} = ");
    Console.WriteLine(Ackerman(n, m));
}

