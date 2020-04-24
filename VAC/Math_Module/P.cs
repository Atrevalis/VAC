using System;
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
            coef = c;
            degree = s;
        }
    }

    public class P : Math_Field
    {
        #region Конструкторы

        
        public P(List<List<string>[]> s)
        {
            List<string> n = new List<string>();
            List<string> d = new List<string>();
            List<string> temp = new List<string>();
            M test = new M();
            int j = 0;
            int k;
            for (int i=0; i < s.Count;i++)
            {
                for (k = 0; s[i][j][k] != "/"; k++)
                    n.Add(s[i][j][k]);
                for (k += 1; k < s[i][j].Count; k++)
                    d.Add(s[i][j][k]);

                test.coef = new Q(n, d);
                test.degree = new N(s[i][j + 1]);
                Ms.Add(test);
                n.Clear();
                d.Clear();
            }
        }
        

        public P(List<M> M)
        {
            try
            {
               Ms = new List<M>();
               M temp = new M();
               M t = new M();

               int check;
            for (int i= 0; i < M.Count; i++)
            {
                temp = M[i];
                check = i;
                for (int j = i; j < M.Count; j++)
                {
                    if (N.COM_NN_D(temp.degree, M[j].degree) == 2)
                        continue;
                    else if (N.COM_NN_D(temp.degree, M[j].degree) == 1)
                    {
                        temp = M[j];
                        check = j;
                    }
                    else if (N.COM_NN_D(temp.degree, M[j].degree) == 0)
                        continue;
                }

                if (check != i)
                {
                    t = M[i];
                    M[i] = temp;
                    M[check] = t;
                }
            }

            for (int i = 0; i < M.Count; i++)
                Ms.Add(M[i]);
            }
            catch { throw; }
        }
        
        

        public P(Q value)
        {
            List<string> s = new List<string>();
            s.Add("0");
            N a = new N(s);
            Ms = new List<M>();
            Ms.Add(new M(value, a));
        }

        #endregion

        #region Поля

        List<M> Ms;

        #endregion

        #region Свойства

        protected override int id
        {
            get
            {
                return 4;
            }
        }

        public override bool isDown
        {
            get
            {
                List<string> S = new List<string>();
                S.Add("0");
                N a = new N(S);
                if (Ms.Count == 1 && Ms[0].degree == a)
                    return true;
                else
                    return false;
            }
        }

        public override Math_Field LED // return Q
        {
            get
            {
                M now;
                now = this.Ms[0];
                return now.coef;
            }
        }

        public override Math_Field DEG // return N
        {
            get
            {
                M now;
                now = this.Ms[0];
                return now.degree;
            }
        }

        public override Math_Field FAC // return Q
        {
            get
            {
                return null;
            }
        }

        public override Math_Field ABS
        {
            get
            {
                P clone = Clone();
                for(int i = 0; i < Ms.Count; i++)
                {
                    Q now = clone.Ms[i].coef;
                    now = Ms[i].coef.ABS as Q;
                }
                return clone;
            }
        }


        public override Math_Field DER // retutn P
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

        public override Math_Field UNT
        {
            get
            {
                P clone = Clone();
                for(int i = 0; i < clone.Ms.Count; i++)
                {
                    Q clones = clone.Ms[i].coef; 
                    clones = -clone.Ms[i].coef;
                }
                return clone;
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
        /*
        public static implicit operator List<List<string>[]>(P value)
        {
            List<List<string>[]> S = new List<List<string>[]>();
            List<string> []temp = new List<string>[2];
            List<string> t = new List<string>();
            List<string> t2 = new List<string>();
            for (int i=0; i < value.Ms.Count;i++)
            {
                temp[0] = new List<string>();
                temp[1] = new List<string>();
                t = value.Ms[i].coef;
                t2 = value.Ms[i].degree;
                for (int j = 0; j < t.Count; j++)
                    temp[0].Add(t[j]);
                for (int j = 0; j < t2.Count; j++)
                    temp[1].Add(t2[j]);
                S.Add(temp);
            }
            return S;
        }
                    */

        public static implicit operator List<string>(P value)
        {
            List<string> list = new List<string>();
            for(int i = 0; i < value.Ms.Count; i++)
            {
                List<string> num = new List<string>(), denum = new List<string>(), zero = new List<string>();
                num.Add("1"); denum.Add("1"); zero.Add("0");
                if (value.Ms[i].coef.COM(new Q(num, denum)) != 0)
                {
                    if (value.Ms[i].coef.POZ_Q_D == 1) ;
                    else if (i > 0) list.Add(" +");
                    for (int j = 0; j < ((List<string>)value.Ms[i].coef).Count; j++)
                    {
                        list.Add(((List<string>)value.Ms[i].coef)[j]);
                    }
                }
                if (value.Ms[i].degree.COM(new N(num)) == 0) list.Add("x");
                else
                {
                    if (value.Ms[i].degree.COM(new N(zero)) != 0)
                    {
                        list.Add("x^");
                        for (int j = 0; j < ((List<string>)value.Ms[i].degree).Count; j++)
                        {
                            list.Add(((List<string>)value.Ms[i].degree)[j]);
                        }
                    }
                }
            }
            return list;
        }


        public static explicit operator Q(P value)//сломано
        {
            if (value.isDown)
            {
                List<string> S = new List<string>();
                List<string> n = new List<string>();
                List<string> d = new List<string>();

                S = value.Ms[0].coef;
                int i;
                for (i = 0; S[i] != "/"; i++)
                    n.Add(S[i]);
                for (i += 1; i < S.Count; i++)
                    d.Add(S[i]);

                return new Q(n, d);

            }
            else
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
            P muldeg = Clone();
            M now;
            for (int i = 0; i < muldeg.Ms.Count; i++)
            {
                now = muldeg.Ms[i];
                now.degree += value;
                muldeg.Ms[i] = now;
            }
            return muldeg;
        }

        public static P GCF_PP_P(P first, P second)
        {
            P result = first.Clone();
            P pog = null;
            P mod = first.Clone();
            mod = first % second;
            M nol;
            List<string> zero = new List<string>();
            zero.Add("0");
            N q = new N(zero);
            nol.coef = (Z)q;
            nol.degree = q;
            pog.Ms.Add(nol);
            if (COM_PP_D(mod, pog) == 0)
            {
                return second;
            }
            else
            {
                while (COM_PP_D(mod, pog) != 0)
                {
                    second %= mod;
                    result = mod;
                    mod %= second;
                }
            }
            return result;
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
            while ((now.DER as P).Ms.Count() > 1)
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
            P clone = new P(new Q(new Z(new N(new List<string>()))));
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

        public override Math_Field ADD(Math_Field second)
        {
            return this + (second as P);
        }

        public override Math_Field MOD(Math_Field second)
        {
            return this % (second as P);
        }

        public override Math_Field DIV(Math_Field second)
        {
            return this / (second as P);
        }

        public override Math_Field GCF(Math_Field second)
        {
            return GCF_PP_P(this, second as P);
        }

        public override Math_Field LCM(Math_Field second)
        {
            return null;
        }

        public override Math_Field MUL(Math_Field second)
        {
            return this * (second as P);
        }

        public override byte COM(Math_Field second)
        {
            return COM_PP_D(this, second as P);
        }

        public override Math_Field SUB(Math_Field second)
        {
            return this - (second as P);
        }

        public override Math_Field Dawn()
        {
            return (Q)this;
        }

        public override Math_Field Up()
        {
            return this;
        }

        public override List<string> ToListstring()
        {
            return this;
        }


        #endregion
    }
}
