Console.Clear();
Console.WriteLine("Введите конечное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i1 = 0;
int i2 = 1;
Console.Write(i1 + " " + i2 + " ");
int i = 0;
while (i1 + i2 < n)
{
    i = i1 + i2;
    i1 = i2;
    i2 = i;
    Console.Write(i + " ");
}