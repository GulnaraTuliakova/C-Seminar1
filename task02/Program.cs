// Найти среди двух чисел минимальное и максимальное и написать

Console.Write("Введите первое число: ");
int a =  int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b =  int.Parse(Console.ReadLine());
if (a > b)  
 {
Console.Write("Максимальное число - " + a + ". Минимальное число - " + b);
}
else 
{
Console.Write("Максимальное число - " + b + ". Минимальное число - " + a + ".");
}
