// Задайте произвольный массив. Выведете его элементы, начиная с конца.
//  Использовать рекурсию, не использовать циклы.

int[] Array = { 5, 35, 27, 38, 87 }; 

void PrintArrayRev(int[] arr, int index)
{
    if (index >= 0) 
        { 
            Console.Write(arr[index] + " "); 
            PrintArrayRev(arr, index - 1); 
        } 
}

Console.WriteLine("Элементы массива, начиная с конца:");
PrintArrayRev(Array, Array.Length - 1);