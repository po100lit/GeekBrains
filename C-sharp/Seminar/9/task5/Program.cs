using static System.Console;
Clear();

/*
Проверить можно ли из символов одной строки составить вторую (анаграмма), учитывая только буквы, регистр букв значения не имеет.
*/

string text1 = "I am lord Voldemort";
string text2 = "Tom Marvolo Riddle";

text1 = text1.Replace(" ", "").ToLower();
text2 = text2.Replace(" ", "").ToLower();

WriteLine((TextSort(text1) == TextSort(text2)) ? "Строка является анаграммой" : "Строка НЕ является анаграммой");

string TextSort(string str)
{
    char[] charArray = str.ToCharArray();
    Array.Sort(charArray);
    string s = new String(charArray);
    return s;
}
