// Задача 4 Напишите программу, которая принимает на вход 3 числа и выдает максимальное из этих чисел
// 2,3,7 -> 7
// 44,5,78 -> 78
// 22,3,9 -> 22

System.Console.Write("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третье число ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (max < number2)
{
    max = number2;
}
else 
{
    max = number1;
}
if (max < number3)
{
    max = number3;
}
else 
{
    max = number1;
}
System.Console.Write("Max " + max);