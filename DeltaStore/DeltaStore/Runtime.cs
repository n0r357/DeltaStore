using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeltaStore
{
    class Runtime
    {
        public void Start()
        {

            Manager mgr = new Manager();
            bool loop = true;

            while (loop)
            {

                Console.Clear();
                Menus.Start();
                var input = Console.ReadKey(true).Key;

                switch (input)
                {

                    case ConsoleKey.D1:
                        mgr.AddInstrument();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        loop = false;
                        break;
                }
            }
        }
    }
}
