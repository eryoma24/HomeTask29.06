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

int checkingForEven(int[] Array)
{
    int number = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if(Array[i] % 2 == 0)
        {
            number = number + 1;
        }
    }
    return number;
}

int num = numberint();
int[] numberlist = GenerateArray(num, 100, 999);
int quantity = checkingForEven(numberlist);

PrintArray(numberlist);
System.Console.Write($"\nКоличество четных чисел в массиве -> {quantity}");