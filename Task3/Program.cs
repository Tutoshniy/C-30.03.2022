Console.Clear();
Console.WriteLine("Введите количество точек у фигуры");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент масштабирования");
int k = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i<=n; i++)
{
    Console.WriteLine("Введите координаты точки");
    int x = Convert.ToInt32(Console.ReadLine());
    int y = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Получившиеся координаты:" + x*k + ", " + y*k);
}