/* Написать программу, которая из имеющегося массива
 строк формирует новый массив из строк, длина которых меньше,
  либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
   либо задать на старте выполнения алгоритма. 
   При решении не рекомендуется пользоваться коллекциями,
   лучше обойтись исключительно массивами.
 */



Console.WriteLine("Первоначальный массив:");

string[] StartArray = { "ads", "hf", "ujgy" };

string[] NewArray = new string[StartArray.Length];

for (int i = 0; i < StartArray.Length; i++)
{
    Console.Write(StartArray[i] + " ");
}

Console.WriteLine();

for (int i = 0; i < StartArray.Length; i++)
{
    if (StartArray[i].Length <= 3)
    {
        NewArray[i] = StartArray[i];
    }
}

Console.WriteLine("Новый массив:");

for (int i = 0; i < NewArray.Length; i++)
{
    Console.Write(NewArray[i]+" ");
}