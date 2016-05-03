using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    class StringCalculator {
        const char ADD = '+';
        const char MINUS = '-';
        const char MULTIPLY = '*';
        const char DIVISION = '/';
        const char BRACKET_START = '(';
        const char BRACKET_END = ')';

        char[] validChar = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '.', ADD, MINUS, MULTIPLY, DIVISION, BRACKET_START, BRACKET_END };

        public struct Bracket { //()
            public int start, end; //index

            public void setStart(int index) {
                this.start = index;
            }

            public void setEnd(int index) {
                this.end = index;
            }
        }

        public StringCalculator() {
        }

        public int run() {
            Console.WriteLine("Please write valid equation.");

            System.Text.StringBuilder sb = new System.Text.StringBuilder(); //String Builder

            ConsoleKeyInfo cki;
            // Prevent example from ending if CTL+C is pressed.
            Console.TreatControlCAsInput = true; //??

            while (true) {
                cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.Enter) { //Input finish
                    Console.Write("\nValue: ");
                    break;
                }

                if(isValidChar(cki.KeyChar)) {
                    sb.Append(cki.KeyChar);
                    Console.Write(cki.KeyChar);
                } else {
                    Console.Write("\a"); //Warning sound
                    //Console.Beep();
                }
            }
            Console.WriteLine(calculateBracket(sb.ToString()));
            return 0;
        }

        public bool isValidChar(char ch) {
            for (int i = 0; i < validChar.Length; i++) if (ch == validChar[i]) return true; //I want fu**ing lambda
            return false;
        }

        public string calculateBracket(string equation) {
            int deep = 0;
            int currentBracket = -1;
            int deeperBracketStart = 0;
            int deeperBracketEnd = -1;

            for(int i = 0; i < equation.Length; i++) {
                if(equation[i] == BRACKET_START) { // (
                    deep++;
                    if(deep > currentBracket) {
                        currentBracket = deep;
                        deeperBracketStart = i;
                        deeperBracketEnd = -1;
                    }
                } else if(equation[i] == BRACKET_END) { // )
                    if(deep == currentBracket && deeperBracketEnd == -1) {
                        deeperBracketEnd = i;
                    }
                    deep--;
                }
                if(deep < 0)
                    return "{ERROR}"; //Bracket Error
            }
            if(deep > 0) return "{ERROR}"; //Bracket Error

            if(currentBracket == -1) {
                return calculate(equation);
            } else {
                return calculateBracket(equation.Substring(0, deeperBracketStart) + calculate(equation.Substring(deeperBracketStart + 1, deeperBracketEnd - (deeperBracketStart + 1))) + equation.Substring(deeperBracketEnd + 1, equation.Length - (deeperBracketEnd + 1)));
            }
        }

        public string calculate(string equation) {
            List<int> priorityOperations = new List<int>();
            for(int i = 0; i < equation.Length; i++)
                if(equation[i] == MULTIPLY) {
                    int[] result = calculateRange(equation, i);
                    Double fNum = getDoubleFromEquation(equation, result[0], result[1]);
                    Double bNum = getDoubleFromEquation(equation, result[2], result[3]);
                    return calculate(equation.Substring(0, result[0]) + (fNum * bNum).ToString() + equation.Substring(result[3], equation.Length - result[3]));
                } else if(equation[i] == DIVISION) {
                    int[] result = calculateRange(equation, i);
                    Double fNum = getDoubleFromEquation(equation, result[0], result[1]);
                    Double bNum = getDoubleFromEquation(equation, result[2], result[3]);
                    return calculate(equation.Substring(0, result[0]) + (fNum / bNum).ToString() + equation.Substring(result[3], equation.Length - result[3]));
                }
            for(int i = 0; i < equation.Length; i++)
                if(equation[i] == ADD) {
                    int[] result = calculateRange(equation, i);
                    Double fNum = getDoubleFromEquation(equation, result[0], result[1]);
                    Double bNum = getDoubleFromEquation(equation, result[2], result[3]);
                    return calculate(equation.Substring(0, result[0]) + (fNum + bNum).ToString() + equation.Substring(result[3], equation.Length - result[3]));
                } else if(equation[i] == MINUS) {
                    int[] result = calculateRange(equation, i);
                    Double fNum = getDoubleFromEquation(equation, result[0], result[1]);
                    Double bNum = getDoubleFromEquation(equation, result[2], result[3]);
                    return calculate(equation.Substring(0, result[0]) + (fNum - bNum).ToString() + equation.Substring(result[3], equation.Length - result[3]));
                }
            return equation;
        }

        public int[] calculateRange(string equation, int index) {
            int[] indexs = new int[4]; //front start, end, back start, end
            indexs[1] = index;
            indexs[2] = index + 1;

            int i = 0;
            while(index + --i >= 0 && isNumber(equation[index + i])); //No contents LOL
            indexs[0] = index + i + 1;

            i = 0;
            while(index + ++i < equation.Length && isNumber(equation[index + i]));
            indexs[3] = index + i;

            return indexs;
        }

        public Double getDoubleFromEquation(string equation, int startIndex, int endIndex) {
            return Double.Parse(equation.Substring(startIndex, endIndex - startIndex));
        }

        public bool isNumber(char ch) {
            if(ch == '.') return true; //(ex 12.4)

            try {
                int.Parse(ch.ToString()); //I know stupid but annoying
            }catch(Exception e) {
                return false;
            }
            return true;
        }

        public bool isSign(char ch) {
            return ch == ADD || ch == MINUS || ch == MULTIPLY || ch == DIVISION;
        }
    }
}
