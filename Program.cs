using System;

namespace hw_1;

class Program
{ 
    static void Main(string[] args)
    {
        // Создаем массив с гласными и согласными
        char[] letter = { 'a', 'b', 'c', 'e', 'i', 'z' };
        
        // Создаем наш объект
        CharContainer container = new CharContainer(letter);

        // Проверка 1: Считаем гласные (должно быть 3: a, e, i)
        Console.WriteLine($"Кількість голосних: {container.VowelsCount}");

        // Проверка 2: Индексатор (должен сделать 'a' -> 'A')
        Console.WriteLine($"Символ за індексом 0 (Upper): {container[0]}");
        
        // Проверка 3: Выход за границы (не должно быть ошибки)
        Console.WriteLine($"Тест межі (індекс 50): '{container[50]}'");

        Console.ReadKey();
    }
}