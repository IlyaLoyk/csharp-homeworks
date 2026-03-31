namespace hw_1;

public class CharContainer
{
    private char[] _array;

    // Конструктор: принимает массив символов
    public CharContainer(char[] inputCharacters)
    {
        _array = inputCharacters;
    }

    // ИНДЕКСАТОР (Требование: проверка границ + верхний регистр)
    public char this[int index]
    {
        get
        {
            if (index >= 0 && index < _array.Length)
            {
                // Возвращаем символ большими буквами
                return _array[index];
            }
            return '\0'; // Если индекс неверный, возвращаем "пустоту"
        }
    }

    // СВОЙСТВО (Требование: количество гласных букв)
    public int VowelsCount
    {
        get
        {
            string vowels = "aeiouyAEIOUY"; 
            int count = 0;
            foreach (char c in _array)
            {
                if (vowels.Contains(c))
                {
                count++;
                }
            }
            return count;
        }
    }
}