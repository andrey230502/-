using System;

namespace prak5
{
    class Program
    {
        static string Reverse(string str)//Задание 1
        {
            //змінна для зберігання результату
            var retValue = string.Empty;
            foreach (var symbol in str)
            {
                //приклеюємо символ на початок рядка
                retValue = symbol + retValue;
            }

            return retValue;
        }
        static string CapitalizeString(string s)//Задание 2
        {
            //розбиваємо текст на слова
            var parts = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < parts.Length; i++)
            {
                //отримуємо першу літеру
                var firstLetter = parts[i].Substring(0, 1).ToUpper();
                //з'єднуємо символ та залишок від слова
                parts[i] = firstLetter + parts[i].Remove(0, 1);
            }

            //склеюємо масив рядків
            return string.Join(" ", parts);
        }
        static bool IsPalindrom(string text)//Задание 3
        {
            //видаляємо пробіли
            var s = text.Replace(" ", string.Empty);
            //переводимо в нижній регістр
            s = s.ToLower();
            //індекс останнього символу
            int lastIndex = s.Length - 1;
            for (int i = 0; i < s.Length / 2; i++)
            {
                //якщо символи не однакові, повертаємо false
                if (s[i] != s[lastIndex - i])
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Введіть текст для реверсування: ");
            var s = Console.ReadLine();
            Console.WriteLine($"Реверс рядка: {Reverse(s)}");
            Console.ReadLine();
            Console.WriteLine("Задание 2");
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Введіть текст для перетворення: ");
            var s1 = Console.ReadLine();
            var result = CapitalizeString(s1);
            Console.WriteLine($"Результат: {result}");
            Console.ReadLine();
            Console.WriteLine("Задание 3");
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Введіть рядок для перевірки: ");
            var text = Console.ReadLine();
            var res = IsPalindrom(text) ? string.Empty : "не ";
            Console.WriteLine($"Рядок \"{text}\" {res}є паліндромом");
            Console.ReadLine();

        }
    }
}
