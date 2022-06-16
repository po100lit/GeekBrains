Console.Write("Введите имя: ");
string username = Console.ReadLine()!;

if (username.ToLower() == "маша") // .ToLower() - перевод текста в нижний регистр для избежания регистрозависимого ввода
{
    Console.WriteLine("Ура, это же Маша!");
}
else
{
    Console.WriteLine("Привет, " + username + "!");
}