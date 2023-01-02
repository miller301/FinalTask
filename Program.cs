string[] array1 = new string[5] {"Hello", "hi", "book", "33", "eye"};
int array2Length=0;
SecondArrayLength(array1);
Console.WriteLine($"Длина нового массива {array2Length}");
string[] array2 = new string[array2Length];
FillSecondArray(array1, array2);
System.Console.WriteLine("Исходный массив");
PrintArray(array1);
System.Console.WriteLine("Полученный массив");
PrintArray(array2);


void SecondArrayLength(string[] array1)
{
 for (int i = 0; i < array1.Length; i++)
 {
    if (array1[i].Length<=3)
    {
        array2Length=array2Length + 1;
    }
 }
}

void FillSecondArray(string[] array1, string[] array2)
{
    int n = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[n] = array1[i];
        n++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
