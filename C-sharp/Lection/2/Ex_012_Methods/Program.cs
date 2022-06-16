using System;
using static System.Console;

Clear();

// метод ничего не принимает и нечего не возвращает
void Method1()
{
    WriteLine("Печатаем какой-то текст");
}
Method1();

// метод что-то принимает, но нечего не возвращает
void Method2(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        WriteLine(msg);
        i++;
    }
}
Method2(count: 4, msg: "Текст сообщения"); // в случае именования аргументов, последовательность написания аргументов не важна

// метод ничего не принимает, но что-то возвращает
int Method3() // необходимо указать тип возвращаемых данных
{
    return DateTime.Now.Year;
}
int year = Method3();
WriteLine(year);

// метод что-то принимает и что-то возвращает
string Method4(int count, string text)
{
    // int i = 0;
    string result = String.Empty; // присваеваем пустую строку
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "S");
WriteLine(res);


// замена символов в тексте
string text = "Товарищи! Сложившаяся структура организации представляет собой"
            + " интересный эксперимент проверки направлений прогрессивного развития."
            + " Товарищи! постоянное информационно-пропагандистское обеспечение нашей"
            + " деятельности позволяет выполнять важные задания по разработке модели развития. "
            + "Значимость этих проблем настолько очевидна, что консультация с"
            + " широким активом играет важную роль в формировании новых предложений.";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
WriteLine(newText);

// сортировка массива
int[] arr = { 1, 5, 4, 3, 2, 1, 6, 3 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Write($"{array[i]} ");
    }
    WriteLine();
}

PrintArray(arr); // печать массива

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPos = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPos]) minPos = j;
        }
        int tmp = array[i];
        array[i] = array[minPos];
        array[minPos] = tmp;
    }
}
SelectionSort(arr); // сортировка массива
PrintArray(arr); // печать отсортированного массива
