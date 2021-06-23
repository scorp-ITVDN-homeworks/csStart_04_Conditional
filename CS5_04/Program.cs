using System;
using System.Threading;

namespace CS5_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Поговорим о погоде как английские джентельмены?");
            
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("...");
                Thread.Sleep(1000);
            }
            Console.WriteLine("...");
            Thread.Sleep(1000);
            Console.WriteLine("Как?!");
            Thread.Sleep(2000);
            Console.WriteLine("Вы не знаете ни одного слова о погоде, не проходили это в школе ?");
            Thread.Sleep(3000);
            Console.WriteLine("Тогда скажите что-нибудь о погоде");
            Thread.Sleep(3000);
            Console.WriteLine("Слово должно быть наречием");
            Thread.Sleep(3000);
            Console.WriteLine("Например - \"солнечно\" или \"пасмурно\" " +
                "и узнаете как это будет по английски");
            Thread.Sleep(3000);

            // нельзя использовать в качестве Case
            // элементы массива и переменные
            //string[] weatherRus =
            //{
            //    "солнечно",
            //    "пасмурно",
            //    "ясно",
            //    "дождливо",
            //    "тепло",
            //    "прохладно",
            //    "ветренно",
            //    "туманно",
            //    "морозно",
            //    "снежно"
            //};

            string[] weatherEng =
            {
                "sunny",
                "cloudy",
                "clear",
                "rainy",
                "warm",
                "cold",
                "windy",
                "foggy",
                "frosty",
                "snowy",
            };

            string continueToAsk = "да";
            int askCounter = 0;
            string startPhrase = "Назовите слово";                     

            do
            {
                Console.WriteLine(startPhrase);
                startPhrase = 
                    askCounter < 5 ? "Ещё одно" : "Вы и так уже много знаете, но продолжим. И Ваше слово?";                
                string wordForTranslate = Console.ReadLine().ToLower();

                switch (wordForTranslate)
                {
                    case "солнечно":
                        {
                            GetAnswer(weatherEng[0]);
                            break;
                        }
                    case "пасмурно":
                        {
                            GetAnswer(weatherEng[1]);
                            break;
                        }
                    case "ясно":
                        {
                            GetAnswer(weatherEng[2]);
                            break;
                        }
                    case "дождливо":
                        {
                            GetAnswer(weatherEng[3]);
                            break;
                        }
                    case "тепло":
                        {
                            GetAnswer(weatherEng[4]);
                            break;
                        }
                    case "прохладно":
                        {
                            GetAnswer(weatherEng[5]);
                            break;
                        }
                    case "ветренно":
                        {
                            GetAnswer(weatherEng[6]);
                            break;
                        }
                    case "туманно":
                        {
                            GetAnswer(weatherEng[7]);
                            break;
                        }
                    case "морозно":
                        {
                            GetAnswer(weatherEng[8]);
                            break;
                        }
                    case "снежно":
                        {
                            GetAnswer(weatherEng[9]);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Такие слова знать ещё рано");
                            break;
                        }
                }

                if(askCounter >= 5)
                {
                    Console.WriteLine("Хотите узнать ещё одно слово? (введите \"да\" если да)");
                    continueToAsk = Console.ReadLine().ToLower();
                }
                
                askCounter = askCounter < 5 ? askCounter + 1 : askCounter;
            }
            while (continueToAsk == "да");

            Thread.Sleep(1000);
            Console.WriteLine("Счёт за урок я пришлю позднее");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("(шутка)");
            Console.ResetColor();
        }

        public static void GetAnswer(string answer)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(answer);
            Console.ResetColor();
        }
    }
}
