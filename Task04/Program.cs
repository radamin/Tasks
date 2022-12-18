// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 4, 5, 78 -> 78
// 22, 3, 9 -> 22


Console.WriteLine("Enter three numbers:");
int num_1 = Convert.ToInt32(Console.ReadLine());
int num_2 = Convert.ToInt32(Console.ReadLine());
int num_3 = Convert.ToInt32(Console.ReadLine());

int max = num_1;

if (num_2 > max)
{
    max = num_2;
}

if (num_3 > max)
{
    max = num_3;
}

Console.WriteLine("The largest of the entered numbers -> " + max);