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

        public Q(List<string> s)
        {

        }

        public Q(Z value)
        {

        }

        #endregion

        #region Поля

        private Z ch;//NUMERATOR
        private N zn;//DENOMINATOR

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
            return null;
        }

        public static Q operator *(Q first, Q second) // MUL_QQ_Q
        {
            return null;
        }

        public static Q operator /(Q first, Q second) // DIV_QQ_Q
        {
            return null;
        }

        public static implicit operator List<string>(Q value)
        {
            return null;
        }

        public static implicit operator P(Q value)
        {
            return null;
        }

        public static explicit operator Z(Q value)
        {
            return null;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == GetType() && this != null && obj != null)
            {
                Q sec = obj as Z;
                if (ch.Equals(sec.ch) && zn.Equals(sec.zn)) return true;
            }
            return false;
        }

                #endregion

        #region Методы 

        private void RED_Q_Q()
        {

        }

        #endregion
    }
}
