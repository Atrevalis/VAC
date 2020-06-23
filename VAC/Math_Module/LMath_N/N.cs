using System;
using System.Collections.Generic;
using System.Linq;

namespace LMath
{
    public class N : Math_Field
    {

        #region Поля

        /// <summary>
        /// Значение числа
        /// </summary>
        private List<uint> value;

        /// <summary>
        /// Максимальное число, храняшееся в одном элементе <c>value</c>
        /// </summary>
        private const uint uint_size = 999;
        /// <summary>
        /// Максимальное количество разрядов, храняшееся в одном элементе <c>value</c>
        /// </summary>
        public const uint uint_size_div = 3;

        #endregion

        #region Конструторы

        /// <summary>
        /// Конструктор класса N
        /// </summary>
        /// <param name="s">Строка разбитая по <c>uint_size_div</c> элементов</param>
        public N(List<string> s) // Александр Рассохин 9370
        { 
            value = new List<uint>();
            try
            {
                for (int i = s.Count - 1; i >= 0; i--)
                    value.Add(Convert.ToUInt32(s[i]));
            }
            catch
            {
                throw;
            }
        }


        public N()
        {
            value = new List<uint>();
            value.Add(0);
        }

        public N(uint i)
        {
            value = new List<uint>();
            value.Add(i);
        }

        #endregion

        #region Свойства

        /// <summary>
        /// Проверка числа на ноль (true если 0)
        /// </summary>
        private bool NZER_N_B // Проверка на ноль - Шлемин Роман 9370//тест есть(закоммичен)
        {
            get
            {
                if ((value.Count == 1)&&(value[0] == 0))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        #endregion

        #region Перегрузки

        public static N operator ++(N value) // Александр Баталин 9370 / Есть тесты
        {
           for (int i = 0; i < value.value.Count; i++)
           {
                if (value.value[i] == uint_size)
                {
                    value.value[i] = 0;
                }
                else
                {
                    value.value[i]++;
                    return value;
                }
           }
            value.value.Add(1);
            return value;
        }

        public static N operator +(N first, N second) // Шлемин Роман 9370 Есть тесты
        {
            N bigger;
            N smaller;
            if (first.COM(second) != 2)
            {
                bigger = second.Clone();
                smaller = first.Clone();
            }
            else
            {
                bigger = first.Clone();
                smaller = second.Clone();
            }
            for (int i = 0; i < smaller.value.Count; i++)
            {
                bigger.value[i] = bigger.value[i] + smaller.value[i];
                if (bigger.value[i] > uint_size)
                {
                    bigger.value[i] = bigger.value[i] - uint_size - 1;
                    if (i != (bigger.value.Count - 1))
                    {
                        bigger.value[i + 1] += 1;
                    }
                    else
                    {
                        bigger.value.Add(1);
                    }
                }
            }
            return bigger;
        }



        public static N operator -(N first, N second) // Шлемин Роман 9370//Есть тесты
        {
            N bigger = null;
            switch (first.COM(second))
            {
                case 0:
                    List<string> zero = new List<string>();
                    zero.Add("0");
                    N equal = new N(zero);
                    return equal;
                case 1:
                    return null;
                case 2:
                    bigger = first.Clone();
                    break;
            }
            for (int i = (second.value.Count - 1); i >= 0; i--)
            {
                if (bigger.value[i] < second.value[i])    //i-ая строка большего поля меньше
                {
                    bigger.value[i] = bigger.value[i] + uint_size + 1 - second.value[i];      //вычитаем из i-ой строки большего поля i-ую строку меньшего
                    int j;
                    for (j = (i + 1); bigger.value[j] == 0; j++)        //находим строки значениея которых равны нулю
                    {
                        bigger.value[j] = uint_size;      //забираем один разряд, недостаточный для вычитания i-ой строки 
                    }
                    bigger.value[j] -= 1;
                }
                else
                {
                    bigger.value[i] = bigger.value[i] - second.value[i];
                }
            }
            while (bigger.value[bigger.value.Count - 1] == 0)      //проверка на наличия в начале поля незначащего нуля
            {
                bigger.value.RemoveAt(bigger.value.Count - 1);
            }
            return bigger;
        }

        public static N operator *(N first, N second) // Шлемин Роман 9370 //тест есть 
        {
            N product = new N();
            N value = new N();
            for (int i = 0; i < second.value.Count; i++) //Перебираем все элементы 2-ого поля
            {
                if ((second.value[i] == 0) && (i != second.value.Count - 1))
                {
                    product.value.Insert(0, 0);
                    for (int q = 0; q < uint_size_div; q++) value++;
                    continue;
                }
                uint now = second.value[i];
                int j = 0;
                while (now != 0)    //Перебираем все цифры элемента
                {
                    byte factor = Convert.ToByte(now % 10);
                    product += (first.MUL_ND_N(factor)).MUL_Nk_N(value); //Сохраняем результат умножение 1-ого поля на цифру
                    value++;
                    j++;
                    now = now / 10;
                }
                for(int k = j; k < uint_size_div; k++)
                {
                    value++;
                }
            }
            for(int i = product.value.Count - 1; i > 0; i--)
            {
                if (product.value[i] == 0) product.value.RemoveAt(i);
                else break;
            }
            return product;
        }

        public static N operator /(N first, N second)//    //Есть тесты
        {
            List<string> zero = new List<string>(); //создаем список с нулём
            zero.Add("0");
            N div; //зануляем перменную счётчик
            N divres = new N(zero); //переменная для ответа
            if (first.COM(second) != 1) //если первое больше второго либо они равны
            {
                if (first.COM(second) == 2) //если первое больше второго 
                {
                    if (!(second.NZER_N_B))
                    {
                        N result = first.Clone(); //создаем временную переменную
                        while (result.COM(second) != 1) //пока первое больше второго выполняем цикл
                        {
                            div = DIV_NN_Dk(result, second); //наращиваем div первыми цифрами деления
                            result -= div * second; //выполняем последовательное понижение большего
                            divres += div;
                        }
                        return divres; //возвращаем divres
                    }
                    else
                        return null;
                }
                else // если они равны
                {
                    List<string> one = new List<string>(); //создаем новый список 
                    one.Add("1"); //добавляем туда единицу
                    N result1 = new N(one); //задаём значение result1
                    return result1; //возвращаем result1
                }
            }
            else
            {
                return divres;
            }
        }

        public static N operator %(N first, N second)//есть тесты
        {
            N temp;
            if(second.NZER_N_B)
            {
                return null;
            }
            if (first.COM(second) == 1)
                return first;
            else
            {
                temp = first - (first / second) * second;
                return temp;
            }
        }

        public static N operator ^(N first, N second)
        {
            N baze = first.Clone();
            N degree = second.Clone();
            List<string> z = new List<string>();
            List<string> r = new List<string>();
            List<string> s = new List<string>();
            z.Add("0");
            r.Add("1");
            s.Add("2");
            N zero = new N(z);
            N result = new N(r);
            N temp = new N(s);
            N one = new N(r);
            uint two = 2;
            if (degree.COM(result) == 0)
            {
                return baze;
            }
            if (degree.COM(zero) == 0)
            {
                return result;
            }
            while (degree.COM(temp) == 2 || degree.COM(temp) == 0)
            {
                if (degree.value[0] % two == 1)
                {
                    degree -= one;
                    result *= baze;
                }
                else
                {
                    degree /= temp;
                    baze *= baze;
                }
            }
            result *= baze;
            return result;
        }
        

        public static implicit operator List<string>(N value) // Александр Рассохин 9370//есть тесты
        {
            List<string> S = new List<string>();
            System.Text.StringBuilder temp = new System.Text.StringBuilder();  // временная переменная для записи разрядов

            for (int i = value.value.Count - 1; i >= 0; i--)            // Цикл идет с конца списка до первого элемента
            {
                temp.Append(Convert.ToString(value.value[i]));          // Запись элемента списка во временную переменную
                int size = temp.Length; 
                if (size != uint_size_div && i != value.value.Count - 1) // Если кол-во разрядов меньше чем нужно   
                {
                    temp.Clear();
                    for (int k = 0; k<uint_size_div - size; k++)        // Добавление нулей для заполнения разрядов
                        temp.Append("0");

                    temp.Append(Convert.ToString(value.value[i]));  
                }
                S.Add(Convert.ToString(temp));  // Присваивание временной переменной элементу списка
                temp.Clear();
            }
            return S;
        }


        public override bool Equals(object obj)
        {
            if (obj.GetType() == GetType() && this != null && obj != null)
            {
                if(value.SequenceEqual((obj as N).value)) return true;
            }
            return false;
        }


        #endregion

        #region Методы


        /// <summary>
        /// Умножает текущий объект на цифру
        /// </summary>
        /// <param name="value">Цифра</param>
        private N MUL_ND_N(byte value) //Дмитрий Панченко 9370 //тест есть(закоммичен)
        {
            N k = Clone(); 
            uint g = 0;
            for (int i = 0; i < this.value.Count; i++)
            {
                k.value[i] = k.value[i] * value + g;
                g = k.value[i] / (uint_size + 1);
                if (g != 0)
                {
                    k.value[i] -= (uint_size + 1) * g;
                }
                if ((i == this.value.Count - 1) && (g != 0))
                {
                    k.value.Add(g);
                }
            }
            return k;
        }


        /// <summary>
        /// Умножает на 10^k
        /// </summary>
        /// <param name="value">k - количество разрядов на которое сдвинется число</param>
        private N MUL_Nk_N(N value) // Дмитрий Панченко 9370//тест есть(закоммичен)
        {
            List<string> s = new List<string>();
            s.Add(Convert.ToString(uint_size_div));
            N k = this.Clone(), usdn = new N(s);
            int count = 0;
            while (value.COM(usdn) != 1)
            {
                k.value.Insert(0, 0);
                value -= usdn;
                count++;
            }
            string change = "";
            uint uvalue = value.value[0];
            for(int i = 0; i < uvalue; i++)
            {
                change += "0";
            }
            for (int i = count; i < k.value.Count; i++)
            {
                string now = Convert.ToString(k.value[i]);
                while (now.Length < uint_size_div)
                {
                    now = "0" + now;
                }
                now += change;
                char[] stupid = new char[uvalue];
                now.CopyTo(0, stupid, 0, Convert.ToInt32(uvalue));
                change = new string(stupid);
                now = now.Remove(0, Convert.ToInt32(uvalue));
                k.value[i] = Convert.ToUInt32(now);
                if (i + 1 == k.value.Count && change.Split('0').Length - 1 != uvalue)
                {
                    k.value.Add(0);
                }
            }
            return k; 
        }


        /// <summary>
        /// Вычитание из первого числа второго умноженного на цифру
        /// </summary>
        /// <param name="first">Первое число</param>
        /// <param name="second">Второе число</param>
        /// <param name="k">Цифра</param>
        private static N SUB_NDN_N(N first, N second, byte k) // Александр Баталин 9370 //тест есть(закоммичен)
        {
            N sec = second.MUL_ND_N(k);
            if (first.COM(sec) != 1)
            {
                return first - sec;
            }
            else
                return null;
        }


        /// <summary>
        /// Первая цифра деления умножениая на 10^k, где k порядковый номер этой цифры
        /// </summary>
        /// <param name="first">Делимое</param>
        /// <param name="second">Делитель</param>
        private static N DIV_NN_Dk(N first, N second) // Шлемин Роман 9370//тест есть(закоммичен) (нужно деление)
        {
            N divided = null;
            N divider = null;
            switch (first.COM(second))
            {
                case 0:
                    List<string> one = new List<string>();
                    one.Add("1");
                    N equal = new N(one);
                    return equal;
                case 1:
                    divided = second.Clone();
                    divider = first.Clone();
                    break;
                case 2:
                    divider = second.Clone();
                    divided = first.Clone();
                    break;
            }
            List<string> zero = new List<string>();
            zero.Add("0");
            N smaller = new N(zero);
            List<string> ten = new List<string>();
            ten.Add("1");
            N o = new N(ten);
            N element = new N(ten);
            int f = divided.value.Count - 1;
            string step = Convert.ToString(divided.value[f]);
            while (smaller.COM(divider) == 1)
            {
                for (int m = 0; m < step.Length; m++)
                {
                    element.value[0] = Convert.ToUInt32(Convert.ToString(step[m]));
                    smaller = smaller.MUL_Nk_N(o) + element;
                    if (smaller.COM(divider) == 2)
                    {
                        break;
                    }
                }
                if (smaller.COM(divider) == 2)
                {
                    break;
                }
                f--;
                step = Convert.ToString(divided.value[f]);
                while (step.Length < uint_size_div)
                {
                    step = "0" + step;
                }
            }
            N result = new N(zero);
            string w = Convert.ToString(smaller.value.Count - 1);
            List<string> rez2 = new List<string>();
            rez2.Add(w);
            N razm1 = new N(rez2);
            string r = Convert.ToString(Convert.ToString(smaller.value[smaller.value.Count - 1]).Length);
            List<string> rez3 = new List<string>();
            rez3.Add(r);
            N razm2 = new N(rez3);
            while (smaller.COM(divider) != 1) //вычитаем из большего меньшее, пока большее не станет меньше
            {
                smaller -= divider;
                result++;
            }
            string q = Convert.ToString(divided.value.Count - 1);
            List<string> rez = new List<string>();
            rez.Add(q);
            N value = new N(rez);
            string p = Convert.ToString(Convert.ToString(divided.value[divided.value.Count - 1]).Length);
            List<string> rez1 = new List<string>();
            rez1.Add(p);
            N razm = new N(rez1);
            value = value.MUL_ND_N(Convert.ToByte(uint_size_div)) + razm;
            value = value - razm1.MUL_ND_N(Convert.ToByte(uint_size_div)) - razm2;
            result = result.MUL_Nk_N(value);
            return result;  //получаем результат
        }

        /// <summary>
        /// Создает точную копию данного объекта
        /// </summary>
        public N Clone() // Александр Баталин 9370//есть тесты
        {
            N clone = new N(new List<string>());
            clone.value = new List<uint>(value);
            return clone;
        }

        #endregion

        #region Событие

        public delegate Math_Field Antiderivative_delegate(Math_Field value);

        public static event Antiderivative_delegate Antiderivative_event;

        #endregion

        #region Общие методы и свойства

        #region Свойства

        public override int id
        {
            get
            {
                return 1;
            }
        }

        public override bool isDown // Евгений Куликов 9370 / Тест есть
        {
            get
            {
                return false;
            }
        }

        public override Math_Field ABS
        {
            get
            {
                return Clone();
            }
        }

        public override Math_Field LED
        {
            get
            {
                return Clone();
            }
        }

        public override Math_Field UNT
        {
            get
            {
                return null;
            }
        }

        public override Math_Field DEG
        {
            get
            {
                List<string> s = new List<string>();
                s.Add("0");
                return new N(s);
            }
        }

        public override Math_Field DER
        {
            get
            {
                List<string> s = new List<string>();
                s.Add("0");
                return new N(s);
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


        public override Math_Field LCM(Math_Field second)
        {
            N a = Clone();
            N b = (second as N).Clone();
            N result = a * b / (a.GCF(b) as N);
            return result;
        }

        public override Math_Field SUB(Math_Field second)
        {
            return this - (second as N);
        }

        public override Math_Field MUL(Math_Field second)
        {
            return this * (second as N);
        }

        public override Math_Field Dawn()
        {
            return this;
        }

        public static N Create(string s)
        {
            List<string> dat = new List<string>();
            for (int j = s.Length - 1, q = 1; j >= 0; j -= (int)N.uint_size_div, q++)
            {
                dat.Insert(0, s.Substring(s.Length - (int)(N.uint_size_div) * q >= 0 ? s.Length - (int)(N.uint_size_div) * q : 0, s.Length - (int)(N.uint_size_div) * q >= 0 ? (int)N.uint_size_div : s.Length % (int)N.uint_size_div));
            }
            return new N(dat);
        }

        public override byte COM(Math_Field second)
        {
            if (value.Count > (second as N).value.Count)
            {
                return 2;
            }
            if (value.Count < (second as N).value.Count)
            {
                return 1;
            }
            for (int i = value.Count - 1; i >= 0; i--)
            {
                if (value[i] <= (second as N).value[i])
                {
                    if (value[i] != (second as N).value[i])
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

        public override Math_Field DIV(Math_Field second)
        {
            return this / (second as N);
        }

        public override Math_Field MOD(Math_Field second)
        {
            return this % (second as N);
        }

        public override Math_Field REM(Math_Field second)
        {
            return null;
        }

        public override Math_Field GCF(Math_Field second)
        {
            N a = Clone();
            N b = (second as N).Clone();
            while (!(a.NZER_N_B) && !(b.NZER_N_B))
            {
                if (a.COM(b) != 1)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }
            if (a.NZER_N_B)
            {
                return b;
            }
            else
            {
                return a;
            }
        }

        public override Math_Field ADD(Math_Field second)
        {
            return this + (second as N);
        }

        public override List<string> ToListstring()
        {
            return this;
        }

        public override Math_Field CEI (Math_Field first, Math_Field second)
        {
            try
            {
                return (ANT.RES(second) as N) - (ANT.RES(first) as N);
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
