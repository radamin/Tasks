
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

{

  int num;

  Console.Write("Enter the number: ");

  num = Convert.ToInt32(Console.ReadLine());

  if (num % 2 == 0)

  {

    Console.Write("is: even");

    Console.Read();

  }

  else

  {

    Console.Write("is: odd");

    Console.Read();

  }

}