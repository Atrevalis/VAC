using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Module
{
    struct M
    {
        Q coaf;
        N step;

        public M(Q c, N s)
        {
            coaf = null;
            step = null;
        }
    }

    public class P:Math_Field
    {
        #region Конструкторы

        public P(List<string> s)
        {

        }

        public P(Q value)
        {

        }

        #endregion

        #region Поля

        List<M> Ms;

        #endregion

        #region Свойства

        protected override bool isDown
        {
            get
            {
                return Convert.ToBoolean(new Exception());
            }
        }

        public Q LED_P_Q
        {
            get
            {
                return null;
            }
        }

        public N DEG_P_N
        {
            get
            {
                return null;
            }
        }

        private Q FAC_P_Q
        {
            get
            {
                return null;
            }
        }

        public P DER_P_P
        {
            get
            {
                return null;
            }
        }

        #endregion

        #region Перегрузки

        public static P operator +(P first, P second) // ADD_PP_P
        {
            return null;
        }

        public static P operator -(P first, P second) // SUB_PP_P
        {
            return null;
        }

        public static P operator *(P first, P second) // MUL_PP_P
        {
            return null;
        }

        public static P operator /(P first, P second) // DIV_PP_P
        {
            return null;
        }

        public static P operator %(P first, P second) // MOD_PP_p
        {
            return null;
        }

        public static implicit operator List<string>(P value)
        {
            return null;
        }

        public static explicit operator Q(P value)
        {
            return null;
        }

        #endregion

        #region Методы

        private P MUL_PQ_P(Q value)
        {
            return null;
        }

        private P MUL_Pxk_P(N value)
        {
            return null;
        }

        public static P GCF_PP_P(P first, P second)
        {
            return null;
        }

        private void NMR_P_P()
        {

        }

        #endregion
    }
}
