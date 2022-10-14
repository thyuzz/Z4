/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */ 

Console.Write("введите число: ");
int number = int.Parse(Console.ReadLine());
int Sum = 0;

while (number != 0) {
    Sum = Sum + (number % 10);
    number = number/10;
}

Console.Write("Сумма цифр числа: " + Sum);
