﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Enter the first number: ");
int num_A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
int num_B = Convert.ToInt32(Console.ReadLine());

if (num_A > num_B)
{
    Console.WriteLine("First number " + num_A + " more than the second " + num_B);
}
else
{
    Console.WriteLine("Second number " + num_B + " more than the first " + num_A);
}
