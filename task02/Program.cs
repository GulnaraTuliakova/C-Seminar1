// //Console.Write("Введите число 1: ");
//int a =  int.Parse(Console.ReadLine());
//Console.Write("Введите число 2: ");
//int b =  int.Parse(Console.ReadLine());
//if (a > b)   {

//Console.Write("Максимальное число ");
//Console.Write(a);
//Console.Write(" Минимальное число ");
//Console.Write(b);
//}
//else 
//{
//Console.Write("Максимальное число ");
//Console.Write(b);
//Console.Write(" Минимальное число ");
//Console.Write(a);
//} 

//int numberA = new Random().Next( 1, 10);
//Console.WriteLine(numberA);
//int product = numberA*numberA;
//Console.WriteLine(product);



//Console.Write("Введите число 1: ");
//int a =  int.Parse(Console.ReadLine());
//Console.Write("Введите число 2: ");
//int b =  int.Parse(Console.ReadLine());
//Console.Write("Введите число 3: ");
//int c =  int.Parse(Console.ReadLine());

//int max = a;

//if (b > a)

    //max = b;

//else if ( c > a)

//max = c;

//Задача
Console.Write("Введите число : ");
double a = -5;                                          //int.Parse(Console.ReadLine());
int i = 5;
while (a <= i)
a = a + 1;
Console.WriteLine(a);

//
Console.Write("Введите диапазон чисел: ");
int n2 =  int.Parse(Console.ReadLine());
int n1 = -n2;
Console.WriteLine(n1);
while (n1 <= n2)
{
    Console.Write(n1);
    Console.Write(" ");
    n1++;
}

///Задача

Console.Write("Введите трехзначное число ");
int a =  int.Parse(Console.ReadLine());
int number = a % 10;
Console.WriteLine(number);
//////
Console.Write("Введите 3-х значное число: ");
int a =  int.Parse(Console.ReadLine());
if (a > 99 && a < 1000)
{
Console.Write("Последяя цифра 3-х значного числа = ");
Console.WriteLine(a % 10);
}
else{
    Console.WriteLine("Число не 3-х значное!");
}

