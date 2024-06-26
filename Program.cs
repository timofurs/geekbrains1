// Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

System.Console.WriteLine("Добро пожаловать в программу!");

System.Console.WriteLine("Пожалуйста, введите размер массива:");
int size = Convert.ToInt32(System.Console.ReadLine());

while (size <= 0)           //Проверка на ввод натурального числа
{
    if (size <= 0)
    {
        System.Console.WriteLine("Ошибка! Введите натуральное число!");
    }
    size = Convert.ToInt32(System.Console.ReadLine());
}



string[] CreateStringArrayFromConsole(int size)     // Создание массива строк вводом с консоли
{
    int i = 0;
    string[] array = new string[size];
    while (i < size)
    {
        System.Console.WriteLine($"Введите элемент массива под индексом {i}:");
        array[i] = System.Console.ReadLine();
        i++;
    }
    return array;
}

string[] array = CreateStringArrayFromConsole(size);        //Создаём массив, с которым будем работать

void PrintArray(string[] array)     //Вывод на экран массивов в формате, заданном по условию задачи
{
    if (array.Length == 0)
    {
        System.Console.Write("[]");
    }
    else
    {
        int i = 0;
        System.Console.Write("[");
        while (i < array.Length - 1)
        {
            System.Console.Write('"' + array[i] + '"' + ',' + ' ');
            i++;
        }
        System.Console.Write('"' + array[array.Length - 1] + '"' + "]");
    }
}


int CountItems(string[] array)      //Подсчёт в исходном массиве количества элементов, удовлетворяющих условию задачи. Это число пригодится для создания результирующего массива.
{
    int n = 0;
    int i = 0;
    while (i < array.Length)
    {
        if (array[i].Length <= 3)
        {
            n++;
            i++;
        }
        else i++;
    }
    return n;
}

string[] CreateResultingArray(string[] array, int size)     //Создание результрующего массива
{
    string[] newarray = new string[size];
    int i = 0;
    int j = 0;
    while (i < array.Length)
    {
        if (array[i].Length <= 3)
        {
            newarray[j] = array[i];
            j++;
            i++;
        }
        else i++;
    }
    return newarray;
}

string[] newarray = CreateResultingArray(array, CountItems(array));     //Создаём результирующий массив

System.Console.WriteLine();         //Перенос строки для удобства чтения в терминале
PrintArray(array);                  //Вывод на экран исходного массива
System.Console.Write("->");         //Разделитель (не смог отобразить значок "→" в терминале)
PrintArray(newarray);               //Вывод на экран результирующего массива

System.Console.WriteLine();
System.Console.WriteLine("Спасибо за использование нашей программы!");