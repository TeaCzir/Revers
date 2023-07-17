/* Разворот массива в обратном порядке.*/
Console.Clear();
int[] a = { 1, 2, 3, 4, 5, 6, 7 };
int size = 7;
Console.Write("  Массив: { ");
for (int i = 0; i < size; i++)
{
   Console.Write($"{a[i]}, ");
}
Console.Write("}");
Console.WriteLine();
Console.Write("Разворот: { ");
for (int i = size - 1; i >= 0; i--)
Console.Write($"{a[i]}, ");
Console.Write("}");