using System;

namespace Gadgets
{
    class TV
    {
        private double screen_diagonal;

        public double diagonal
        {
            get { return screen_diagonal; }

            set 
            {
                if(value < 1)
                {
                    screen_diagonal = 1;
                    return;
                }
                screen_diagonal = value; 
            }
        }

        public bool if_connected { get; private set; }
        public Game_console console { get; set; }

        public TV(double diagonal, Game_console console = null)
        {
            this.diagonal = diagonal;

            if (console != null)
            {
                this.console = console;
                this.if_connected = true;
            }
            else
                this.if_connected = false;
        }

        public void connect_if_possible(Game_console console)
        {
            if (!if_connected) this.console = console;
            else Console.WriteLine("Device is already connected");
        }

        public void reconnect(Game_console console) => this.console = console;

    }
}
