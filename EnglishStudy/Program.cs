using System;

namespace EnglishStudy
{
    class Program
    {
        // Вывод коллекции по одной строке на каждый из времен Simple
        static public bool Show()
        {
            var AllEnglsihString = new TranslationAction();
            AllEnglsihString.OneLevelStudy();

            foreach (var oneString in AllEnglsihString.ExportTranslationList)
            {
                Console.WriteLine(oneString.russianLanguage);
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(oneString.englishLanguage);
                Console.ResetColor();
            }
            Console.WriteLine("--------------------Конец списка---------------------");

            // Блок для повторного запуска блока изучения
            while (true)
            {
                Console.WriteLine("\nДля повтора нажмите Enter, а для выхода Escape.");
                Console.Write("Введенная команда: > ");
                var pressKey = Console.ReadKey();

                if (pressKey.Key == ConsoleKey.Enter) return true;
                if (pressKey.Key == ConsoleKey.Escape) return false;
            }
        }

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Необходимо устно перевести предложение, после чего через <Enter> получить ответ для проверки.\n");
                bool continueStudy = Show();
                if (!continueStudy) return;

            }
        }
    }
}
