using System;
using System.Collections.Generic;

namespace Math_Module
{
    public class N : Math_Field
    {

        #region Поля
        private List<uint> znach;

        const uint uint_size = 99999999;
        #endregion

        #region Конструторы

        public N(List<string> s) // Александр Рассохин 9370
        {

        }

        #endregion

        #region Свойства

        protected override bool isDown // Евгений Куликов 9370
        {
            get
            {
                return Convert.ToBoolean(new Exception());
            }
        }
        private bool NZER_N_B // Проверка на ноль - Шлемин Роман 9370
        {
            get
            {
                if ((znach.Count == 1)&&(znach[0] == 0))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public List<uint> Znach //Необходимость релизации под вопросом
        {
            get
            {
                return null;
            }
        }

        #endregion

        #region Перегрузки

        public static N operator ++(N value) // Александр Баталин 9370
        {
            for (i = 0; i < value.znach.count; i++)
            {
                if(value.znach[i] == uint_size)
                {
                    value.znach[i] = 0;
                    value_s++;
                }
                else if ((value.znach[i] >= 0) && (value.znach[i] < uint_size))
                {
                    value.znach[i]++;
                    return;
                }
            }
        }

        public static N operator +(N first, N second)
        {
            return null;
        }

        public static N operator -(N first, N second)
        {
            return null;
        }

        public static N operator *(N first, N second)
        {
            return null;
        }

        public static N operator /(N first, N second)
        {
            return null;
        }

        public static N operator %(N first, N second)
        {
            return null;
        }

        public static implicit operator List<string>(N value) // Александр Рассохин 9370
        {
            return null;
        }

        public static implicit operator Z(N value)
        {
            return null;
        }

        #endregion

        #region Методы

        private static byte COM_NN_D(N first, N second) // Сравнение двух чисел - Шлемин Роман 9370
        {
            if (first.znach.Count > second.znach.Count)
            {
                return 2;
            }
            if (first.znach.Count < second.znach.Count)
            {
                return 1;
            }
            for (int i = first.znach.Count; i == 0;i--)
            {
                if (first.znach[i] <= second.znach[i])
                    {
                    if (first.znach[i] != second.znach[i])
                    {
                        return 1;
                    }
                }
                else
                {
                    return 2;
                }
            }
            return 0;
        }

        private N MUL_ND_N(byte value) // Умножеине числа на цифру - Дмитрий Панченко 9370
        {
            return null;
        }

        private N MUL_Nk_N(N value) // Умножение числа на 10^value - Дмитрий Панченко 9370
        {
            return null;
        }

        private static N SUB_NDN_N(N first, N second, byte k)
        {
            return null;
        }

        private static N DIV_NN_Dk(N first, N second)
        {
            return null;
        }

        public static N GCF_NN_N(N first, N second)
        {
            return null;
        }

        public static N LCM_NN_N(N first, N second)
        {
            return null;
        }

        #endregion
    }
}
