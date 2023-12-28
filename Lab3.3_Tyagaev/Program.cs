Console.WriteLine("Введите значение x:");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Введите количество повторений:");
int n = int.Parse(Console.ReadLine());
double sum = 0;
int sign = 1;
double term = 1;
for (int i = 0; i < n; i++)
{
    sum += sign * term;
    sign *= -1;
    term *= x * x / ((2 * i + 2) * (2 * i + 3));
}
Console.WriteLine("Сумма: " + sum);