`dotnet new console` - создать консоль в текущей папке

`dotnet run` - запустить программу в консоли

`.Write("Some text")` - вывод сообщения в одну строку

`.WriteLine("Some text")` - вывод сообщения на следующей строке

`.ReadLine()!` - считать строку из терминала, ! убирает ошибку значения NULL

`int` - целое число

`double` - вещественное число

`string` - строка

`bool` - логическая правда/ложь

`char` - символ

`var` - переменной автоматически присвоится тип на основании её содержимого

`+ - * /` - арифметические операции

`%` - остаток от деления

`(скобки)` - приоритет операций

`new Random().Next(min, max)` - случайное целое число от min до max-1

`int[] array;` - объявить массив

объявить массив и задать его содержание:

>`int[] nums = new int[4] { 1, 2, 3, 5 };`
>
>`int[] nums = new int[] { 1, 2, 3, 5 };`
>
>`int[] nums = new[] { 1, 2, 3, 5 };`
>
>`int[] nums = { 1, 2, 3, 5 };`

Ввести массив с клавиатуры, используя пробел как разделитель:

>`int[] array1 = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();`
>
>`int[] array2 = array1.Select(x => x * -1).ToArray();`

Ввести с клавиатуры количество элементов массива и заполнить его случайными числами:

>`int size = int.Parse(ReadLine()!);`
>
>`int[] array3 = new int[size].Select(x => new Random().Next(0, 100)).ToArray();`

Сгенерировать массив случайных чисел, найти и напечатать значения элементов попадающих в заданный диапазон: 

>`int[] k = new int[20].Select(x => new Random().Next(0, 1000)).Where(x => x >= 9 && x <= 100).ToArray();`
>
>`WriteLine(String.Join(" ", k));`