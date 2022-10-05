using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Net.Sockets;


namespace Lab3
{
    class Lab3
    {
        static void Main()
        {
            Console.WriteLine("Задание 1");
            int i = 0;

            Console.WriteLine("Счетчик");

            for (i = 0; i <= 100; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine();

            Console.WriteLine("Цикл с предусловием");

            i = 0;
            while (i <= 100)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }

            Console.WriteLine();

            Console.WriteLine("Цикл с постусловием");
            i = 0;
            do
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            while (i <= 100);

            Console.WriteLine();

            Console.WriteLine("Задание 2");
            i = 0;
            int summ = 0;
            for (i = 0; i <= 30; i++)
            {
                if (i % 2 == 0)
                {
                    summ += i;

                }
                Console.WriteLine(summ);
            }

            Console.WriteLine();

            Console.WriteLine("Задание повышенной сложности 1");
            devRekurs(0,100,10);

            Console.WriteLine();

            Console.WriteLine("Задание повышенной сложности 2");
            string str = Console.ReadLine();
            foreach(var item in str)
            {
                Console.WriteLine(item);
            }    
        }
        static void devRekurs(int index, int end, int dev)
        {
            if (index <= end)
            {
                if (index % dev == 0)
                {
                    Console.WriteLine(index);
                }
                devRekurs(++index, end, dev);
            }

        }
    }
}


