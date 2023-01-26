Console.Clear();
Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число: ");
int B = int.Parse(Console.ReadLine());

if(A>B)
{
    Console.WriteLine($"Число {A} больше числа {B}");
}

if(A<B)
{
    Console.WriteLine($"Число {B} больше числа {A}");
}