using System;
using System.Collections.Generic;

namespace Math_Module
{
    public class N : Math_Field
    {

        #region Поля

        private List<uint> znach;

        private const uint uint_size = 99999999;
        private const uint uint_size_div = 8;

        #endregion

        #region Конструторы

        public N(List<string> s) // Александр Рассохин 9370
        {
            znach = new List<uint>();
            for (int i = s.Count-1; i >= 0; i--)
                znach.Add(Convert.ToUInt32(s[i]));
        }

        #endregion

        #region Свойства

        protected override bool isDown // Евгений Куликов 9370
        {
            get
            {
                return false;
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
           for (int i = 0; i < value.znach.Count; i++)
           {
                if (value.znach[i] == uint_size)
                {
                    value.znach[i] = 0;
                }
                else
                {
                    value.znach[i]++;
                    return value;
                }
           }
            value.znach.Add(1);
            return value;
        }

        public static N operator +(N first, N second) // Шлемин Роман 9370
        {
            return null;
        }

        public static N operator -(N first, N second) // Шлемин Роман 9370
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
            List<string> S = new List<string>();
            System.Text.StringBuilder temp = new System.Text.StringBuilder();  // временная переменная для записи разрядов

            for (int i = value.znach.Count - 1; i >= 0; i--)            // Цикл идет с конца списка до первого элемента
            {
                temp.Append(Convert.ToString(value.znach[i]));          // Запись элемента списка во временную переменную
                int size = temp.Length; 
                if (size != uint_size_div && i != value.znach.Count - 1) // Если кол-во разрядов меньше чем нужно   
                {
                    temp.Clear();
                    for (int k = 0; k<uint_size_div - size; k++)        // Добавление нулей для заполнения разрядов
                        temp.Append("0");

                    temp.Append(Convert.ToString(value.znach[i]));  
                }
                S.Add(Convert.ToString(temp));  // Присваивание временной переменной элементу списка
                temp.Clear();
            }
            return S;
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

        public N Clone() // Александр Баталин 9370
        {
            return null;
        }

        #endregion
    }
}
