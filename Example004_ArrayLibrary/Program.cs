// Имеется одномерный массив array из n элементов, 
// требуется найти элемент массива, равный find.
    // 1. Установить счетчик index в позицию 0;
    // 2. Если array [index] = find, алгоритм завершил работу успешно.
    // 3. Увеличить index на 1;
    // 4. Если index < n, то перейти к шагу 2. В противном случае,
    // алгоритм завершил работу безуспешно.
// Ниже приводится вариант, в котором для создания массива с 10-ю элементами
// используются генератор псевдослучайных чисел и методы по следующей схеме:
    // этап 1: взять метод, передать в него массив и заполнить массив нужным кол-вом элементов
    // (в данном случае - void FillArray);
    // этап 2: взять метод, который будет выводить все элементы по порядку
    // (в даннос лучае - метод void PrintArray);
    // этап 3: превратить код поиска нужного индекса - в метод.*
// *По умолчанию, подобный массив был бы заполнен нулями. Для того, чтобы массив был
// заполнен, согласно условию выше, псевдослучайными числами - использован метод "void".

System.Console.Clear();

void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        
        // index = index + 1;
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
array[4] = 4;
array[6] = 4;

PrintArray(array);
System.Console.WriteLine();

int pos = IndexOf(array, 444);
System.Console.WriteLine(pos);