using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMath;
namespace Interpretator_config
{
    public class Config
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

                    /*case "M":
                    {
                    M m = M.Create(input);
                    return m;

                    }
                    default:
                    { break; }*/
            }
            return null;
        }

        public static Math_Field operands(string name, Math_Field[] input)
        {
            /* switch (name)
            {
            case "ABS":
            {

            }
            case "(-1)":
            {

            }
            case "DIF":
            {

            }
            case "LED":
            {

            }
            case "deg":
            {

            }

            case "Down":
            {

            }
            case "up":
            {

            }
            default:
            { break; }
            }*/
            return null;
        }

    }
}

