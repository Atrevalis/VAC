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
            try
            {
                Numerator = new Z(first);
                Denominator = new N(second);
                RED_Q_Q();
            }
            catch
            {
                throw;
            }
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

        protected override int id
        {
            get
            {
                return 3;
            }
        }

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

        public Z Num
        {
            get
            {
                return Numerator.Clone();
            }
        }

        public N Den
        {
            get
            {
                return Denominator.Clone();
            }
        }

        public byte POZ_Q_D// есть тесты
        {
            get
            {
                 if (Numerator.POZ_Z_D != 0)
                {
                    if (Numerator.POZ_Z_D == 2)
                        return 2;
                    else
                        return 1;
                }
                else
                    return 0;
            }
        }

        public override Math_Field ABS
        {
            get
            {
                Q clone = Clone();
                clone.Numerator = clone.Numerator.ABS as Z;
                return clone;
            }
        }

        public override Math_Field DEG
        {
            get
            {
                return ((P)this).DEG;
            }
        }

        public override Math_Field UNT
        {
            get
            {
                return -this;
            }
        }

        public override Math_Field DER
        {
            get
            {
                return ((P)this).DER;
            }
        }

        public override Math_Field FAC
        {
            get
            {
                return ((P)this).FAC;
            }
        }

        public override Math_Field LED
        {
            get
            {
                return ((P)this).LED;
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
                    first.Numerator *= (ComDen / first.Denominator);
                    second.Numerator *= (ComDen / second.Denominator);
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

        public static Q operator /(Q first, Q second) // DIV_QQ_Q // есть тесты
        {
            Q divider = null;
            Q result = first.Clone();
            divider.Denominator = second.Numerator.ABS as N;
            divider.Numerator = second.Denominator;
            if (divider.Numerator.isDown != second.Numerator.isDown)
            {
                divider = - divider;
            }
            result *= divider;
            result.RED_Q_Q();
            return result;
        }

        public static N operator %(Q first, Q second)//есть тесты
        {
            List<string> nol = new List<string>();
            nol.Add("0");
            N pog = new N(nol);
            return pog;
        }
        
        public static implicit operator List<string>(Q value)//есть тесты
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

        public static implicit operator P(Q value)//
        {
            return new P(value);
        }

        public static explicit operator Z(Q value)//есть тесты
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
                #endregion

        #region Методы 

        private void RED_Q_Q() //есть тесты
        {
            N nod = N.GCF_NN_N(Numerator.ABS as N, Denominator);
            Numerator /= nod;
            Denominator /= nod;
        }
        
        public Q Clone() // Александр Баталин 9370//есть тесты
        {
            Q clone = new Q(Numerator.Clone());
            clone.Denominator = Denominator.Clone();
            return clone;
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

        public override Math_Field MUL(Math_Field second)
        {
            return this * (second as Q);
        }

        public override Math_Field DIV(Math_Field second)
        {
            return this / (second as Q);
        }

        public override Math_Field ADD(Math_Field second)
        {
            return this + (second as Q);
        }

        public override Math_Field LCM(Math_Field second)
        {
            List<string> s = new List<string>();
            s.Add("0");
            N zero = new N(s);
            return zero;
        }

        public override Math_Field Dawn()
        {
            return (Z)this;
        }

        public override Math_Field Up()
        {
            return (P)this;
        }

        public override Math_Field SUB(Math_Field second)
        {
            return this - (second as Q);
        }

        public override Math_Field MOD(Math_Field second)
        {
            return this % (second as Q);
        }

        public override byte COM(Math_Field second)
        {
            Q per2 = second as Q;
            Q per1 = this.Clone();
            N nok;
            nok = N.LCM_NN_N(per2.Denominator, per1.Denominator);
            per2.Numerator *= (nok / per2.Denominator);
            per1.Numerator *= (nok / per1.Denominator);
            per2.Denominator = nok;
            per1.Denominator = nok;
            return per1.Numerator.COM(per2.Numerator);
        }

        public override Math_Field GCF(Math_Field second)
        {
            return ((P)this).GCF((P)second);
        }


        #endregion
    }
}
