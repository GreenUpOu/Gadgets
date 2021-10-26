using System;

namespace Gadgets
{
    class App
    {
        public string name { get; set; }

        private int take_memory;

        public int weight
        {
            get { return take_memory; }

            set
            {
                if (value < 0)
                {
                    take_memory = 0;
                    return;
                }
                take_memory = value;
            }
        }

        public bool if_db { get; set; }

        public App(string name, int weight, bool if_db)
        {
            this.name = name;
            this.weight = weight;
            this.if_db = if_db;
        }

        public void rename()
        {
            Console.WriteLine($"Enter new {this.name} name: ");
            string name = Console.ReadLine();
            this.name = name;
        }

        public void update(int new_content) => this.weight += new_content;
    }
}
