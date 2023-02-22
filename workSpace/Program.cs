// Задача: Написать программу которая из имеющегося массива строк, формирует массив строк 
// длинна которых меньше или равна 3-м символам.
// Пример :
// ["hello", "2" , "world", ":-)"] -> ["2" , ":-)"]



// метод заполнения массива
void ArrayFill(string?[] matr)
{
    for (int i = 0; i < matr.Length; i++)
    {
        System.Console.WriteLine("Введите слово : ");
        matr[i] = Console.ReadLine();
    }
}

// метод вывода массива
void PrintArray(string[] arr)
{
    System.Console.WriteLine($"[" + string.Join(",", arr) + "]");
}

//метод отсеивания слов с 3 и менее элементами
string[] RedactionArray(string[] arr)
{
    string[] text = new string[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            text[i] = arr[i];
        }
    }
    return text;
}

// еще один вариант отсеивания 
void RedacArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            System.Console.Write($"[ {array[i]} ]");
        }
    }

}

System.Console.WriteLine("Введите колличество проверяемых слов: ");
int wordcount = Convert.ToInt32(Console.ReadLine());
string[] size = new string[wordcount];
ArrayFill(size);
PrintArray(size);
System.Console.WriteLine();
PrintArray(RedactionArray(size));
RedacArray(size);