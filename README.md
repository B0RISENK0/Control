# Описание решения #
1. Задал стартовый массив типа <string> .
```sh
string[] StartArray = { "ads", "hf", "ujgy" };
```
2. Задал новый массив типа <string>.
```sh
string[] NewArray = new string[StartArray.Length];
```
3. При помощи цикла <for> вывел стартовый  массив на консоль.
```sh
for (int i = 0; i < StartArray.Length; i++)
{
    Console.Write(StartArray[i] + " ");
}
```
4. При помощи цикла <for> заплонил новый массив строками из стартового массива не привышающими 3х символов.
```sh
for (int i = 0; i < StartArray.Length; i++)
{
    if (StartArray[i].Length <= 3)
    {
        NewArray[i] = StartArray[i];
    }
}
```
5. При помощи цикла <for> вывел новый массив на консоль.
```sh
for (int i = 0; i < NewArray.Length; i++)
{
    Console.Write(NewArray[i]+" ");
}
```