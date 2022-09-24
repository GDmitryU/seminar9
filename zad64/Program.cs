// See https://aka.ms/new-console-template for more information
//Задача 64: Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа 
//в промежутке от M до N.
//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//M = 4; N = 8. -> ""4, 6, 7, 8""
int NaturalNumbers(int start, int finish)
{
    if (start == finish+1) return finish;
    else 
    Console.Write($"{start} ");
    start = start + 1;
    return NaturalNumbers(start, finish);
}


Console.Write("Введите начало интервала: ");
int start = int.Parse(Console.ReadLine());
Console.Write("Введите конец интервала: ");
int finish = int.Parse(Console.ReadLine());
if (start >= finish)
{
    Console.WriteLine("Неверно введены числа");
}
else
{
    Console.WriteLine($"Натуральные числа от {start} до {finish}: ");
    NaturalNumbers(start, finish);
}


