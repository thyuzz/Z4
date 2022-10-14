/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */ 

Console.Write("введите число: ");
int number = int.Parse(Console.ReadLine());

int Summa(int x) {
    int Sum = 0;
    while (x != 0) {
    Sum = Sum + (x % 10);
    x = x/10;
    }
    return Sum;
}

Console.Write("Сумма цифр числа: " + Summa(number));
