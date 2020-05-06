using System.Collections.Generic;

namespace LMath
{
    abstract public class Math_Field
    {
        /// <summary>
        /// Идентификационный номер текущего класса
        /// </summary>
        abstract public int id { get; }


        /// <summary>
        /// Проверка совместимости типпов
        /// </summary>
        public static bool idCOM(Math_Field first, Math_Field second)
        {
            return first.id > second.id;
        }

        /// <summary>
        /// Уточнение разброса типов
        /// </summary>
        public static int count_of_COM_id(Math_Field first, Math_Field second)
        {
            return first.id - second.id;
        }


        /// <summary>
        /// Приведение типов
        /// </summary>
        public static void id_to_normal(Math_Field first,ref  Math_Field second)
        {
            while(count_of_COM_id(first, second)>0)
            {
                second = Up(second);
            }
        }

        /// <summary>
        /// Делегат для события повышения типа
        /// </summary>
        /// <param name="value">Повышаемый тип</param>
        public delegate Math_Field Up_delegaete(Math_Field value);

        /// <summary>
        /// Событие повышения типа
        /// </summary>
        public static event Up_delegaete Up;


        /// <summary>
        /// Метод повышения типа, вызываемого из других частей программы
        /// </summary>
        public Math_Field External_Up()
        {
            return Up(this);
        }


        /// <summary>
        /// Проверяет возможно ли понижение типа
        /// </summary>
        abstract public bool isDown { get; }


        /// <summary>
        /// Возвращает модуль объекта
        /// </summary>
        abstract public Math_Field ABS { get; }


        /// <summary>
        /// Возвращает объект умноженный на -1
        /// </summary>
        abstract public Math_Field UNT { get; }


        /// <summary>
        /// Производная взятая от объекта
        /// </summary>
        abstract public Math_Field DER { get; }


        /// <summary>
        /// Старший коэфицент
        /// </summary>
        abstract public Math_Field LED { get; }

        /// <summary>
        /// Степень многочлена
        /// </summary>
        abstract public Math_Field DEG { get; }

        /// <summary>
        /// Переходит в подмножество
        /// </summary>
        abstract public Math_Field Dawn();

        /// <summary>
        /// Вычитает из текущего объекта аргумент
        /// </summary>
        /// <param name="second">Вычитаемое</param>
        abstract public Math_Field SUB(Math_Field second);


        /// <summary>
        /// Делит текущий объект на аргумент
        /// </summary>
        /// <param name="second">Делитель</param>
        abstract public Math_Field DIV(Math_Field second);


        /// <summary>
        /// Находит остаток от деления текущего элемента на аргумент
        /// </summary>
        /// <param name="second">Делитель</param>
        /// <returns></returns>
        abstract public Math_Field MOD(Math_Field second);


        /// <summary>
        /// Складывает текущий элемент и аргумент
        /// </summary>
        /// <param name="second">2-е слогаемое</param>
        /// <returns></returns>
        abstract public Math_Field ADD(Math_Field second);


        /// <summary>
        /// Умножает текущий элемент на аргумент
        /// </summary>
        /// <param name="second">2-й множитель</param>
        /// <returns></returns>
        abstract public Math_Field MUL(Math_Field second);


        /// <summary>
        /// Находит НОД текущего объекта и аргумента
        /// </summary>
        abstract public Math_Field GCF(Math_Field second);



        /// <summary>
        /// Находит НОК текущего объекта и аргумента
        /// </summary>
        abstract public Math_Field LCM(Math_Field second);


        /// <summary>
        /// Сравнивает текущий объект и аргумент    
        /// <para />
        /// 1 если a меньше b 
        /// <para />
        /// 2 если a больше b
        /// <para />
        /// 0 если a = b 
        /// </summary>
        abstract public byte COM(Math_Field second);


        /// <summary>
        /// Перобразует объект в список строк
        /// </summary>
        abstract public List<string> ToListstring();
    }
}
