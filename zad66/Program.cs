// Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов 
//в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
int SumNaturalNumbers(int start, int finish)
{
    if (start == finish) return start;
    else return finish + SumNaturalNumbers(start, finish - 1);
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
    Console.Write($"Сумма натуральных чисел от {start} до {finish} = ");
    Console.WriteLine(SumNaturalNumbers(start, finish));
}

