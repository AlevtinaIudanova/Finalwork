// See https://aka.ms/new-console-template for more information
//Задача:
//Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа.
//Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма.
//При решение не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами

string[] array1 = new string[6] { "111", "asdf", "345", "qwerty", "zxc", "375" };
string[] array2 = new string[array1.Length];

//int count = 0;

void NewArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
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
NewArray(array1, array2);
PrintArray(array2);

