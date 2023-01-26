Console.Clear();
Console.Write("Введите A: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите B: ");
int B = int.Parse(Console.ReadLine());

if(A>B)
{
    Console.WriteLine($"Число {A} больше числа {B}");
}

if(A<B)
{
    Console.WriteLine($"Число {B} больше числа {A}");
}