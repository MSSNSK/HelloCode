// 1. Найти позицию минимального элемента в неотсортированной части массива.
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции.
// 3. Повторять пока есть неотсортированные элементы.

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array) // - метод для вывода массива
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array) // - метод упорядочевания массива
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for(int j = i + 1; j < array.Length; j++)               // - блок
        {                                                       //   ищет
            if(array[j] < array[minPosition]) minPosition = j;  //   максимальный
        }                                                       //   элемент

        int temporary = array[i];                               // - в этом блоке
        array[i] = array[minPosition];                          //   производится
        array[minPosition] = temporary;                         //   замена (свап)
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);