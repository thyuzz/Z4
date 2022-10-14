/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19, 2, 4, 9 -> [1, 2, 5, 7, 19, 2, 4, 9 ]

6, 1, 33, 2, 93, 15, 424, 0-> [6, 1, 33, 2, 93, 15, 424, 0] */

int[] arr = new int[8];


int ElemMas() {
    Random rnd = new Random();
    int x = rnd.Next(0, 100);
    return x;
}

void MasWrite(int x) {
    Console.Write(arr[x]);
}

Console.Write("[");
for (int i = 0; i < 8; i++) {
    arr[i] = ElemMas();
    MasWrite(i);
    Console.Write(", ");
}
Console.Write("]");
