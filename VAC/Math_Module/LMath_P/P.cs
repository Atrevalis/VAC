using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMath
{
    struct M
    {
        public C coef;
        public C degree;

        public M(C c, C s)
        {
            coef = c;
            degree = s;
        }
    }

    public class P : Math_Field
    {
        #region Поля

        private List<M> Ms;

        #endregion

        #region Конструкторы

        public P(int d)
        {
            M m = new M(new C(d), new C());
            Ms = new List<M>();
            Ms.Add(m);
        }

        public P()
        {
            Ms = new List<M>();
        }


        public P(List<List<string>[]> s)
        {
            List<string> n = new List<string>();
            List<string> d = new List<string>();
            List<string> temp = new List<string>();
            M test = new M();
            int j = 0;
            int k;
            for (int i = 0; i < s.Count; i++)
            {
                for (k = 0; s[i][j][k] != "/"; k++)
                    n.Add(s[i][j][k]);
                for (k += 1; k < s[i][j].Count; k++)
                    d.Add(s[i][j][k]);

                //test.coef = new C(n, d);
                //test.degree = new C(s[i][j + 1]);
                Ms.Add(test);
                n.Clear();
                d.Clear();
            }
        }

        private P(List<M> M)
        {
            try
            {
                Ms = new List<M>();
                M t;
                int check;
                for (int i = 0; i < M.Count; i++)
                {
                    check = i;
                    for (int j = i; j < M.Count; j++)
                    {
                        if (M[check].degree.COM(M[j].degree) == 2)
                            continue;
                        else if (M[check].degree.COM(M[j].degree) == 1)
                            check = j;
                        else if (M[check].degree.COM(M[j].degree) == 0)
                            continue;
                    }
                    if (check != i)
                    {
                        t = new M(M[i].coef, M[i].degree);
                        M[i] = M[check];
                        M[check] = t;
                    }
                }
                for (int i = 0; i < M.Count; i++)
                    Ms.Add(M[i]);
            }
            catch { throw; }
        }


        #endregion

        #region Свойства

        public override int id//можно я не буду писать под это тест?я
        {
            get
            {
                return 5;
            }
        }

        public override bool isDown//
        {
            get
            {
                if (Ms.Count == 1 && Ms[0].degree.COM(new C()) == 0)
                {
                    return true;
                }
                return false;
            }
        }


        public List<C> root
        {
            get
            {
                /*
                List<C> otvet = null;
                P now = this.Clone();
                M tek = now.Ms[0];
                C nok = tek.coef.Den;
                for (int i = 1; i <= (now.Ms.Count - 1); i++)
                {
                    tek = now.Ms[i];
                    nok = N.LCM_NN_N(nok, tek.coef.Den);
                }
                List<string> zero = new List<string>();
                zero.Add("0");
                N q = new N(zero);
                M mnoj;
                mnoj.degree = q;
                Q coef = (Z)nok;
                mnoj.coef = coef;
                P norma = null;
                norma.Ms.Add(mnoj);
                now *= norma;
                List<string> one = new List<string>();
                one.Add("1");
                N l = new N(one);
                mnoj.coef = (Z)l;
                mnoj.degree = l;
                P Del = null;
                Del.Ms.Add(mnoj);
                Z odin = l;
                mnoj = now.Ms[now.Ms.Count - 1];
                Z srav = mnoj.coef.Num;
                if (!srav.isDown)
                {
                    srav = -srav;
                }
                mnoj = now.Ms[0];
                Z srav1 = mnoj.coef.Num;
                if (!srav1.isDown)
                {
                    srav1 = -srav1;
                }
                mnoj.degree = q;
                mnoj.coef = (Z)q;
                P ost = null;
                ost.Ms.Add(mnoj);
                Del.Ms.Add(mnoj);
                for (Z j = -srav; j.COM(srav) == 1; j += odin)
                {
                    for (Z f = -srav1; f.COM(srav1) == 1; f += odin)
                    {
                        mnoj.coef = j;
                        mnoj.coef /= f;
                        Del.Ms[1] = mnoj;
                        if (now % Del == ost)
                        {
                            mnoj.coef = -mnoj.coef;
                            otvet.Add(mnoj.coef);
                            now /= Del;
                        }
                    }
                }
                */
                return null;//otvet;
            }
        }



        public override Math_Field LED // return Q
        {
            get
            {
                return Ms[0].coef.Clone();
            }
        }

        public override Math_Field DEG // return N
        {
            get
            {
                return Ms[0].degree.Clone();
            }
        }

        public override Math_Field ABS
        {
            get
            {
                P clone = Clone() as P;
                for (int i = 0; i < Ms.Count; i++)
                {
                    Ms[i] = new M(Ms[i].coef.ABS as C, Ms[i].degree.Clone() as C);
                }
                return clone;
            }
        }

        public override Math_Field DER // retutn P
        {
            get
            {
                P result = null;//tClone();
                C usl = new C(1, 0, true);
                M now;
                for (int i = result.Ms.Count - 1; i > 0; i--)
                {
                    if (result.Ms[i].degree.COM(usl) == 0)
                    {
                        result.Ms.RemoveAt(i);
                        continue;
                    }
                    result.Ms.Insert(i, Ms[i]);
                    now = result.Ms[i];
                    now.coef *= now.degree;
                    now.degree -= new C(1, 0, true);
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
                P clone = Clone() as P;
                for (int i = 0; i < clone.Ms.Count; i++)
                {
                    Ms[i] = new M(-Ms[i].coef, Ms[i].degree.Clone() as C);
                }
                return clone;
            }
        }

        #endregion

        #region Перегрузки

        public static P operator -(P value)
        {
            P clone = value.Clone() as P;
            for (int i = 0; i < clone.Ms.Count; i++)
            {
                clone.Ms[i] = new M(-clone.Ms[i].coef, clone.Ms[i].degree);
            }
            return clone;
        }

        public static P operator +(P first, P second) // ADD_PP_P
        {
            P result = first.Clone() as P;
            for (int i = 0; i < second.Ms.Count; i++)
            {
                for (int j = 0; j < result.Ms.Count; j++)
                {
                    if (second.Ms[i].degree.COM(result.Ms[j].degree) != 2)
                    {
                        if (second.Ms[i].degree.COM(result.Ms[j].degree) == 0)
                        {
                            result.Ms[j] = new M(result.Ms[j].coef + second.Ms[j].coef, result.Ms[j].degree);
                        }
                        else
                        {
                            result.Ms.Insert(j, new M(second.Ms[i].coef, second.Ms[i].degree));
                        }
                        break;
                    }
                }
            }
            return null;
        }

        public static P operator -(P first, P second) // SUB_PP_P
        {
            return first + (-second);
        }

        public static P operator *(P first, P second) // MUL_PP_P
        {
            P result;
            P smaller;
            if (first.Ms.Count() < second.Ms.Count())
            {
                result = second.Clone() as P;
                smaller = first.Clone() as P;
            }
            else
            {
                result = first.Clone() as P;
                smaller = second.Clone() as P;
            }
            M now;
            for (int i = 0; i < smaller.Ms.Count(); i++)
            {
                now = smaller.Ms[i];
            }
            return result;
        }

        public static P operator /(P first, P second) // DIV_PP_P
        {
            return null;
        }

        public static P operator %(P first, P second) // MOD_PP_p
        {
            P result = first.Clone() as P;
            result -= (first / second);
            return result;
        }

        public static implicit operator List<List<string>[]>(P value)
        {
            return null;
        }

        public static implicit operator List<string>(P value)
        {
            return null;
        }

        public static implicit operator P(C value)
        {
            return null;
        }

        public static explicit operator C(P value)//сломано
        {
            if (value.isDown)
            {
                return value.Ms[0].coef.Clone() as C;
            }
            return null;
        }

        #endregion

        #region Методы

        public static byte COM_PP_D(P first, P second)
        {
            M odin;
            M nol;
            C q = new C();
            odin.degree = q;
            nol.degree = q;
            nol.coef = q;
            C l = new C();
            odin.coef = l;
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


        private P MUL_PQ_P(C value)
        {
            P mulcoef = Clone() as P;
            M now;
            for (int i = 0; i < mulcoef.Ms.Count; i++)
            {
                now = mulcoef.Ms[i];
                now.coef *= value;
                mulcoef.Ms[i] = now;
            }
            return mulcoef;
        }

        private P MUL_Pxk_P(C value)
        {
            P muldeg = Clone() as P;
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
            P result = first.Clone() as P;
            P pog = null;
            P mod = first.Clone() as P;
            mod = first % second;
            M nol;
            C q = new C();
            nol.coef = q;
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
            List<C> roots = this.root;
            List<C> answer = null;
            P result = null;
            int i = 0;
            int j;
            while (i < roots.Count)
            {
                for (j = 0; j < answer.Count; j++)
                {
                    if (roots[i].COM(answer[j]) == 0)
                    {
                        break;
                    }
                }
                if (roots[i].COM(answer[j]) == 0)
                {
                    i++;
                    break;
                }
                answer.Add(roots[i]);
                i++;
            }
            C q = new C();
            C l = new C(1);
            M mnoj;
            mnoj.coef = l;
            mnoj.degree = l;
            result.Ms.Add(mnoj);
            mnoj.coef = answer[0];
            mnoj.degree = q;
            result.Ms.Add(mnoj);
            P mnoj1 = result.Clone() as P;
            for (int m = 1; m <= (answer.Count - 1); m++)
            {
                mnoj.coef = answer[m];
                mnoj1.Ms[1] = mnoj;
                result *= mnoj1;
            }
            return result;
        }

        public override Math_Field Clone() // Александр Баталин 9370//
        {
            P clone = new P();
            for (int i = 0; i < Ms.Count; i++)
            {
                clone.Ms.Add(new M(Ms[i].coef.Clone() as C, Ms[i].degree.Clone() as C));
            }
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

        #region Событие

        #endregion

        #region Общие методы и свойства
        public override Math_Field ADD(Math_Field second)
        {
            return this + (second as P);
        }

        public override Math_Field MOD(Math_Field second)
        {
            return this % (second as P);
        }

        public override Math_Field REM(Math_Field second)
        {
            return null;
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

        public override Math_Field RES(Math_Field value)
        {
            C result = new C();
            for (int i = 0; i < Ms.Count; i++)
            {
                result += Ms[i].coef * ((value as C) ^ Ms[i].degree);
            }
            return result;
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
            return (C)this;
        }

        public static P Create(string s)
        {
            List<int[]> skobochki = new List<int[]>();
            List<int[]> otpdox = new List<int[]>();
            List<int[]> otstepdox = new List<int[]>();
            s = s.Replace(" ", "");
            P result = new P();
            C coef = new C();
            C degree = new C();
            string temp = null;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    skobochki.Add(new int[2]);
                    skobochki[skobochki.Count - 1][0] = i;
                }
                if (s[i] == ')')
                {
                    skobochki[skobochki.Count - 1][1] = i;
                }
                if (s[i] == 'x' && (s.Length - 1 == i || s[i + 1] != '^'))
                {
                    s = s.Insert(i, "^1");
                }
                if (s[i] == ')' && (s.Length - 1 == i || s[i + 1] != 'x'))
                {
                    s = s.Insert(i, "x^0");
                }
            }
            for (int i = 0; i < skobochki.Count; i++)
            {
                temp = null;
                string tempbezmip = null;
                for (int j = 0; j < s.Length; j++)
                {
                    if (skobochki[skobochki.Count - i][0] > j && skobochki[skobochki.Count - i][1] < j)
                    {
                        temp = temp.Insert(temp.Length - 1, s[j].ToString());
                    }
                }
                tempbezmip = temp;
                tempbezmip = tempbezmip.Replace('-', '&');
                tempbezmip = tempbezmip.Replace('+', '#');
                s = s.Replace(temp, tempbezmip);
            }

            s = s.Replace("-", "+-");

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '^')
                {
                    otstepdox.Add(new int[2]);
                    otstepdox[otstepdox.Count - 1][0] = i;
                }
                if (s[i] == '+')
                {
                    otpdox.Add(new int[2]);
                    otpdox[otpdox.Count - 1][0] = i;
                    otstepdox[otstepdox.Count - 1][1] = i;
                }
                if (s[i] == 'x')
                {
                    otpdox[otpdox.Count - 1][1] = i;
                }
            }

            s = s.Replace('&', '-');
            s = s.Replace('#', '+');

            for (int i = 0; i < s.Length; i++)
            {
                if (s[0] == 'x')
                {
                    coef = C.Create("1");
                    temp = null;
                    for (int j = 0; j < s.Length; j++)
                    {
                        if (otstepdox[0][0] > j && otstepdox[0][1] < j)
                        {
                            temp.Insert(temp.Length - 1, s[j].ToString());
                        }
                    }
                    degree = C.Create(temp);
                    result.Ms.Add(new M(coef, degree));
                }
                if (s[0] != '(' && s[0] != 'x')
                {
                    temp = null;
                    for (int j = 0; j < s.Length; j++)
                    {
                        if (otstepdox[0][0] - 1 < j)
                        {
                            temp.Insert(temp.Length - 1, s[j].ToString());
                        }
                    }
                    coef = C.Create(temp);
                    temp = null;
                    for (int j = 0; j < s.Length; j++)
                    {
                        if (otstepdox[0][0] > j && otstepdox[0][1] < j)
                        {
                            temp.Insert(temp.Length - 1, s[j].ToString());
                        }
                    }
                    degree = C.Create(temp);
                    result.Ms.Add(new M(coef, degree));
                }
            }
            for (int i = 0; i < otpdox.Count; i++)
            {
                temp = null;
                for (int j = 0; j < s.Length; j++)
                {
                    if (otstepdox[otstepdox.Count - (i + 1)][0] > j && otstepdox[otstepdox.Count - (i + 1)][1] < j)
                    {
                        temp.Insert(temp.Length - 1, s[j].ToString());
                    }
                }
                degree = C.Create(temp);
                temp = null;
                for (int j = 0; j < s.Length; j++)
                {
                    if (otpdox[otpdox.Count - (i + 1)][0] > j && otpdox[otpdox.Count - (i + 1)][1] < j)
                    {
                        temp.Insert(temp.Length - 1, s[j].ToString());
                    }
                }
                coef = C.Create(temp);
                result.Ms.Add(new M(coef, degree));
            }
            return result;
        }

        public override List<string> ToListstring()
        {
            return this;
        }

        public override Math_Field ANT
        {
            get
            {
                P clone = Clone() as P;
                for (int i = 0; i < Ms.Count; i++)
                {

                    Ms[i] = new M(Ms[i].coef / Ms[i].degree + new C(1), Ms[i].degree + new C(1));
                }
                return clone;
            }
        }

        public static Math_Field Antiderivative_event_do(Math_Field value)
        {
            return ((P)(value as C)).ANT;
        }

        public override Math_Field CEI(Math_Field first, Math_Field second)
        {
            try
            {
                return (ANT.RES(second) as P) - (ANT.RES(first) as P);
            }
            catch
            {
                return null;
            }
        }

        #endregion
    }
}