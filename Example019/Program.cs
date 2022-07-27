// функция, принимающая число и возвращающая факториал этого числа
// int не вмещает в себя значение факториала 17, поэтому используем тип данных double
double Factorial (int n)
{
    // 1! = 1
    // 0! = 1
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}