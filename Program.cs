using System;
using System.Threading.Tasks;

namespace AsyncAwaitCore
{
    //check gitchanges
    //changes from git
    class Program
    {
        static void Main(string[] args)
        {
            callmethod();
            Console.WriteLine("Hello World!");
        }

        static async void callmethod()
        {
            Task<int> _task = Method1();
            Method2();

            int count = await _task;

            Method3(count);
        }

        public static async Task<int> Method1()
        {
            int count = 0;

            await Task.Run(() =>
            {

                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("--> METHOD1");
                }
            });

            return count;
        }


        public static void Method2()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("----------> METHOD2");
            }
        }

        public static void Method3(int count)
        {
            
                Console.WriteLine("------> METHOD3");
            
        }

    }
}
