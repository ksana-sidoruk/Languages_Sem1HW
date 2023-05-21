// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("введите какое-нибудь число");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите еще одно число");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("и еще одно, последнее, честно");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 >= num2 && num1 >= num3)
    System.Console.WriteLine("максимальным из трех чисел является "+ num1);
else if (num2 >= num1 && num2 >= num3)
    System.Console.WriteLine("максимальным из трех чисел является "+ num2);
else 
    System.Console.WriteLine("максимальным из трех чисел является "+ num3);