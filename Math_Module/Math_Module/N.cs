using System;
using System.Collections.Generic;

namespace Math_Module
{
    class N : Math_Field
    {

        #region Поля
        private List<uint> znach;
        #endregion

        #region Констркуторы

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
                return Convert.ToBoolean(new Exception());
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
            return null;
        }

        public static N operator -(N first, N second) //SUB_NN_N
        {
            return null;
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
