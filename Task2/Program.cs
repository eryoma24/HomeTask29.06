int numberint()
{
    System.Console.Write("Введите длину массива -> ");
    string numint = Console.ReadLine();
    int numberint = Convert.ToInt32(numint);
    return numberint;
}

int[] GenerateArray(int len, int min, int max)
{
    int[] list1 = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < list1.Length; i++)
    {
        list1[i] = rnd.Next(min, max +1);
    }
    return list1;
}

void PrintArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        System.Console.Write(Array[i] + " ");
    }
}

int SumArray(int[] Array)
{
    int sum = 0;
    for (int i = 0; i < Array.Length; i+=2)
    {
        sum = sum + Array[i];
    }
    return sum;
}

int quantity = numberint();

int[] list1 = GenerateArray(quantity, 0 , 30);
PrintArray(list1);
int sumnumber = SumArray(list1);
System.Console.Write($"\nСумма нечетных чисел в массиве -> {sumnumber}");