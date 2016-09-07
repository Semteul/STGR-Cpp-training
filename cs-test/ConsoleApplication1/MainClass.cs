using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApplication1 {

    class MainClass {

        static Stopwatch sw = new Stopwatch();
        static bool runSw = false;

        static int Main2(string[] args) {
            while(true) {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("Enter the key for the desired test.");
                Console.WriteLine("0: Quit");
                Console.WriteLine("1: StringCalculator");
                Console.WriteLine("2: UntitledTest1");

                int errorCode;
                char num = Console.ReadKey(true).KeyChar;
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                runSw = false;
                sw.Reset();
                
                switch(num) {
                case '0':
                    return 0; //End of this Program
                case '1':
                    StringCalculator test1 = new StringCalculator();
                    errorCode = test1.run();
                    break;
                case '2':
                    UntitledTest1 test2 = new UntitledTest1();
                    errorCode = test2.run();
                    break;
                case '3':
                    AsyncTest test3 = new AsyncTest();
                    errorCode = test3.run();
                    break;
                default:
                    if(sw.IsRunning) {
                        endTimer();
                    }
                    Console.WriteLine("Not valid test.");
                    Console.ReadKey();
                    continue;
                }
                if(sw.IsRunning) {
                    endTimer();
                }

                if(errorCode != 0) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine("Test finish with ErrorCode: " + errorCode);
                }
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;

                if(runSw) {
                    Console.WriteLine("[TotalRuntime: " + (sw.ElapsedMilliseconds.ToString()) + "ms] Press any key to continue.");
                } else {
                    Console.WriteLine("Press any key to continue.");
                }
                Console.ReadKey();
            }
        }

        public static void startTimer() {
            runSw = true;
            sw.Start();
        }

        public static void endTimer() {
            sw.Stop();
        }
    }
}
