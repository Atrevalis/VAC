using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Module
{
    public class Z : Math_Field
    {
        #region Конструкторы

        public Z(List<string> s)
        {

        }

        public Z(N value) // Александр Рассохин 9370 // Проверено Игорь

        {
            Abs = new N(value);
            isN = true;
        }

        #endregion

        #region Поля

        private N Abs;
        private bool isN;

        #endregion

        #region Свойства

        public override bool isDown // Евгений Куликов 9370
        {
            get
            {
                return Convert.ToBoolean(new Exception());
            }
        }

        public N ABS_Z_N // Евгений Куликов 9370
        {
            get
            {
                return new N(Abs);
            }
        }

        public byte POZ_Z_D // Евгений Куликов 9370
        {
            get
            {
                return 0;
            }
        }

        #endregion

        #region Перегрузки

        public static Z operator -(Z value) // MUL_ZM_Z Евгений Куликов 9370
        {
            return null;
        }

        public static Z operator +(Z first, Z second) // ADD_ZZ_Z Александр Баталин 9370
        {
            Z sum = first.Clone();
            if(first.isN != second.isN)
            {
                if (N.COM_NN_D(first.Abs, second.Abs) == 2)
                {
                    sum.Abs -= second.Abs;
                }
                else
                {
                    sum.Abs = second.Abs - first.Abs;
                    sum.isN = second.isN;
                }
            }
            else
                sum.Abs += second.Abs;
            return sum;
        }

        public static Z operator -(Z first, Z second) // SUB_ZZ_Z Александр Баталин 9370
        {
            return null;
        }

        public static Z operator *(Z first, Z second) // MUL_ZZ_Z
        {
            return null;
        }

        public static Z operator /(Z first, Z second) // DIV_ZZ_Z
        {
            return null;
        }

        public static Z operator %(Z first, Z second) // MOD_ZZ_Z
        {
            return null;
        }

        public static implicit operator List<string>(Z value)
        {
            return null;
        }

        public static implicit operator Q(Z value)
        {
            return null;
        }

        public static explicit operator N(Z value)
        {
            return null;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == GetType() && this != null && obj != null)
            {
                Z sec = obj as Z;
                if (Abs.Equals(sec.Abs) && isN.Equals(sec.isN)) return true;
            }
            return false;
        }

        #endregion

        #region Методы

        public Z Clone() // Александр Баталин 9370
        {
            Z clone = new Z(new List<string>());
            clone.Abs = Abs.Clone();
            clone.isN = isN; 
            return clone;
        }


        #endregion
    }
}
