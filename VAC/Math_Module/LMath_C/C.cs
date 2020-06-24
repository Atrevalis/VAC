using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMath
{
    public class C : Math_Field
    {
        #region Конструкторы

        public C(Q r, Q i)
        {
            real = r.Clone() as Q;
            image = i.Clone() as Q;
        }

        public C()
        {
            real = new Q();
            image = new Q();
        }

        public C(int d)
        {
            real = new Q(d);
            image = new Q();
        }

        public C(int r, int i, bool t)
        {
            real = new Q(r);
            image = new Q(i);
        }

        #endregion

        #region Поля
        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        private Q real;
        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        private Q image;

        #endregion

        #region Свойства

        public C Conjugation
        {
            get
            {
                C c = Clone() as C;
                c.image = -c.image;
                return c;
            }
        }

        #endregion

        #region Перегрузки

        public static C operator -(C value)
        {
            C clone = value.Clone() as C;
            clone.real = -clone.real;
            clone.image = -clone.image;
            return clone;
        }

        public static C operator +(C first, C second)
        {
            C clone1 = first.Clone() as C;
            C clone2 = second.Clone() as C;
            clone1.real += clone2.real;
            clone1.image += clone2.image;
            return clone1;
        }

        public static C operator -(C first, C second)
        {
            C clone1 = first.Clone() as C;
            C clone2 = second.Clone() as C;
            return clone1 + (-clone2);
        }

        public static C operator *(C first, C second)
        {
            C clone1 = first.Clone() as C;
            clone1.real = first.real * second.real - first.image * second.image;
            clone1.image = first.real * second.image + first.image * second.real;
            return clone1;
        }

        public static C operator /(C first, C second)
        {
            C clone1 = first.Clone() as C;
            C clone2 = second.Clone() as C;
            clone2.image = -clone2.image;
            clone1 *= clone2;
            clone1.real /= clone2.real * clone2.real + clone2.image * clone2.image;
            clone1.image /= clone2.real * clone2.real + clone2.image * clone2.image;
            return clone1;
        }

        public static implicit operator C(Q value)
        {
            C result = new C();
            result.real = value.Clone() as Q;
            return result;
        }

        public static explicit operator Q(C value)
        {
            return value.real.Clone() as Q;
        }

        public static C operator ^(C first, Q second)
        {
            C clone = first.Clone() as C;
            if (second.isDown)
            {
                switch (second.COM(new Q()))
                {
                    case 0:
                        {
                            return new C(1);
                        }
                    case 1:
                        {
                            clone.real = first.real ^ new Q(-1);
                            clone.image = first.image ^ new Q(-1);
                            goto case 2;
                        }
                    case 2:
                        {
                            for (Q i = new Q(); i.COM(second.ABS as Q) == 1; i += new Q(1))
                            {
                                clone *= clone;
                            }
                        }
                        break;
                }
                return clone;
            }
            else
            {
                return null;
            }
        }

        public static C operator ^(C first, C second)
        {
            if (second.isDown)
            {
                return first ^ (Q)second;
            }
            return null;
        }

        #endregion

        #region Методы

        /// <summary>
        /// Создает точную копию данного объекта
        /// </summary>
        public override Math_Field Clone()
        {
            C result = new C();
            result.real = real.Clone() as Q;
            result.image = image.Clone() as Q;
            return result;
        }

        public static Math_Field Antiderivative_event_do(Math_Field value)
        {
            return ((C)(value as Q)).ANT;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == GetType() && this != null && obj != null)
            {
                C sec = obj as C;
                if (real.Equals(sec.real) && image.Equals(sec.image)) return true;
            }
            return false;
        }

        #endregion

        #region Событие

        public delegate Math_Field Antiderivative_delegate(Math_Field value);

        public static event Antiderivative_delegate Antiderivative_event;

        #endregion

        #region Общие свойства и методы

        #region Свойства
        public override int id
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
                Q zero = new Q();
                if (image.COM(zero) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public override Math_Field ABS
        {
            get;
        }

        public override Math_Field UNT
        {
            get
            {
                return -this;
            }
        }

        public override Math_Field DER
        {
            get
            {
                return new C();
            }
        }

        public override Math_Field LED
        {
            get
            {
                return Clone();
            }
        }

        public override Math_Field DEG
        {
            get
            {
                return new C();
            }
        }

        public override Math_Field ANT
        {
            get
            {
                return Antiderivative_event(this);
            }
        }

        #endregion

        #region Методы


        public override Math_Field Dawn()
        {
            if (isDown)
            {
                return (Q)(this);
            }
            return this;
        }

        public static C Create(string s)
        {
            bool isI = false;
            C result = new C();
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == 'i') isI = true;
                if (s[i] == '+' || s[i] == '-')
                {
                    s = s.Replace(" ", "");
                    bool flag1 = s[0] == '-';
                    bool flag2 = true;
                    if (!flag1)
                    {
                        s = s.Remove(0, 1);
                    }
                    for (int j = 0; j < s.Length; j++)
                    {
                        if (s[j] == '-')
                        {
                            flag2 = false;
                            s = s.Replace('-', '+');
                            break;
                        }
                    }
                    string[] first = s.Split('+');
                    if (first[0][0] == 'i' || first[0][first[0].Length - 1] == 'i')
                    {
                        first[0] = first[0].Replace("i", "");
                        result.image = Q.Create(first[0]);
                        if (flag1) result.image = -result.image;
                        result.real = Q.Create(first[1]);
                        if (!flag2) result.real = -result.real;
                    }
                    else
                    {
                        first[1] = first[1].Replace("i", "");
                        result.image = Q.Create(first[1]);
                        if (!flag2) result.image = -result.image;
                        result.real = Q.Create(first[0]);
                        if (flag1) result.real = -result.real;
                    }
                    return result;
                }
            }
            if (isI)
            {
                s = s.Replace("i", "");
                result.image = Q.Create(s);
            }
            else
            {
                result.real = Q.Create(s);
            }
            return result;
        }


        public override Math_Field SUB(Math_Field second)
        {
            return this - (second as C);
        }

        public override Math_Field DIV(Math_Field second)
        {
            return this / (second as C);
        }

        public override Math_Field MOD(Math_Field second)
        {
            return new C();
        }

        public override Math_Field REM(Math_Field second)
        {
            return null;
        }

        public override Math_Field ADD(Math_Field second)
        {
            return this + (second as C);
        }

        public override Math_Field MUL(Math_Field second)
        {
            return this * (second as C);
        }

        public override Math_Field GCF(Math_Field second)
        {
            return null;
        }

        public override Math_Field LCM(Math_Field second)
        {
            return null;
        }

        public override byte COM(Math_Field second)
        {
            if (real.Equals((second as C).real) && image.Equals((second as C).image))
            {
                return 0;
            }
            else return 4;
        }

        public override List<string> ToListstring()
        {
            List<string> s = real.ToListstring();
            if (image.COM(new Q()) != 1)
            {
                s.Add(" + ");
            }
            List<string> s2 = image.ToListstring();
            for (int i = 0; i < s2.Count; i++)
            {
                s.Add(s2[i]);
            }
            return s;
        }

        public override Math_Field CEI(Math_Field first, Math_Field second)
        {
            try
            {
                return (ANT.RES(second) as C) - (ANT.RES(first) as C);
            }
            catch
            {
                return null;
            }
        }

        public override Math_Field RES(Math_Field value)
        {
            return this;
        }
        #endregion
        #endregion
    }
}