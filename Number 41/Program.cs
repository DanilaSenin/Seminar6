using System.Data;
using System.Runtime.InteropServices.Marshalling;

Console.WriteLine("Введите, сколько чисел хотите записать: ");
int M = int.Parse(Console.ReadLine());
int cnt = 0;
int[] Pol = new int[M];
Console.WriteLine("Введите свои числа: ");
for (int i = 0; i < M; i++) {
    Pol[i] = int.Parse(Console.ReadLine());
}
for (int j = 0; j < M; j++) {
    if (Pol[j] > 0) {
        cnt++;
    }
    }
Console.Write("Число положительных: " + cnt);