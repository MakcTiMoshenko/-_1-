// Задача 2 Напишите программу, которая на вход принимает 2 числа и выдает, Какое число больше, а какое меньше
// a=5, b=7 -> max=7
// a=2, b=10 -> max=10
// a=-9, b=-3 -> max=-3 

System.Console.Write("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 < number2)
{
    System.Console.Write("Max "+ number2);
}
else 
{
    System.Console.Write("Max "+ number1);
}