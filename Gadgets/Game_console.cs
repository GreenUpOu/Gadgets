using System;

namespace Gadgets
{
    class Game_console
    {
        private int number_of_games;

        public int n_games
        {
            get { return number_of_games; }

            set 
            { 
                if(value < 0)
                {
                    number_of_games = 0;
                    return;
                }

                number_of_games = value; 
            }
        }

        public bool if_connected { get; private set; }

        public TV television { get; set; }

        public Game_console(int n_games, TV tv = null)
        {
            this.n_games = n_games;
            if (tv != null)
            {
                this.television = tv;
                this.if_connected = true;
            }
            else
                this.if_connected = false;
        }

        public void connect_if_possible(TV tv)
        {
            if (!if_connected) this.television  = tv;

            else Console.WriteLine("Device is already connected");
        }

        public void reconnect(TV tv) => this.television = tv;
    }
}
