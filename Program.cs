// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

Console.Clear();

int[] array = new int[123];
Random rnd = new Random();
int count = 0;

for (int i = 0; i < 123; i++)
{
    array[i] = rnd.Next(1, 500);
    if (array[i] < 100 && array[i] > 9) count++;
}

Console.WriteLine($"Массив содержит {count} элементов заданного диапазона");