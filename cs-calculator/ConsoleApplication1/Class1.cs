using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    class Class1 {
        public static void Main2() {
            string formula;
            formula = Console.ReadLine();
            Console.WriteLine("결과 : " + calculateBracket(formula));
            Console.ReadKey();
        }

        static string calculateBracket(string formula) {
            string tempFormula = formula;
            string formulaPattern = @"\([0-9-+*/]+\)";
            string res;

            Match mL = Regex.Match(tempFormula, formulaPattern);
            if(mL.Success) {
                string pattern = @"[0-9-+*/]+";
                Match mS = Regex.Match(Convert.ToString(mL), pattern);
                res = calculateFormula(Convert.ToString(mS));

                tempFormula = tempFormula.Replace(Convert.ToString(mL), res);
                return calculateBracket(tempFormula);
            } else {
                return calculateFormula(tempFormula);
            }
        }

        static string calculateFormula(string formula) {
            string tempFormula = formula;
            string formulaPattern;
            int res = 0;

            if(tempFormula.IndexOf('*') != -1 || tempFormula.IndexOf('/') != -1)
                formulaPattern = @"([-]\d+|\d+)[*/]([-]\d+|\d+)";
            else
                formulaPattern = @"([-]\d+|\d+)[-+]([-]\d+|\d+)";

            Match mL = Regex.Match(tempFormula, formulaPattern);
            if(mL.Success) {
                string pattern = @"(\B[-]\d+)|[-+*/]|(\d+)";
                Match mS = Regex.Match(Convert.ToString(mL), pattern);
                int a;
                int b;
                char OperatorType;

                a = Convert.ToInt32(Convert.ToString(mS));
                mS = mS.NextMatch();
                OperatorType = Convert.ToChar(Convert.ToString(mS));
                mS = mS.NextMatch();
                if(Convert.ToString(mS) == "-") {
                    mS = mS.NextMatch();
                    b = Convert.ToInt32(Convert.ToString(mS)) * -1;
                } else {
                    b = Convert.ToInt32(Convert.ToString(mS));
                }

                switch(OperatorType) {
                case '*':
                    res = a * b;
                    break;
                case '/':
                    res = a / b;
                    break;
                case '+':
                    res = a + b;
                    break;
                case '-':
                    res = a - b;
                    break;
                }
                tempFormula = tempFormula.Replace(Convert.ToString(mL), Convert.ToString(res));
                return calculateFormula(tempFormula);
            } else {
                return tempFormula;
            }
        }
    }
}