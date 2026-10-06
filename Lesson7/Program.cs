using Lesson7;

var clsMath = new Lesson7.Math();
var clsArray = new Lesson7.GUIConsolApp();
    while (true)
    {
        Console.WriteLine("Введите количество элементов в массиве и сами элементы:");
        double[] array = { };
        array = clsArray.GetArray(array);
        Console.WriteLine("Введите функцию (sum, count, max, min, factorial):");
        string oper = Console.ReadLine();
        if (oper == "sum")
        {
            Console.WriteLine($"Результат суммирования: {clsMath.Sum(array)}");

        }
        else if  (oper == "count")
        {
            Console.WriteLine($"Длинна вашего массива: {clsMath.Count(array)}");
        }
    else if (oper == "*")
    {
        Console.WriteLine($"Результат умножения: {clsMath.Multiply(array)}");
    }
    else if (oper == "max")
        {
            Console.WriteLine($"Максимальный элемент вашего массива: {clsMath.Max(array)}");
        }
        else if (oper == "min")
        {
            Console.WriteLine($"Минимальный элемент вашего массива: {clsMath.Min(array)}");
        }
        else if (oper == "factorial")
    {
        Console.WriteLine($"Факториал первого числа в массиве: {clsMath.factorial(array)}");
    }
    else
        {
            Console.WriteLine("Введите оператор из списка!");
        }

        if (oper == "exit")
        {
            break;
        }
    }
