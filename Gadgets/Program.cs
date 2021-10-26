using System;

namespace Gadgets
{

    delegate void MessageHandler(string message);

    class Program
    {

        static event MessageHandler Message;

        static void Main(string[] args)
        {

            Message += message => Console.WriteLine(message);

            var discord = new App("discord", 1, true);
            var steam = new App("Steam", 3, true);
            var CS = new App("CS:GO", 35, true);

            var mark = new Computer("Mark", 4, 25);
            mark.install(discord);
            var bizon = new Computer("Bizon", 8, 256);
            var white_beard = new Computer("White Beard!!", 16, 128);

            var apple = new Mobile_phone("Iphone 12 pro", 256, 8.2);
            var sumsung = new Mobile_phone("Galaxy s8", 128, 6.3);
            var xiaomi = new Mobile_phone("Redmi 5 plus", 32, 5.8);

            var xbox = new Game_console(3);
            var PS5 = new Game_console(5);
            var PS4 = new Game_console(12);

            var zala = new TV(34.5, xbox);
            var panasonic = new TV(34.2, PS4);
            var horizont = new TV(56.12, PS5);

            apple.alarm();

            Message?.Invoke($"TV diagonal — {zala.diagonal}. Connected to console");

            xbox.connect_if_possible(zala);
            PS4.reconnect(panasonic);
            PS5.connect_if_possible(horizont);

            Console.ReadLine();
        }
    }
}

