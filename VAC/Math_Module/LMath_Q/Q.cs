using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMath
{
    public class Q:Math_Field
    {
        #region Конструкторы


        /// <summary>
        /// Конструирует объект типа Q
        /// </summary>
        /// <param name="first">Числитель в формате целого числа</param>
        /// <param name="second">Знасенатель в формате целого (положительного числа)</param>
        public Q(List<string> first, List<string> second)///нет исключения - Знаменатель не может быть равен нулю 
        {
            try
            {
                Numerator = new Z(first);
                Denominator = new Z(second);
                RED_Q_Q();
            }
            catch
            {
                throw;
            }
        }

        public Q()
        {
            Numerator = new Z();
            Denominator = new Z(1);
        }

        public Q(int d)
        {
            Numerator = new Z(d);
            Denominator = new Z(1);
        }

        #endregion

        #region Поля

        /// <summary>
        /// Числитель
        /// </summary>
        private Z Numerator;
        /// <summary>
        /// Знаменатель
        /// </summary>
        private Z Denominator;

        #endregion

        #region Свойства 

        /// <summary>
        /// Проверяет является ли число целым
        /// </summary>
        bool INT_Q_B//тест идет вместе с isDown 
        {
            get
            {
                List<string> one = new List<string>();
                one.Add("1");
                if (Denominator.COM(new Z(one)) == 0)
                    return true;
                else
                    return false;
            }
        }

        /// <summary>
        /// Сравнивает рациональное число с нулем
        /// <para />
        /// 0 если число равнл нулю
        /// <para />
        /// 1 если отрицательно
        /// <para />
        /// 2 если положительно
        /// </summary>
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
            Q clone = second.Clone();
            Q Sum = first.Clone();
            Z ComDen = first.Denominator.Clone();
            if (first.Denominator.COM(second.Denominator) == 0)
            {
                Sum.Numerator = first.Numerator + second.Numerator;
                Sum.RED_Q_Q();
                return Sum;
            }
            else
            {
                ComDen = (first.Denominator.LCM(second.Denominator) as Z);
                clone.Numerator *= (ComDen / clone.Denominator);
                Sum.Numerator *= (ComDen / Sum.Denominator);
                Sum.Numerator += clone.Numerator;
                Sum.Denominator = ComDen;
                return Sum;
            }
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
            Q divider = second.Clone();
            Q result = first.Clone();
            divider.Denominator = second.Numerator.Clone();
            divider.Numerator = second.Denominator.Clone();
            if (divider.Denominator.isDown == false)
            {
                divider.Numerator = - divider.Numerator;
                divider.Denominator = -divider.Denominator;
            }
            result *= divider;
            if (result.Denominator.COM(new Z()) == 0) return null;
            result.RED_Q_Q();
            return result;
        }

        public static Z operator %(Q first, Q second)//есть тесты
        {
            List<string> nol = new List<string>();
            nol.Add("0");
            Z pog = new Z(nol);
            return pog;
        }

        public static Q operator ^(Q first, Z second)
        {
            Q result = first.Clone();
            if(second.POZ_Z_D == 1)
            {
                result.Numerator = first.Denominator.Clone();
                result.Denominator = first.Numerator.Clone();
            }
            result.Numerator = result.Numerator ^ second;
            result.Denominator = result.Denominator ^ second;
            return result;
        }

        public static implicit operator List<string>(Q value)//есть тесты
        {
            List<string> one = new List<string>();
            one.Add("1");
            List<string> S = new List<string>();
            List<string> temp = new List<string>();
            temp = value.Numerator;
            S.AddRange(temp);
            if (value.Denominator.COM(new Z(one)) != 0)
            {
                S.Add("/");
                temp = value.Denominator;
                S.AddRange(temp);
            }

            return S;
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

        public static implicit operator Q(Z value)
        {
            List<string> s = new List<string>();
            s.Add("1");
            return new Q(value, s);
        }
                #endregion

        #region Методы 

        /// <summary>
        /// Скоращает дробь
        /// </summary>
        private void RED_Q_Q() //есть тесты
        {
            if (Numerator.COM(new Z()) != 0)
            {
                Z nod = (Z)(Numerator.GCF(Denominator));
                Numerator /= nod;
                Denominator /= nod;
            }
            else
            {
                Denominator = new Z(1);
            }
        }

        public static Math_Field Antiderivative_event_do(Math_Field value)
        {
            return ((Q)(value as Z)).ANT;
        }

        /// <summary>
        /// Создает точную копию данного объекта
        /// </summary>
        public Q Clone() // Александр Баталин 9370//есть тесты
        {
            Q clone = new Q(Numerator.Clone(), Denominator.Clone());
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

        #endregion

        #region Событие

        public delegate Math_Field Antiderivative_delegate(Math_Field value);

        public static event Antiderivative_delegate Antiderivative_event;

        #endregion

        #region Общие свойства и методы

        #region Свойства

        public override int id
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
                List<string> s1 = new List<string>();
                s1.Add("0");
                List<string> s2 = new List<string>();
                s2.Add("1");
                return new Q(s1, s2);
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
                List<string> s1 = new List<string>();
                s1.Add("0");
                List<string> s2 = new List<string>();
                s2.Add("1");
                return new Q(s1, s2);
            }
        }

        public override Math_Field LED
        {
            get
            {
                return Clone();
            }
        }

        public override Math_Field ANT
        {
            get
            {
                return Antiderivative_event(this);
            }
        }

        #endregion

        #region Методы

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
            return null;
        }

        public override Math_Field Dawn()
        {
            return (Z)this;
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
            Q per1 = Clone();
            Z nok;
            nok = (Z)per2.Denominator.LCM(per1.Denominator);
            per2.Numerator *= (nok / per2.Denominator);
            per1.Numerator *= (nok / per1.Denominator);
            per2.Denominator = nok;
            per1.Denominator = nok;
            return per1.Numerator.COM(per2.Numerator);
        }

        public override Math_Field GCF(Math_Field second)
        {
            return null;
        }

        public override List<string> ToListstring()
        {
            return this;
        }

        public override Math_Field CEI(Math_Field first, Math_Field second)
        {
            try
            {
                return (ANT.RES(second) as Q) - (ANT.RES(first) as Q);
            }
            catch
            {
                return null;
            }
        }

        public override Math_Field RES(Math_Field value)
        {
            return this;
        }
        #endregion

        #endregion
    }
}
