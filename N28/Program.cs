int[] mas = {3, 6, 9, 7, 0, 3, 9, 11};
int[] masP = {0, 0, 0, 0, 0, 0, 0, 0};
for (int i = 0; i < mas.Length; i++)
{
    Console.Write($"{mas[i]} ");
}
Console.WriteLine();
for (int i = 0; i < mas.Length; i++)
{
    int A = mas[i];
    int p = 1;
    if (A == 0) p = 0;
   for (int j = 1; j < A+1; j++)
   {
    p *= j;
    } 
    masP[i] = p;
}
Console.Write("New massiv: ");
for (int i = 0; i < mas.Length; i++)
{
    Console.Write($"{masP[i]} ");
}