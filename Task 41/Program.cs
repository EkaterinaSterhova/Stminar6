// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите кол-во элементов: ");
int n = int.Parse(Console.ReadLine()!);
int[] beginArray = new int[n];


Console.Write("Введите значение элементов: ");  

for (int i = 0; i < n; i++)
    beginArray[i] = int.Parse(Console.ReadLine()!);
    int col = 0;
    for (int i = 0; i < beginArray.Length; i++)
    {
        if (beginArray[i] > 0 )
            col++;
    }
        
    Console.WriteLine($"Начальный массив: [{string.Join(" ", beginArray)}]");
    Console.WriteLine(col);
     