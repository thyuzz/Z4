/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

Console.Write("введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("введите число B: ");
int b = int.Parse(Console.ReadLine());
int result = a;

int Stepen(int x, int y){
    int result = x;
    for (int i = 1; i < y; i++) { result = result * x; }
    return result;
}

Console.WriteLine("введите число A: " + Stepen(a, b));
