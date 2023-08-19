// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



char thirdnum='0';
System.Console.WriteLine("Введите целое число");
string? number = Console.ReadLine();
if ((number.Length)<3)
    System.Console.WriteLine("Третьей цифры нет");
else
    {
     thirdnum = number[2];
     System.Console.WriteLine($"{thirdnum}");
    }
