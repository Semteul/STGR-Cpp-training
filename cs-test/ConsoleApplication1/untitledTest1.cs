using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApplication1 {
    class UntitledTest1 {
        public int run() {
            Console.WriteLine("Please write valid NaturalNumber.");
            
            string numString = Console.ReadLine();
            MainClass.startTimer(); //Start Timer

            int num;

            if(!int.TryParse(numString, out num) || num <= 0) {
                Console.WriteLine("Not Valid.");
                return 1;
            }

            int diagonalIndex = 0; //Count direction: ↙↗↙↗... {if((diagonalIndex % 2) == 0) == [↙]}
            int diagonalTotal = 0;
            while((diagonalTotal += ++diagonalIndex) < num); //No contents again :P
            diagonalTotal -= diagonalIndex;
            int space = num - diagonalTotal;
            if((diagonalIndex % 2) == 1) { //↙ (??
                Console.WriteLine("(" + space + ", " + (diagonalIndex - (space-1)) + ")");
            } else { //↗
                Console.WriteLine("(" + (diagonalIndex - (space-1)) + ", " + space + ")");
            }

            MainClass.endTimer(); //End Timer
            return 0;
        }
    }
}
