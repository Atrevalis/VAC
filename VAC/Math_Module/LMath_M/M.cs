using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMath
{
    public class M:Math_Field
    {

        #region Поля

        private P[,] elements;

        private int h;

        #endregion

        #region Конструторы

        /// <summary>
        /// Конструктор класса M
        /// </summary>
        public M(int x, int y, List<P> p) // Александр Рассохин 9370
        {
            elements = new P[y, x];
            for(int i = 0; i < y; i++)
            {
                for(int j = 0; j <  x; j++)
                {
                    elements[i, j] = p[i * x + j];
                }
            }
            h = y;
        }

        public M(int x, int y)
        {
            elements = new P[y, x];
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    elements[i, j] = new P();
                }
            }
            h = y;
        }

        public M(int x, int y, int d)
        {
            elements = new P[y, x];
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    elements[i, j] = new P(d);
                }
            }
            h = y;
        }

        #endregion

        #region Свойства

        private int w
        {
            get
            {
                return elements.Length / h;
            }
        }

        public bool isSquere
        {
            get
            {
                return w == h ? true : false;
            }
        }

        #endregion

        #region Перегрузки

        public static M operator -(M value)//избавится от корявости (когда P заработает)
        {
            M m = value.Clone() as M;
            for(int i = 0; i < m.h; i++)
            {
                for(int j = 0; j < m.w; j++)
                {
                    m.elements[i, j] -= m.elements[i, j] + m.elements[i, j];
                }
            }
            return m;
        }

        public static M operator +(M first, M second) // Шлемин Роман 9370 Есть тесты
        {
            M m = first.Clone() as M;
            for (int i = 0; i < m.h; i++)
            {
                for (int j = 0; j < m.w; j++)
                {
                    m.elements[i, j] += second.elements[i, j];
                }
            }
            return m;
        }



        public static M operator -(M first, M second) // Шлемин Роман 9370//Есть тесты
        {
            return first + (-second);
        }

        public static M operator *(M first, M second) // Шлемин Роман 9370 //тест есть 
        {
            if (first.w == second.h)
            {
                M product = new M(first.h, second.w);
                for (int i = 0; i < product.h; i++)
                {
                    for (int j = 0; j < product.w; j++)
                    {
                        for(int k = 0; k < first.w; k++)
                        {
                            product.elements[i, j] += (first.elements[i, k] * second.elements[k, j]);
                        }
                    }
                }
            }
            return null;
        }

        public static M operator /(M first, M second)//    //Есть тесты
        {
            M clone = first.Clone() as M;
            M del = second.Reverse();
            if (del == null) return null;
            clone *= del;
            return clone;
        }

        public static M operator %(M first, M second)//есть тесты
        {
            return null;
        }


        public static implicit operator List<string>(M value) // Александр Рассохин 9370//есть тесты
        {
            return null;
        }


        public override bool Equals(object obj)
        {
            if (obj.GetType() == GetType() && this != null && obj != null)
            {
                M sec = obj as M;
                if(h == sec.h && w == sec.w)
                {
                    for(int i = 0; i < h; i++)
                    {
                        for(int j = 0; j < w; j++)
                        {
                            if(!elements[i,j].Equals(sec.elements[i,j]))
                            {
                                return false;
                            }
                        }
                    }
                    return true;
                }
            }
            return false;
        }


        #endregion

        #region Методы

        /// <summary>
        /// Создает точную копию данного объекта
        /// </summary>
        public override Math_Field Clone() // Александр Баталин 9370//есть тесты
        {
            M clone = new M(h, w);
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    clone.elements[i, j] = elements[i, j].Clone() as P;
                }
            }
            return clone;
        }

        public M Reverse()
        {
            if (h != w)
            {
                return null;
            }
            M oneness = new M(h, w, 1);
            P now;
            P elem = new P();
            P zero = new P();
            M original = this.Clone() as M;
            for (int i = 0; i < h; i++)
            {
                now = original.elements[i, i];
                for (int k = 0; k < h; k++)
                {
                    for (int j = 0; j < w; j++)
                    {
                        if ((elem.COM(zero) == 0) && (original.elements[k, j].COM(zero) != 0) && (j >= i))
                        {
                            elem = original.elements[k, j];
                        }
                        original.elements[i, j] /= now;
                        oneness.elements[i, j] /= now;
                        original.elements[k, j] -= original.elements[i, j] * elem;
                        oneness.elements[k, j] -= oneness.elements[i, j] * elem;
                    }
                    elem = zero;
                }
            }
            return oneness;
        }

        #endregion

        #region Событие

        #endregion

        #region Общие методы и свойства

        #region Свойства

        public override int id
        {
            get
            {
                return 6;
            }
        }

        public override bool isDown // Евгений Куликов 9370 / Тест есть
        {
            get
            {
               return  h == 1 && w == 1 ? true : false;
            }
        }

        public override Math_Field ABS
        {
            get
            {
                M clone = new M(h, w);
                for (int i = 0; i < h; i++)
                {
                    for (int j = 0; j < w; j++)
                    {
                        clone.elements[i, j] = elements[i, j].ABS as P;
                    }
                }
                return clone;
            }
        }

        public override Math_Field LED
        {
            get
            {
                return null;
            }
        }

        public override Math_Field UNT
        {
            get
            {
                return -this;
            }
        }

        public override Math_Field DEG
        {
            get
            {
                return null;
            }
        }

        public override Math_Field DER
        {
            get
            {
                M clone = new M(h, w);
                for (int i = 0; i < h; i++)
                {
                    for (int j = 0; j < w; j++)
                    {
                        clone.elements[i, j] = elements[i, j].DER as P;
                    }
                }
                return clone;
            }
        }

        public override Math_Field ANT
        {
            get
            {
                M clone = new M(h, w);
                for (int i = 0; i < h; i++)
                {
                    for (int j = 0; j < w; j++)
                    {
                        clone.elements[i, j] = elements[i, j].ANT as P;
                    }
                }
                return clone;
            }
        }

        #endregion

        #region Методы


        public override Math_Field LCM(Math_Field second)
        {
            return null;
        }

        public override Math_Field SUB(Math_Field second)
        {
            return this - (second as M);
        }

        public override Math_Field MUL(Math_Field second)
        {
            return this * (second as M);
        }

        public override Math_Field Dawn()
        {
            if(isDown)
            {
                return elements[0, 0].Clone();
            }
            return this;
        }

        public static M Create(string s)
        {
            string[] str = s.Split('_');
            M result = new M(str[0].Split('|').Length, str.Length);
            for (int y = 0; y < result.h; y++)
            {
                string[] elements = str[y].Split('|');
                for (int x = 0; x < result.elements.Length/result.h; x++)
                {
                    result.elements[y, x] = P.Create(elements[x]);
                }
            }
            return result;
        }

        public override byte COM(Math_Field second)
        {
            return Equals(second) ? (byte)0 : (byte)4;
        }

        public override Math_Field DIV(Math_Field second)
        {
            return this / (second as M);
        }

        public override Math_Field MOD(Math_Field second)
        {
            return this % (second as M);
        }

        public override Math_Field REM(Math_Field second)
        {
            return null;
        }

        public override Math_Field GCF(Math_Field second)
        {
            return null;
        }

        public override Math_Field ADD(Math_Field second)
        {
            return this + (second as M);
        }

        public override List<string> ToListstring()
        {
            return null;
        }

        public override Math_Field CEI(Math_Field first, Math_Field second)
        {
            M clone = new M(h, w);
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                   clone.elements[i, j] = (ANT.RES((second as M).elements[i,j]) as P) - (ANT.RES((first as M).elements[i,j]) as P);
                }
            }
            return clone;
        }

        public override Math_Field RES(Math_Field value)
        {
            M clone = new M(h, w);
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    clone.elements[i, j] = RES(value as P) as P;
                }
            }
            return clone;
        }
        #endregion        

        #endregion
    }
}
