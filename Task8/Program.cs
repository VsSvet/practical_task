Console.Clear();
Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine());

int count = 1;
string numbers = "";

while(count < A+1)
{
    if(count%2 == 0)
    {
        numbers += $"{count} ";
    }
    count += 1;
}

Console.Write(numbers);