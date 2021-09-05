using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace оружие
{
    class Program
    {
        private bool gg;
        public int ffff;
        public void Main()
        {

            Console.WriteLine("Заряжаю");
            gg = true;
            Console.WriteLine("Оружие заряжено");
        }
        public void AA()
        {
            if(!gg)
            {
                Console.WriteLine("Не заряжено");
                Main();
            }
            Console.WriteLine("\t \n \a Пиу пиу ");
            gg = false;

        }
    }

    class KK
    {



        static void Main(string[] args)
        {
            Program dd = new Program();
            dd.AA();
            Console.ReadKey();

        }
    }
    }


