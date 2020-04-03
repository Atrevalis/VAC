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

        public Q(List<string> first, List<string> second)
        {

        }
        public Q(Z value)
        {

        }

        #endregion

        #region Поля

        private Z Numerator;
        private N Denominator;

        #endregion

        #region Свойства 

        public override bool isDown
        {
            get
            {
                return Convert.ToBoolean(new Exception());
            }
        }

        bool INT_Q_B
        {
            get
            {
                return Convert.ToBoolean(new Exception());
            }
        }

        public byte POZ_Q_D
        {
            get
            {
                return 0;
            }
        }

        #endregion

        #region Перегрузки 


        public static Q operator -(Q value) // MUL_QM_Q
        {
            return null;
        }

        public static Q operator +(Q first, Q second) // ADD_QQ_Q
        {
            return null;
        }

        public static Q operator -(Q first, Q second) // SUB_QQ_Q
        {
            Q result;
            result = first + (-second);
            result.RED_Q_Q();
            return result;
        }

        public static Q operator *(Q first, Q second) // MUL_QQ_Q
        {
            Q result = first.Clone();
            result.Denominator *= second.Denominator;
            result.Numerator *= second.Numerator;
            result.RED_Q_Q();
            return result;
        }

        public static Q operator /(Q first, Q second) // DIV_QQ_Q
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

        public static Q operator %(Q first, Q second)
        {
            return null;
        }

        public static implicit operator List<string>(Q value)
        {
            return null;
        }

        public static implicit operator P(Q value)
        {
            return new P(value);
        }

        public static explicit operator Z(Q value)
        {
            if (value.isDown)
            {
                return new Z(value.Numerator);
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
                Q sec = obj as Z;
                if (Numerator.Equals(sec.Numerator) && Numerator.Equals(sec.Numerator)) return true;
            }
            return false;
        }

                #endregion

        #region Методы 

        private void RED_Q_Q()
        {

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
