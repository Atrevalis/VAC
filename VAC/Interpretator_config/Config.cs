using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMath;
namespace Interpretator_config
{
    public static class Config
    {
        public static Math_Field builder(string name, string input)
        {// конструктор экземпляров классов по входным данным

            switch (name)
            {
                case "N":
                    {
                        N n = N.Create(input);
                        return n;
                    }
                case "Z":
                    {
                        Z z = Z.Create(input);
                        return z;
                    }
                case "Q":
                    {
                        Q q = Q.Create(input);
                        return q;
                    }
                case "P":
                    {
                        P p = P.Create(input);
                        return p;
                    }
                case "C":
                    {
                        C c = C.Create(input);
                        return c;
                    }

                    case "M":
                    {
                     M m = M.Create(input);
                    return m;

                    }

                    default:
                    { break; }

                   

            }
            return null;
        }

        public static Math_Field operands(string name, Math_Field[] input)
        {
            Math_Field interval;
            switch (name)
            {
                case "ABS"://унарные операторы
                    { return input[0].ABS; }
                case "(-1)":
                    {
                        return input[0].UNT;
                    }
                case "DIF":
                    {
                        return input[0].DER;
                    }
                case "LED":
                    {
                        return input[0].LED;
                    }
                case "deg":
                    {
                        return input[0].DEG;
                    }

                case "Down":
                    {
                        return input[0].Dawn();
                    }
                case "up":
                    {
                        return input[0].External_Up();
                    }//унарные операторы
                case "-"://бинарные операторы
                    {
                        return input[0].SUB(input[1]);
                    }
                case "/":
                    {
                        return input[0].DIV(input[1]);
                    }
                case "%":
                    {
                        return input[0].REM(input[1]);
                    }
                case "MOD":
                    {
                        return input[0].MOD(input[1]);
                    }
                case "RES":
                    {
                        return input[0].RES(input[1]);
                    }//бинарные операторы

                case "CEI"://тернарные операторы
                    {
                        return input[0].CEI(input[1], input[2]);
                    }
                case "+"://n-нарные операторы
                    {
                        
                        interval = input[0];
                        for (int i = 1; i < input.Length; i++)
                        {
                                interval = interval.ADD(input[i]);
                        }
                        return interval;
                        
                    }
                case "*":
                    {
                        interval = input[0];
                        for (int i = 1; i < input.Length; i++)
                        {
                            interval = interval.MUL(input[i]);
                        }
                        return interval;
                    }
                case "НОД":
                    {
                        interval = input[0];
                        for (int i = 1; i < input.Length; i++)
                        {
                            interval = interval.GCF(input[i]);
                        }
                        return interval;
                    }
                case "НОК"://n-нарные операторы
                    {
                        interval = input[0];
                        for (int i = 1; i < input.Length; i++)
                        {
                            interval = interval.LCM(input[i]);
                        }
                        return interval;
                    }
            }
            return null;
        }

        public static byte logic(string name, Math_Field[] input)
        {
            switch (name) {
                case "COM_NN_D":
                    {
                        switch (input[0].COM(input[1])) {
                            case 0: { return 1; }
                            case 1: { return 2; }
                            case 2: { return 0; }
                        }
                        break;
                        
                    }
                case "isDown":
                    {
                        if (input[0].isDown)
                        {
                            return 0;
                        }
                        return 1;

                    }
            }
            return 4;

        }
    }
}

