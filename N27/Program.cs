Console.WriteLine("Введите натуральное число: ");
int A = Convert.ToInt32(Console.ReadLine());
int reserv = A;
int sum = 0;
while (A > 0)
{
    sum += A % 10;
    A /= 10;
}
Console.WriteLine($"Сумма цифр числа {reserv} = {sum}");