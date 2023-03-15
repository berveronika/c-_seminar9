// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

/*
void ShowNumbers(int number)
{
    Console.Write(number + " ");
    if (number > 1) ShowNumbers(number - 1);
    }

Console.Write("Input a natural number: ");
int user_n = Convert.ToInt32(Console.ReadLine());
if (user_n > 0) ShowNumbers(user_n);
else Console.WriteLine("Impossible value!");
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/* int SumNumbersMN(int m, int n, int sum)
{
    sum += m;
    if (m < n) return SumNumbersMN(m + 1, n, sum);
    else return sum;
}

Console.Write("Input a number: ");
int user_m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input one more number: ");
int user_n = Convert.ToInt32(Console.ReadLine());
if (user_m < user_n)
{
    int sumBetweenMN = 0;
    sumBetweenMN = SumNumbersMN(user_m, user_n, sumBetweenMN);
    Console.WriteLine($"The sum of natural numbers between {user_m} and {user_n} is {sumBetweenMN}!");
}
else Console.WriteLine("Impossible value!");
*/


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

/*
int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Ackermann(m - 1, 1);
    else return Ackermann(m - 1, Ackermann(m, n - 1));
}

Console.Write("Input M for Ackermann function: ");
int user_m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N for Ackermann function: ");
int user_n = Convert.ToInt32(Console.ReadLine());

if (user_m >= 0 && user_n >= 0)
    Console.WriteLine($"A({user_m},{user_n}) = {Ackermann(user_m, user_n)}");
else Console.WriteLine("Impossible value!");
*/