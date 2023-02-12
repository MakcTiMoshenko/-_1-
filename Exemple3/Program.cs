// Задача 6 Напишите программу, которая на вход принимает число и выдает, является ли число 
// четным (Делится ли оно на два без остатка)
// 4-> да
// -3-> нет
// -7 -> нет

System.Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number%2==0)
{
    System.Console.Write("Число четное ");
}
else 
{
    System.Console.Write("Число нечетное ");
}