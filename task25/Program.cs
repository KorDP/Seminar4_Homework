Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

int AtoBDegree(int ac, int bc)
{
    int result = 1;
    for (int i = 0; i < bc; i++)
    {
        result = result * ac;
    }
    return result;
}

int aToBDegree = AtoBDegree(a, b);

Console.WriteLine($"{a} в степени {b} равно {aToBDegree}.");