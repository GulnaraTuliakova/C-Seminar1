//Найти из трех чисел самое большое

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine());

int max = a;
if (b > a)
    max = b;
if (c > max)
    max = c;

Console.WriteLine("Максимальное число = " + max); 
