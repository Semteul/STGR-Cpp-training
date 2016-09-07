using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    class AsyncTest {

        const int UP = 0;
        const int RIGHT = 1;
        const int DOWN = 2;
        const int LEFT = 3;

        public static int hello = -1;

        public AsyncTest() {

        }

        public int run() { //main

            Thread th = new Thread(new ThreadStart(asyncProgress));
            th.Start();

            while(true) {
                switch(Console.ReadKey(true).Key) {
                case ConsoleKey.UpArrow:
                    hello = UP;
                    break;
                }
                 
            }
            return 0;
        }

        public static void asyncProgress() {
            while(true) {
                Console.WriteLine(hello);
                Thread.Sleep(1000);
            }
        }
    }
}
