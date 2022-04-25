//Вывести на экран дипапзон чисел от -n до n


Console.Write("Введите число: ");
int num2 =  int.Parse(Console.ReadLine());
int num1 = -num2;
if (num2 > 0)
{
Console.WriteLine("Диапазон чисел от " + num1 + " до " + num2);
while (num1 <= num2)
{
Console.Write(num1);
Console.Write(" ");
 num1++;
}
}
else if (num2 < 0)
{
Console.WriteLine("Диапазон чисел от " + num2 + " до " + num1);
while (num2 <= num1)
{
Console.Write(num2);
Console.Write(" ");
 num2++;
}
}
