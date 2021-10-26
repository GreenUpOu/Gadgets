using System;
using System.Threading;
using System.Threading.Tasks;

namespace Gadgets
{
    class Mobile_phone
    {
        public string name { get; set; }
        private int phone_memory;

        public int memory
        {
            get { return phone_memory; }

            set 
            {
                if(value < 0)
                {
                    phone_memory = 0;
                    return;
                }
                phone_memory = value;
            }
        }

        private double screen_diagonal;

        public double diagonal
        {
            get { return screen_diagonal; }

            set
            {
                if (value < 1)
                {
                    screen_diagonal = 1;
                    return;
                }
                screen_diagonal = value;
            }
        }

        public Mobile_phone(string name, int memory, double diagonal)
        {
            this.name = name;
            this.memory = memory;
            this.diagonal = diagonal;
        }

        public bool if_fit(int mem)
        {
            if (memory - mem < 0) return false;
            else return true;
        }

        public void install(App app)
        {
            if (this.if_fit(app.weight))
            {
                memory -= app.weight;
                Console.WriteLine($"Successfully installed {app.name} on {name}");
            }
        }


        //Using TPL
        public void alarm()
        {
            var cts = new CancellationTokenSource();
            var token = cts.Token;

            Task ringtone = new Task(() =>
            {
                while (true)
                {
                    if (token.IsCancellationRequested)
                    {
                        throw new OperationCanceledException(token);
                    }
                    else
                        Console.Beep();
                }

            }, token);


            token.Register(() => Console.WriteLine("Stopping alarm!"));

            Console.WriteLine("ALARM!");
            ringtone.Start();
            Console.WriteLine("Press Enter to stop ringtone");

            Console.ReadLine();
            cts.Cancel();

        }

    }
}
