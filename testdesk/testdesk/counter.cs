using System;
using System.Collections.Generic;
using System.Text;

namespace testdesk
{
    class counter
    {
        public counter()
        { }

        public void count()
        {
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
    }
}
