﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Module
{
    public struct M
    {
        public Q coef;
        public N degree;

        public M(Q c, N s)
        {
            coef = null;
            degree = null;
        }
    }

    public class P:Math_Field
    {
        #region Конструкторы

        public P(List<List<string>[]> s)
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

        public override bool isDown
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
                M now;
                now = this.Ms[0];
                return now.coef;
            }
        }

        public N DEG_P_N
        {
            get
            {
                M now;
                now = this.Ms[0];
                return now.degree;
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
                P result = this.Clone();
                List<string> zero = new List<string>();
                zero.Add("0");
                N usl = new N(zero);
                if (N.COM_NN_D(result.Ms[Ms.Count() - 1].degree, usl) == 0)
                {
                    result.Ms.RemoveAt(Ms.Count() - 1);
                }
                List<string> odin = new List<string>();
                odin.Add("1");
                N one = new N(odin);
                M now;
                for (int i = result.Ms.Count() - 1; i > 0; i--)
                {
                    result.Ms.Insert(i, Ms[i]);
                    now = result.Ms[i];
                    now.coef *= (Z)now.degree;
                    now.degree -= one;
                    result.Ms[i] = now;
                    result.Ms.RemoveAt(i + 1);
                }
                return result;
            }
        }

        #endregion

        #region Перегрузки

        public static P operator +(P first, P second) // ADD_PP_P
        {
            P result;
            P smaller;
            if (first.Ms.Count() < second.Ms.Count())
            {
                result = second.Clone();
                smaller = first.Clone();
            }
            else
            {
                result = first.Clone();
                smaller = second.Clone();
            }
            M now;
            for (int i = 0; i < smaller.Ms.Count(); i++)
            {
                for (int j = 0; j < result.Ms.Count(); j++)
                {
                    if (N.COM_NN_D(result.Ms[j].degree, smaller.Ms[i].degree) == 0)
                    {
                        now = result.Ms[j];
                        now.coef += smaller.Ms[i].coef;
                        result.Ms[j] = now;
                        break;
                    }
                    if (N.COM_NN_D(result.Ms[j].degree, smaller.Ms[i].degree) == 1)
                    {
                        result.Ms.Insert(j, smaller.Ms[i]);
                        break;
                    }
                }
            }
            return result;
        }

        public static P operator -(P first, P second) // SUB_PP_P
        {
            P result;
            P smaller;
            if (first.Ms.Count() < second.Ms.Count())
            {
                result = second.Clone();
                smaller = first.Clone();
            }
            else
            {
                result = first.Clone();
                smaller = second.Clone();
            }
            M now;
            for (int i = 0; i < smaller.Ms.Count(); i++)
            {
                now = smaller.Ms[i];
                now.coef = -now.coef;
                smaller.Ms[i] = now;
            }
            result += smaller;
            return result;
        }

        public static P operator *(P first, P second) // MUL_PP_P
        {
            P result;
            P smaller;
            if (first.Ms.Count() < second.Ms.Count())
            {
                result = second.Clone();
                smaller = first.Clone();
            }
            else
            {
                result = first.Clone();
                smaller = second.Clone();
            }
            M now;
            for (int i = 0; i < smaller.Ms.Count(); i++)
            {
                now = smaller.Ms[i];
                result = result.MUL_PQ_P(now.coef);
                result = result.MUL_Pxk_P(now.degree);
            }
            return result;
        }

        public static P operator /(P first, P second) // DIV_PP_P
        {
            P dividend = first.Clone();
            P result = null;
            P mnoj = null;
            M now;
            M smaller_now;
            M dividend_now;
            int i = 0;
            if (dividend.Ms.Count() >= second.Ms.Count())
            {
                while (dividend.Ms.Count() < second.Ms.Count())
                {
                    dividend_now = dividend.Ms[0];
                    smaller_now = second.Ms[i];
                    now.coef = dividend_now.coef / smaller_now.coef;
                    now.degree = dividend_now.degree - smaller_now.degree;
                    result.Ms.Add(now);
                    mnoj.Ms.Add(now);
                    dividend -= (second * mnoj);
                    mnoj.Ms.RemoveAt(0);
                    i++;
                }
            }
            else
            {
                M nol;
                List<string> zero = new List<string>();
                zero.Add("0");
                N q = new N(zero);
                nol.coef = (Z)q;
                nol.degree = q;
                result.Ms.Add(nol);
            }
            return result;
        }

        public static P operator %(P first, P second) // MOD_PP_p
        {
            P result = first.Clone();
            result -= (first / second);
            return result;
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

        public static byte COM_PP_D(P first, P second)
        {
            M odin;
            M nol;
            List<string> zero = new List<string>();
            zero.Add("0");
            N q = new N(zero);
            odin.degree = q;
            nol.degree = q;
            nol.coef = (Z)q;
            List<string> one = new List<string>();
            one.Add("1");
            N l = new N(one);
            odin.coef = (Z)l;
            P menche = null;
            menche.Ms.Add(nol);
            P bolshe = null;
            bolshe.Ms.Add(odin);
            if ((first / second) == menche)
            {
                return 1;
            }
            if ((first / second) == bolshe)
            {
                if ((first % second) == menche)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                return 2;
            }
        }

        private P MUL_PQ_P(Q value)
        {
            P mulcoef = Clone();
            M now;
            for (int i = 0; i < mulcoef.Ms.Count; i++)
            {
                now = mulcoef.Ms[i];
                now.coef *= value;
                mulcoef.Ms[i] = now;
            }
            return mulcoef;
        }

        private P MUL_Pxk_P(N value)
        {
            return null;
        }

        public static P GCF_PP_P(P first, P second)
        {
            return null;
        }

        private P NMR_P_P()
        {
            List<P> mnoj = null;
            P now = this.Clone();
            P i = null;
            List<string> zero = new List<string>();
            zero.Add("0");
            N q = new N(zero);
            List<string> one = new List<string>();
            one.Add("1");
            N l = new N(one);
            N f;
            M there;
            M last = now.Ms[now.Ms.Count() - 1];
            P hero;
            M x1;
            M x0;
            x1.coef = (Z)l;
            x1.degree = l;
            x0.coef = (Z)l;
            x0.degree = q;
            N z = new N(zero);
            M srav;
            srav.coef = (Z)z;
            srav.degree = z;
            P srav1 = null;
            P srav2 = null;
            srav1.Ms.Add(srav);
            M g;
            g.coef = (Z)q;
            g.degree = q;
            P c = null; //nol?
            c.Ms.Add(g);
            P v = null; //odin?
            v.Ms.Add(x0);
            List<string> del = new List<string>();
            if (last.degree != q)
            {
                f = last.degree;
                for (int a = 0; a < now.Ms.Count(); a++)
                {
                    there = now.Ms[a];
                    there.degree -= f;
                    now.Ms[a] = there;
                }
            }
            srav2.Ms.Add(last);
            while (now.DER_P_P.Ms.Count() > 1)
            {
                while (COM_PP_D(srav1, srav2) == 1)
                {
                    del.Clear();
                    srav1 += v;
                    if ((srav1 % srav2) == c)
                    {
                        hero = srav1;
                        if (now % hero == c)
                        {
                            now /= hero;
                            i = hero;
                            hero.Ms.Clear();
                            for (int j = 0; j < mnoj.Count(); j++)
                            {
                                if (COM_PP_D(i, mnoj[j]) == 0)
                                {
                                    break;
                                }
                                if ((COM_PP_D(i, mnoj[j]) != 0) && (j == (mnoj.Count() - 1)))
                                {
                                    mnoj.Add(i);
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            P result = mnoj[0];
            for (int s = 1; s < mnoj.Count(); s++)
            {
                result *= mnoj[s];
            }
            return result;
        }
        
        public P Clone() // Александр Баталин 9370//
        {
            P clone = new P(new List<List<string>[]>());
            clone.Ms = new List<M>(Ms);
            return clone;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == GetType() && this != null && obj != null)
            {
                P sec = obj as P;
                if (Ms.Equals(sec.Ms)) return true;
            }
            return false;
        }


        #endregion
    }
}
