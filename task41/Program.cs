// // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


List<int> lisNum = new List<int>();
Console.WriteLine("Введите число,_____ для введения следующего числа нажмите [Enter]");


List<int> listСompletion(List<int> lisNum)
{
    string close = "";

    while (close != "00")
    {
        Console.WriteLine("введите число   (для выхода введите 00)");
        close = Console.ReadLine();
        int number = Convert.ToInt32(close);
        lisNum.Add(number);
    }
    return lisNum;
}

void countingNum(List<int> lisNum)
{

    int count  = 0;
    foreach (var num in lisNum)
    {
        if (num > 0) { count++; }
    }
    Console.WriteLine($"\nчисел больше 0 ---- {count}");
}


void show(List<int> LisNum)
{
    foreach (var num in lisNum)
    {
        Console.Write($"[{num}]");
    } 
}


show(listСompletion(lisNum));
countingNum(lisNum);
