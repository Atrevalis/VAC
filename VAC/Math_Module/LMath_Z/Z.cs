using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMath
{
    public class Z : Math_Field
    {
        #region Конструкторы
        /// <summary>
        /// Конструктор класса Z
        /// </summary>
        /// <param name="s">Строка разбитая по <c>uint_size_div</c> элементов с возможным "-" в первом элементе</param>
        public Z(List<string> s)
        {
            try
            {
                if (s[0].Contains("-") && s[0].Length != 1)
                {
                    s[0] = s[0].Remove(0, 1);
                    isN = false;
                }
                else if (s[0].Contains("-") && s[0].Length == 1)
                {
                    s.RemoveAt(0);
                    isN = false;
                }
                else
                    isN = true;
                    Abs = new N(s);
            }
            catch
            {
                throw;
            }
        }

       /* public Z(N value) // Александр Рассохин 9370 // Проверено Игорь
        {
            Abs = value.Clone();
            isN = true;
        }
        */

        #endregion

        #region Поля

        /// <summary>
        /// Модуль числа
        /// </summary>
        private N Abs;

        /// <summary>
        /// 
        /// </summary>
        private bool isN;

        #endregion

        #region Свойства

        public override Math_Field ABS // Евгений Куликов 9370//есть тесты  
        {
            get
            {
                return Abs.Clone();
            }
        }

        public byte POZ_Z_D // Евгений Куликов 9370//есть тесты
        {
            get
            {
                List<string> s = new List<string>();
                s.Add("0");
                if (Abs.COM(new N(s)) == 0)
                {
                    return 0;
                }
                if (isN)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }


        #endregion

        #region Перегрузки

        public static Z operator -(Z value) // MUL_ZM_Z Евгений Куликов 9370//есть тесты
        {
            Z Clone = value.Clone();
            Clone.isN = !Clone.isN;
            return Clone;
        }

        public static Z operator +(Z first, Z second) // ADD_ZZ_Z Александр Баталин 9370//есть тесты
        {
            Z sum = first.Clone();
            if(first.isN != second.isN)
            {
                if (first.Abs.COM(second.Abs) == 2)
                {
                    sum.Abs -= second.Abs;
                }
                else
                {
                    sum.Abs = second.Abs - first.Abs;
                    sum.isN = second.isN;
                }
            }
            else
                sum.Abs += second.Abs;
            return sum;
        }

        public static Z operator -(Z first, Z second) // SUB_ZZ_Z Александр Баталин 9370 //есть тесты 
        {
            return first + (-second);
        }

        public static Z operator *(Z first, Z second) // MUL_ZZ_Z//есть тесты
        {
            Z mult = first.Clone();
            mult.Abs *= second.Abs;
            if (first.isN != second.isN)
            {
                mult.isN = false;
            }
            else
            {
                mult.isN = true;
            } 
            return mult;
        } 

        public static Z operator /(Z first, Z second) // DIV_ZZ_Z //есть тесты
        {
            Z res = first.Clone(); //задём временную переменную
            res.isN = true;
            if (second.POZ_Z_D != 0)
            {
                res.Abs /= second.Abs; //выполняем деление
                if (first.isN != second.isN)
                    res.isN = false; //присваимваем знак в случае их различия у делителя и делимого
                return res; //возвращаем div
            }
            else
                return null;
        }

        public static N operator %(Z first, Z second) // MOD_ZZ_Z //есть тесты
        {
            Z Trash = first.Clone();
            List<string> nol = new List<string>();
            nol.Add("0");
            N pog = new N(nol);
            List<string> odin = new List<string>();
            odin.Add("1");
            N one = new N(odin);
            if (second.POZ_Z_D != 0)
            {
                if (first.Abs.COM(second.Abs) == 2)
                {
                    if (first.isN == true && second.isN == true)
                    {
                        Trash = first - (first / second) * second;
                    }
                    if (first.isN == true && second.isN == false)
                    {
                        Trash = first - (first / second) * second;
                    }
                    if (first.isN == false && second.isN == false)
                    {
                        Trash = first - ((first / second) + one) * second;
                    }
                    if (first.isN == false && second.isN == true)
                    {
                        Trash = first - ((first / second) - one) * second;
                    }
                    return (N)Trash;
                }

                else return pog;
            }
            else return null;
        
        }

        public static Z operator ^(Z first, N second)
        {
            Z baze = first.Clone();
            N degree = second.Clone();
            List<string> s = new List<string>();
            List<string> r = new List<string>();
            s.Add("2");
            r.Add("1");
            N temp = new N(s);
            N one = new N(r);
            Z result = one;  
            result.Abs = baze.Abs ^ degree;
            if (baze.isN == false)
            {
                if (degree.COM(temp) == 1)
                {
                    result.isN = false;
                    return result;
                }
                else
                {
                    result.isN = true;
                    return result;
                }
            }
            else
            {
                return result;
            }
        }

        public static implicit operator List<string>(Z value)//есть тесты
        {
            List<string> S = value.Abs;
            
            if (value.isN == false)
            {
                if (S[0].Length < N.uint_size_div)
                {
                    System.Text.StringBuilder temp = new System.Text.StringBuilder();
                    temp.Append(Convert.ToString("-"));
                    temp.Append(Convert.ToString(S[0]));
                    S[0] = Convert.ToString(temp);
                }
                else if (S[0].Length == N.uint_size_div)
                    S.Insert(0, "-");
            }
            return S;
        }

        public static explicit operator N(Z value) // Александр Рассохин //есть тесты
        {
            if (!value.isDown)
                return null;
            else
                return value.Abs.Clone();
        }

        public static implicit operator Z(N value)
        {
            return new Z(value);
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == GetType() && this != null && obj != null)
            {
                Z sec = obj as Z;
                if (Abs.Equals(sec.Abs) && isN.Equals(sec.isN)) return true;
            }
            return false;
        }

        #endregion

        #region Методы

        public Z Clone() // Александр Баталин 9370 //есть тесты
        {
            Z clone = new Z(Abs.Clone());
            clone.isN = isN; 
            return clone;
        }

        #endregion

        #region Общие свойства и методы

        #region Свойства

        public override int id
        {
            get
            {
                return 2;
            }
        }

        public override bool isDown // Евгений Куликов 9370//есть тесты
        {
            get
            {
                return isN;
            }
        }

        public override Math_Field DEG
        {
            get
            {
                List<string> s = new List<string>();
                s.Add("0");
                return new Z(s);
            }
        }

        public override Math_Field DER
        {
            get
            {
                List<string> s = new List<string>();
                s.Add("0");
                return new Z(s);
            }
        }
        public override Math_Field UNT
        {
            get
            {
                return -this;
            }
        }

        public override Math_Field LED
        {
            get
            {
                return Clone();
            }
        }


        #endregion

        #region Методы

        public override Math_Field ADD(Math_Field second)
        {
            return this + (second as Z);
        }

        public override Math_Field MUL(Math_Field second)
        {
            return this * (second as Z);
        }

        public override Math_Field Dawn()
        {
            return (N)this;
        }

        public override byte COM(Math_Field second)
        {
            Z per1 = this.Clone();
            Z per2 = second as Z;
            byte srav = per1.Abs.COM(per2.Abs);
            if (per1.isDown != per2.isDown)
            {
                if (per2.isDown)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                if (srav == 0)
                {
                    return 0;
                }
                else
                {
                    if (per1.isDown)
                    {
                        return srav;
                    }
                    else
                    {
                        if (srav == 1)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        public override Math_Field LCM(Math_Field second)
        {
            return Abs.LCM((second as Z).Abs);
        }

        public override Math_Field SUB(Math_Field second)
        {
            return this - (second as Z);
        }

        public override Math_Field MOD(Math_Field second)
        {
            return this % (second as Z);
        }

        public override Math_Field GCF(Math_Field second)
        {
            // N f = this.Abs.GCF((second as Z).Abs);
            return (Z)(Abs.GCF((second as Z).Abs) as N);
        }

        public override Math_Field DIV(Math_Field second)
        {
            return this / (second as Z);
        }

        public override List<string> ToListstring()
        {
            return this;
        }

        #endregion

        #endregion
    }
}
