using System;
using System.Collections.Generic;

namespace Math_Module
{
    public class N : Math_Field
    {

        #region Поля
        private List<uint> znach;
        #endregion

        #region Конструторы

        public N(List<string> s)
        {

        }

        #endregion

        #region Свойства

        protected override bool isDown
        {
            get
            {
                return Convert.ToBoolean(new Exception());
            }
        }

        private bool NZER_N_B
        {
            get
            {
                if ((znach.count == 1)&&(znach[0] == 0))
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

        public static N operator ++(N value) //ADD_1N_N
        {
            return null;
        }

        public static N operator +(N first, N second) //ADD_NN_N
        {
            switch(COM_NN_D(first, second))
            {
                case 0:
                    bigger = new N(second);
                    smaller = new N(first);
                    break;
                case 1:
                    bigger = new N(second);
                    smaller = new N(first);
                    break;
                case 2:
                    bigger = new N(first);
                    smaller = new N(second);
                    break;
            }
            for (int i = 0; i < smaller.znach.Count; i++)
            {
                bigger.znach[i] = bigger.znach[i] + smaller.znach[i];
                if (bigger.znach[i] > uint_size)
                {
                    bigger.znach[i] = bigger.znach[i] - uint_size - 1;
                    if (i != (smaller.znach.Count - 1))
                    {
                        bigger.znach[i+1] += 1;
                    }
                    else
                    {
                        bigger.znach.Add(1);
                    }
                }
            }
            return bigger;
        }

        public static N operator -(N first, N second) //SUB_NN_N
        {
            if (first.znach.Count >= second.znach.Count)
            {
                newfirst = new N(first);
                for (int i = (second.znach.Count - 1); i >= 0; i--)
                {
                    if (newfirst.znach[i] < second.znach[i])    //i-ая строка 1-ого поля меньше
                    {
                        if (i == (newfirst.znach.Count - 1))     //условие при котором невозможно из 1 числа вычесть 2 с положительным остатком
                        {
                            return null;
                        }
                        else
                        {
                            newfirst.znach[i] = unit_size + 1 - second.znach[i];    //вычитаем из i-ой строки 1-ого поля i-ую строку 2-ого поля
                            for (int j = i; newfirst.znach[j] == 0; j++)        //находим строку значение в которой 1-ого поля отлично от нуля
                            {
                                newfirst.znach[j] = uint_size;      //забираем один разряд, недостаточный для вычитания i-ой строки 2-го поля из 1-ого
                            }
                            if (newfirst.znach[newfirst.znach.Count - 1] == 0)      //проверка на наличия в начале поля незначащего нуля
                            {
                                newfirst.znach.RemoveAt(newfirst.znach.Count - 1);
                            }
                        }
                    }
                    if (newfirst.znach[i] > second.znach[i])
                    {
                        newfirst.znach[i] = newfirst.znach[i] - second.znach[i];
                    }
                    if (newfirst.znach[i] == second.znach[i])
                    {
                        newfirst.znach.RemoveAt(i);
                    }
                }
                return newfirst;
            }
            else
            {
                return null;
            }
        }

        public static N operator *(N first, N second) //MUL_NN_N
        {
            return null;
        }

        public static N operator /(N first, N second) //DIV_NN_N
        {
            return null;
        }

        public static N operator %(N first, N second) //MOD_NN_N
        {
            return null;
        }

        public static implicit operator List<string>(N value)
        {
            return null;
        }

        public static implicit operator Z(N value)
        {
            return null;
        }

        #endregion

        #region Методы

        private static byte COM_NN_D(N first, N second)
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

        private N MUL_ND_N(byte value)
        {
            return null;
        }

        private N MUL_Nk_N(N value)
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
