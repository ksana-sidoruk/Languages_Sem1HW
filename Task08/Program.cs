// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// судя по примерам и условию задачи, предположила, что N - положительное число

System.Console.WriteLine("А введите какое-нибудь число больше нуля");
int num = Convert.ToInt32 (Console.ReadLine ());
int count = 2;

if (num <= 1)
{
    System.Console.WriteLine("По условиям задачи нечего тут выводить");
    return;
}

while (count <= num-2)
{
    System.Console.Write(count + ", ");
    count = count + 2;
}

if (count <= num)
    System.Console.Write(count);
