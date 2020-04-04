using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Module
{
    public class Q:Math_Field
    {
        #region Конструкторы

        public Q(List<string> first, List<string> second)///нет исключения - Знаменатель не может быть равен нулю 
        {
            Numerator = new Z(first);
            Denominator = new N(second);
        }
        public Q(Z value)
        {
            Numerator = value.Clone();
            List<string> S = new List<string>();
            S.Add("1");
            Denominator = new N(S);
        }

        #endregion

        #region Поля

        private Z Numerator;
        private N Denominator;

        #endregion

        #region Свойства 

        public override bool isDown//есть тесты
        {
            get
            {
                return INT_Q_B;
            }
        }

        bool INT_Q_B//тест идет вместе с isDown 
        {
            get
            {
                List<string> one = new List<string>();
                one.Add("1");
                if (N.COM_NN_D(Denominator, new N(one)) == 0)
                    return true;
                else
                    return false;
            }
        }

        public byte POZ_Q_D// есть тесты
        {
            get
            {
                 if (INT_Q_B == true)
                 {
                    if (Numerator.POZ_Z_D == 2)
                        return 1;
                    else if (Numerator.POZ_Z_D == 1)
                        return 2;
                    else
                        return 0;
                 }
                else
                    return 0;
            }
        }

        #endregion

        #region Перегрузки 


        public static Q operator -(Q value) // MUL_QM_Q //есть тесты
        {
            Q Clone = value.Clone();
            Clone.Numerator = -Clone.Numerator;
            return Clone; 
        }

        public static Q operator +(Q first, Q second) // ADD_QQ_Q //есть тесты
        {
            Q Sum = first.Clone();
            N ComDen = first.Denominator.Clone();
            if (N.COM_NN_D(first.Denominator, second.Denominator) == 0)
            {
                Sum.Numerator = first.Numerator + second.Numerator;
                Sum.RED_Q_Q();
                return Sum;
            }
            else
            {
                ComDen = N.LCM_NN_N(first.Denominator, second.Denominator);
                if (N.COM_NN_D(first.Denominator, ComDen) == 0)
                {
                    Sum.Denominator = first.Denominator;
                    second.Numerator *= (first.Denominator / second.Denominator);
                    Sum.Numerator = first.Numerator + second.Numerator;
                }
                if (N.COM_NN_D(second.Denominator, ComDen) == 0)
                {
                    Sum.Denominator = second.Denominator;
                    first.Numerator *= (second.Denominator / first.Denominator);
                    Sum.Numerator = first.Numerator + second.Numerator;
                }
                if (N.COM_NN_D(first.Denominator, ComDen) != 0 && N.COM_NN_D(second.Denominator, ComDen) != 0)
                {
                    Sum.Denominator = ComDen;
                    first.Numerator *= second.Denominator;
                    second.Numerator *= first.Denominator;
                    Sum.Numerator = first.Numerator + second.Numerator;
                }
                Sum.RED_Q_Q();
            }
            return Sum;
        }

        public static Q operator -(Q first, Q second) // SUB_QQ_Q //есть тесты
        {
            Q result;
            result = first + (-second);
            result.RED_Q_Q();
            return result;
        }

        public static Q operator *(Q first, Q second) // MUL_QQ_Q //есть тесты
        {
            Q result = first.Clone();
            result.Denominator *= second.Denominator;
            result.Numerator *= second.Numerator;
            result.RED_Q_Q();
            return result;
        }

        public static Q operator /(Q first, Q second) // DIV_QQ_Q // 
        {
            Q divider = null;
            Q result = first.Clone();
            divider.Denominator = second.Numerator.ABS_Z_N;
            divider.Numerator = second.Denominator;
            if (divider.Numerator.isDown != second.Numerator.isDown)
            {
                divider = - divider;
            }
            result *= divider;
            result.RED_Q_Q();
            return result;
        }

        public static N operator %(Q first, Q second)
        {
            return null;
        }
        
        public static implicit operator List<string>(Q value)
        {
            List<string> S = new List<string>();
            List<string> temp = new List<string>();
            temp = value.Numerator;
            S.AddRange(temp);
            S.Add("/");
            temp = value.Denominator;
            S.AddRange(temp);

            return S;
        }

        public static implicit operator P(Q value)
        {
            return new P(value);
        }

        public static explicit operator Z(Q value)
        {
            if (value.isDown)
            {
                return  value.Numerator.Clone();
            }
            else
            {
                return null;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == GetType() && this != null && obj != null)
            {
                Q sec = obj as Q;
                if (Denominator.Equals(sec.Denominator) && Numerator.Equals(sec.Numerator)) return true;
            }
            return false;
        }

                #endregion

        #region Методы 

        public void RED_Q_Q() //есть тесты
        {
            N nod = N.GCF_NN_N(Numerator.ABS_Z_N, Denominator);
            Numerator /= nod;
            Denominator /= nod;
        }
        
        public Q Clone() // Александр Баталин 9370//
        {
            Q clone = new Q(Numerator.Clone());
            clone.Denominator = Denominator.Clone();
            return clone;
        }

        #endregion
    }
}
