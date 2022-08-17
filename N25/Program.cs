Console.WriteLine("Введите два натуральных числа: ");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int prois = 1;
for (int i = 0; i < B; i++)
{
    prois *= A;
}
Console.WriteLine($"{A}^{B} = {prois}");