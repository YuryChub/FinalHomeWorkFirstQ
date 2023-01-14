// Итоговая проверочная работа
//     Задача:
//     Написать программу, которая из имеющегося массива строк
//     формирует массив из строк, длина которых меньше либо равна 3 символам.
//     Первоначальный массив: можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//     При решении не рекомендуется пользоваться коллекциями,
//     лучше обойтись исключительно массивами.
//     Примеры:
//     ["hello", "2", "world", ":-)"] -> ["2",":-)"]
//     ["1234", "1567", "-2", "computer science"] -> ["-2"]
//     ["Russia", "Denmark", "Kazan"] -> []

string[] InputArray() 
// Создаем массив и приглашаем пользователя ввести количество строк 
// и их значения

{
    Console.Write("Введите количество строк, которые хотите ввести: ");
    int n = Convert.ToInt32(Console.ReadLine()); 
    // Считываем строку, переводим в число.
    string[] array = new string[n]; 
    //Объявляем массив строк длиной n (которую ввёл пользователь)
    for (int i = 0; i < n; i++)
        {
            Console.Write("Введите строку №{0}:\r\n    ", i + 1);
            array[i] = Console.ReadLine(); //Заполняем массив
        }
        return array;
}


string[] ArrayLess4(string[] array)    
// Проверяем длины строк введенного массива и 
// создаем массив со строками длиной не более 3 символов 
{
    int counter = 0, StrMax = 3;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= StrMax)
        {
            counter++;
        }
    }
    string[] ArrayOut = new string[counter];

    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {        
        if(array[i].Length <= StrMax)
        {
            ArrayOut[j] = array[i];
            j++;
        }
    }
    return ArrayOut;
} 

Console.Clear();

string[] Array1 = InputArray();
Console.WriteLine();
Console.WriteLine("Введенный массив:");
Console.WriteLine($"[{string.Join("\t", Array1)}]");
Console.WriteLine();
string[] Array2 = ArrayLess4(Array1);
Console.WriteLine("Массив со строками длиной менее 4:");
Console.WriteLine($"[{string.Join("\t", Array2)}]");
