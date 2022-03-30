Console.Clear();
Console.WriteLine("Введите b1 и k1 для уравнения y = k1 * x + b1");
int b1 = Convert.ToInt32(Console.ReadLine());
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2 и k2 для уравнения y = k2 * x + b2");
int b2 = Convert.ToInt32(Console.ReadLine());
int k2 = Convert.ToInt32(Console.ReadLine());
if (k1 == k2) { Console.WriteLine("Эти прямые параллельны"); }
else
{
    int x = (b2 - b1)/(k1 - k2);
    int y = k1 * x + b1;
    Console.WriteLine("Точка пересечения: ");
    Console.Write(x +" " + y);
}