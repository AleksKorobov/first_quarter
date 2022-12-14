/*Написать программу, которая из имеющегося массива строк формирует масив из строк, длинна которых меньше или равна
3 символа. Первоначальный массви можно внести с клавиатуры, либо задат на старте выполнения алгоритма.*/


string[] array1 = new string[5] {"123", "23", "hello", "world", "res"};
string[] array2 = new string[array1.Length];
FillSecondArray(array1, array2);
PrintArray(array2);


