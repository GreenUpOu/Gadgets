using System;

namespace Gadgets
{
    class Computer
    {
        public string name { get; set; }

        private int main_memory;

        public int ram
        {
            get { return main_memory; }

            set
            {
                if (value < 0)
                {
                    main_memory = 0;
                    return;
                }
                main_memory = value;
            }
        }

        private int freeMemory;

        public int free_memory
        {
            get { return freeMemory; }

            set
            {
                if (value < 0)
                {
                    freeMemory = 0;
                    return;
                }
                freeMemory = value;
            }
        }

        public Computer(string name, int ram, int free_memory)
        {
            this.name = name;
            this.ram = ram;
            this.free_memory = free_memory;
        }

        public bool if_fit(int mem)
        {
            if (free_memory - mem < 0) return false;
            else return true;
        }

        public void install(App app)
        {
            if (this.if_fit(app.weight))
            {
                free_memory -= app.weight;
                Console.WriteLine($"Successfully installed {app.name} on {name}");
            }
        }
    }
}
