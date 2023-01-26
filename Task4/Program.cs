Console.Clear();
Console.Write("Введите первое число: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите  второе число: ");
int B = int.Parse(Console.ReadLine());
Console.Write("Введите  третье число: ");
int C = int.Parse(Console.ReadLine());

int max_number = A;

if(A > max_number)
{
    max_number = A;
}

if(B > max_number)
{
    max_number = B;
}

if(C > max_number)
{
    max_number = C;
}

Console.WriteLine($"Максимальное число {max_number}");