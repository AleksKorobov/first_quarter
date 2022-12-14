/*Написать программу, которая из имеющегося массива строк формирует масив из строк, длинна которых меньше или равна
3 символа. Первоначальный массви можно внести с клавиатуры, либо задат на старте выполнения алгоритма.*/


string[] array1 = new string[5] {"123", "23", "hello", "world", "res"};
string[] array2 = new string[array1.Length];
FillSecondArray(array1, array2);
PrintArray(array2);

void FillSecondArray(string[] array1, string[] array2)
{
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[i] = array1[i];
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
