/* Разворот массива в обратном порядке с использованием 
 временной переменной temp.*/
Console.Clear();
int[] a = { 8, 0, 12, 5, 9, 32, 85 };
Console.Write("  Массив: { ");
for (int i = 0; i < 7; i++)
{
   Console.Write($"{a[i]}, ");
}
Console.Write("}");
Console.WriteLine();
Console.Write("Разворот: { ");
int temp = 6;
for (int i = 0; temp >= i; temp--)
{
   Console.Write($"{a[temp]}, ");
}
Console.Write("}");