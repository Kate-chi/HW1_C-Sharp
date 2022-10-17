Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.Write("Максимальное число: " + num1 + ", минимальное число: " + num2);
}
else if(num1 < num2)
{
    Console.Write("Максимальное число: " + num2 + ", минимальное число: " + num1);
}
else 
{
    Console.Write("Упс, Вы ввели одинаковые числа :(");
}