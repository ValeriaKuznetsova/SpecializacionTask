//Написать программу которая из имеющегося массива строк формирует массив из строк длина которых меньше, либо равна трём символам

Console.WriteLine("Введите желаемую строку для обработки: ");

string originalString = Console.ReadLine();
string[] enteredArray = originalString.Split(' ', StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine("Исходный массив: ");

for (int i = 0; i < enteredArray.Length; i++)
    Console.Write(enteredArray[i] + " ");
Console.WriteLine();

Console.WriteLine("Отсортированный массив: ");

var resultString = new string[enteredArray.Length];
var size = 0;
foreach (var value in enteredArray)
{
    if (value.Length <= 3)
    {
        resultString[size] = value;
        Console.Write(resultString[size] + ' ');
        size++;
    }
}