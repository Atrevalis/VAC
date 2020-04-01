using System;
using System.Collections.Generic;
using System.Linq;

namespace Math_Module
{
    public class N : Math_Field
    {

        #region Поля

        private List<uint> znach;//

        private const uint uint_size = 99999999;
        public const uint uint_size_div = 8;

        #endregion

        #region Конструторы

        public N(List<string> s) // Александр Рассохин 9370
        {
            znach = new List<uint>();
            for (int i = s.Count-1; i >= 0; i--)
                znach.Add(Convert.ToUInt32(s[i]));
        }

        #endregion

        #region Свойства

        public override bool isDown // Евгений Куликов 9370 / Тест есть
        {
            get
            {
                return false;
            }
        }
        private bool NZER_N_B // Проверка на ноль - Шлемин Роман 9370//тест невозможен
        {
            get
            {
                if ((znach.Count == 1)&&(znach[0] == 0))
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

        public static N operator ++(N value) // Александр Баталин 9370 / Есть тесты
        {
           for (int i = 0; i < value.znach.Count; i++)
           {
                if (value.znach[i] == uint_size)
                {
                    value.znach[i] = 0;
                }
                else
                {
                    value.znach[i]++;
                    return value;
                }
           }
            value.znach.Add(1);
            return value;
        }

        public static N operator +(N first, N second) // Шлемин Роман 9370 Есть тесты
        {
            N bigger;
            N smaller;
            if (COM_NN_D(first, second) != 2)
            {
                bigger = second.Clone();
                smaller = first.Clone();
            }
            else
            {
                bigger = first.Clone();
                smaller = second.Clone();
            }
            for (int i = 0; i < smaller.znach.Count; i++)
            {
                bigger.znach[i] = bigger.znach[i] + smaller.znach[i];
                if (bigger.znach[i] > uint_size)
                {
                    bigger.znach[i] = bigger.znach[i] - uint_size - 1;
                    if (i != (smaller.znach.Count - 1))
                    {
                        bigger.znach[i + 1] += 1;
                    }
                    else
                    {
                        bigger.znach.Add(1);
                    }
                }
            }
            return bigger;
        }



        public static N operator -(N first, N second) // Шлемин Роман 9370//Есть тесты
        {
            N bigger = null;
            switch (COM_NN_D(first, second))
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
            for (int i = (second.znach.Count - 1); i >= 0; i--)
            {
                if (bigger.znach[i] < second.znach[i])    //i-ая строка большего поля меньше
                {
                    bigger.znach[i] = uint_size + 1 - second.znach[i];      //вычитаем из i-ой строки большего поля i-ую строку меньшего
                    int j;
                    for (j = (i + 1); bigger.znach[j] == 0; j++)        //находим строки значениея которых равны нулю
                    {
                        bigger.znach[j] = uint_size;      //забираем один разряд, недостаточный для вычитания i-ой строки 
                    }
                    bigger.znach[j] -= 1;
                    if (bigger.znach[bigger.znach.Count - 1] == 0)      //проверка на наличия в начале поля незначащего нуля
                    {
                        bigger.znach.RemoveAt(bigger.znach.Count - 1);
                    }
                }
                else
                {
                    if (bigger.znach[i] > second.znach[i])
                    {
                        bigger.znach[i] = bigger.znach[i] - second.znach[i];
                    }
                    else
                    {
                        bigger.znach.RemoveAt(i);
                    }
                }
            }
            return bigger;
        }

        public static N operator *(N first, N second) // Шлемин Роман 9370 //тест есть 
        {
            List<string> zero = new List<string>();
            zero.Add("0");
            N product = new N(zero);
            N value = new N(zero);
            for (int i = 0; i < second.znach.Count; i++) //Перебираем все элементы 2-ого поля
            {
                uint now = second.znach[i];
                while (now != 0)    //Перебираем все цифры элемента
                {
                    byte factor = Convert.ToByte(now % 10);
                    product += (first.MUL_ND_N(factor)).MUL_Nk_N(value); //Сохраняем результат умножение 1-ого поля на цифру
                    value++;
                    now = now / 10;
                }
            }
            return product;
        }

        public static N operator /(N first, N second)
        {
             List<string> zero = new List<string>(); //создаем список с нулём
            zero.Add("0");
            N div = new N(zero); //зануляем перменную счётчик
            if(COM_NN_D(first, second) != 1) //если первое больше второго либо они равны
            {
                N result = first.Clone(); //создаем временную переменную
                if (COM_NN_D(first, second) == 2) //если первое больше второго 
                {
                    while (COM_NN_D(first, second) == 2) //пока первое больше второго выполняем цикл
                    {;
                        result -= second; //выполняем последовательное вычитание из большего меньшее
                        div++; //наращиваем div
                    }
                    return div; //возвращаем div
                }
                else // если они равны
                {
                    List<string> one = new List<string>(); //создаем новый список 
                    one.Add("1"); //добавляем туда единицу
                    N result = new N(one); //задаём значение result
                    return result; //возвращаем result
                }
            }
            else //если второе больше первого
            {
                N result = second.Clone(); //создаем временную переменную
                while (COM_NN_D(second, first) == 2) //пока второе больше первого выполняем цикл
                {
                    result -= first; //выполняем последовательное вычитание из большего меньшее
                    div++; //наращиваем div
                }
                return div; //возвращаем div
            }
        }

        public static N operator %(N first, N second)
        {
            N temp;

            if (COM_NN_D(first, second) == 1)
                return first;
            else
            {
                temp = first -((first / second)*second);
                return temp;
            }
        }
        

        public static implicit operator List<string>(N value) // Александр Рассохин 9370
        {
            List<string> S = new List<string>();
            System.Text.StringBuilder temp = new System.Text.StringBuilder();  // временная переменная для записи разрядов

            for (int i = value.znach.Count - 1; i >= 0; i--)            // Цикл идет с конца списка до первого элемента
            {
                temp.Append(Convert.ToString(value.znach[i]));          // Запись элемента списка во временную переменную
                int size = temp.Length; 
                if (size != uint_size_div && i != value.znach.Count - 1) // Если кол-во разрядов меньше чем нужно   
                {
                    temp.Clear();
                    for (int k = 0; k<uint_size_div - size; k++)        // Добавление нулей для заполнения разрядов
                        temp.Append("0");

                    temp.Append(Convert.ToString(value.znach[i]));  
                }
                S.Add(Convert.ToString(temp));  // Присваивание временной переменной элементу списка
                temp.Clear();
            }
            return S;
        }

        public static implicit operator Z(N value) // Александр Рассохин 9370//тест под вопросом
        {
            return new Z(value);
        }


        public override bool Equals(object obj)
        {
            if (obj.GetType() == GetType() && this != null && obj != null)
            {
                if(znach.SequenceEqual((obj as N).znach)) return true;
            }
            return false;
        }


        #endregion

        #region Методы

        public static byte COM_NN_D(N first, N second) // Сравнение двух чисел - Шлемин Роман 9370//Тест есть
        {
            if (first.znach.Count > second.znach.Count)
            {
                return 2;
            }
            if (first.znach.Count < second.znach.Count)
            {
                return 1;
            }
            for (int i = first.znach.Count-1; i >= 0;i--)
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

        private N MUL_ND_N(byte value) // Умножение числа на цифру - Дмитрий Панченко 9370 //тест есть(закоммичен)
        {
            N k = Clone(); uint g = 0;
            for (int i = 0; i < znach.Count; i++)
            {
                k.znach[i] = k.znach[i] * value + g;
                g = k.znach[i] / uint_size + 1;
            }

            return k;
        }

        private N MUL_Nk_N(N value) // Умножение числа на 10^value - Дмитрий Панченко 9370//тест есть(закоммичен)
        {
            List<string> s = new List<string>();
            s.Add(Convert.ToString(uint_size_div));
            N k = this.Clone(), usdn = new N(s);
            int count = 0;
            while (COM_NN_D(value, usdn) != 1)
            {
                k.znach.Insert(0, 0);
                value -= usdn;
                count++;
            }
            string change = ""; uint uvalue = value.znach[0];
            for (int i = count; i < k.znach.Count; i++)
            {
                string now = Convert.ToString(k.znach[i]);
                while (now.Length < uint_size_div)
                {
                    now = "0" + now;
                }
                now += change;
                char[] stupid = new char[0];
                now.CopyTo(0, stupid, 0, Convert.ToInt32(uvalue));
                change = new string(stupid);
                now = now.Remove(0, Convert.ToInt32(uvalue));
                k.znach[i] = Convert.ToUInt32(now);
                if (i + 1 == k.znach.Count && change.Split('0').Length - 1 != uvalue)
                {
                    k.znach.Add(0);
                }
            }
            return k; 
        }

        private static N SUB_NDN_N(N first, N second, byte k) // Александр Баталин 9370 //тест невозможен
        {
            N sec = second.MUL_ND_N(k);
            if (COM_NN_D(first, sec) != 1)
            {
                return first - sec;
            }
            else
                return null;
        }

        private static N DIV_NN_Dk(N first, N second) // Шлемин Роман 9370//тест есть(закоммичен)
        {
            N divided = null;
            N divider = null;
            switch (COM_NN_D(first, second))
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
            N result = new N(zero);
            while (COM_NN_D(divided, divider) == 2) //вычитаем из большего меньшее, пока большее не станет меньше
            {
                divided -= divider;
                result++;
            }
            List<string> ten = new List<string>();
            ten.Add("10");
            N gran = new N(ten);
            while (COM_NN_D(result, gran) != 1) //находим 1 цифру деления
            {
                result /= gran;
            }
            int i = (divided.znach.Count - 1);  //счиитаем степень k
            string qwerty = i.ToString();
            string perviy = null;
            string vtoroy = null;
            long ost = qwerty.Length % uint_size_div;
            for (int j = 0; j < ost; j++)
            {
                perviy += qwerty[j];
            }
            List<string> qwaserty = new List<string>();
            qwaserty.Add(perviy);
            for (int k = Convert.ToInt32(ost); k < qwerty.Length; k++)
            {
                vtoroy += qwerty[k];
            }
            qwaserty.Add(vtoroy);
            N value = new N(qwaserty);
            value.MUL_ND_N(Convert.ToByte(uint_size_div));
            uint now = divided.znach[i];
            while (now != 0)
            {
                value++;
                now = now / 10;
            }
            return result.MUL_Nk_N(value);  //получаем результат
        }

        public static N GCF_NN_N(N first, N second)
        {
            return null;
        }

        public static N LCM_NN_N(N first, N second)
        {
            return null;
        }

        public N Clone() // Александр Баталин 9370//есть тесты
        {
            N clone = new N(new List<string>());
            clone.znach = new List<uint>(znach);
            return clone;
        }

        #endregion
    }
}
