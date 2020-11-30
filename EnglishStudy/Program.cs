using System;

namespace EnglishStudy
{
    class Program
    {
        // Вывод коллекции по одной строке на каждый из времен Simple
        static public bool Show(int currentLevel)
        {
            var AllEnglsihString = new TranslationAction();
            AllEnglsihString.OneLevelStudy(currentLevel);

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
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите уровень тренировки по английскому языку.\nНа текущий момент доступно два уровня: 1 или 2.");
                Console.Write("Введенный уровень для изучения: > ");
                var enterText = Console.ReadLine();
                var continueStudy = false;
                int writeLevel;

                switch (enterText)
                {
                    case "1":
                        writeLevel = 1;
                        break;
                    case "2":
                        writeLevel = 2;
                        break;
                    default:
                        writeLevel = -1;
                        break;
                }

                if (writeLevel > 0)
                {
                    continueStudy = Show(writeLevel);
                    if (!continueStudy) return;
                }
                else
                {
                    Console.WriteLine("Неверный ввод. Повторите попытку.");
                }
            }
        }
    }
}
