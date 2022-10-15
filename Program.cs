int a = 0;
int b = 0;
void EnteringConditions()
{
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
if (N > M)
{ 
    a = M;
    b = N;
    Console.Write($"M = {a}; N = {b} -> ");
}
else
{
    a = N;
    b = M;
    Console.Write($"M = {b}; N = {a} -> ");
}
return;
}


/*Задача 64: Задайте значения N и M. Напишите программу, 
которая выведет все чётные натуральные числа в промежутке 
от M до N с помощью рекурсии.

M = 1; N = 5 -> 2, 4
M = 4; N = 8 -> 4, 6, 8
*/

Console.Clear();
Console.WriteLine("Задача 64: Задайте значения N и M. Напишите программу,которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.");
EnteringConditions();
OutputOfEvenNatural();
Console.WriteLine();

void OutputOfEvenNatural()
{
    
    if (a%2 == 0)a = a + 2;
    else a++;
    Console.Write($"{a}, ");
    if (a >= b - 1)
    {
        return;
    }
    OutputOfEvenNatural();
}


/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке 
от M до N с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8 -> 30
*/

Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.");
int temp = 0;
EnteringConditions();
SumOfNaturalElements();
Console.WriteLine(a);

void SumOfNaturalElements()
{
    temp = temp + a;
    a++;
    if (a > b)
    {
        a = temp;
        return;
    }
SumOfNaturalElements();
}


/*Задача 68: Задайте значения M и N. Напишите программу, 
которая найдёт наибольший общий делитель (НОД) этих чисел 
с помощью рекурсии.

M = 28; N = 7 -> 7
*/

Console.WriteLine("Задача 68: Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.");

EnteringConditions();
temp = a;
LookingForTheGreatestCommonDivisor();

void LookingForTheGreatestCommonDivisor()
{
    if (temp == 0)
    {
        return;
    }
    if ((a % temp == 0) && (b % temp == 0))
    {
        Console.WriteLine(temp);
        return;
    }
    else
    {
        temp--;
    }
    LookingForTheGreatestCommonDivisor();
}



/*Дополнительная задача (задача со звёздочкой): Напишите программу 
вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29
*/

Console.WriteLine("Задача *: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
EnteringConditions();
int AckermannFunction (int a, int b)
{
    if (a == 0) return b + 1;
    if (a != 0 && b == 0) return AckermannFunction(a - 1, 1);
    if (a > 0 && b > 0) return AckermannFunction(a - 1, AckermannFunction(a, b - 1));
return AckermannFunction(a, b);
}
Console.WriteLine(AckermannFunction(a, b));
