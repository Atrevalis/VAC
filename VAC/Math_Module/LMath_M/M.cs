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

        #endregion

        #region Конструторы

        /// <summary>
        /// Конструктор класса N
        /// </summary>
        /// <param name="s">Строка разбитая по <c>uint_size_div</c> элементов</param>
        public M(List<string> s) // Александр Рассохин 9370
        {
        }

        #endregion

        #region Свойства

        #endregion

        #region Перегрузки

        public static M operator -(M value)
        {
            return null;
        }

        public static M operator +(M first, M second) // Шлемин Роман 9370 Есть тесты
        {
            return null;
        }



        public static M operator -(M first, M second) // Шлемин Роман 9370//Есть тесты
        {
            return null;
        }

        public static M operator *(M first, M second) // Шлемин Роман 9370 //тест есть 
        {
            return null;
        }

        public static M operator /(M first, M second)//    //Есть тесты
        {
            return null;
        }

        public static M operator %(M first, M second)//есть тесты
        {
            return null;
        }

        public static M operator ^(M first, M second)
        {
            return null;
        }


        public static implicit operator List<string>(M value) // Александр Рассохин 9370//есть тесты
        {
            return null;
        }


        public override bool Equals(object obj)
        {
            return false;
        }


        #endregion

        #region Методы

        /// <summary>
        /// Создает точную копию данного объекта
        /// </summary>
        public M Clone() // Александр Баталин 9370//есть тесты
        {
            return null;
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
                return null;
            }
        }

        public override Math_Field DER
        {
            get
            {
                return null;
            }
        }

        public override Math_Field ANT
        {
            get
            {
                return null;
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
            return null;
        }

        public override Math_Field MUL(Math_Field second)
        {
            return null;
        }

        public override Math_Field Dawn()
        {
            return this;
        }

        public override byte COM(Math_Field second)
        {
            return 1;
        }

        public override Math_Field DIV(Math_Field second)
        {
            return null;
        }

        public override Math_Field MOD(Math_Field second)
        {
            return null;
        }

        public override Math_Field GCF(Math_Field second)
        {
            return null;
        }

        public override Math_Field ADD(Math_Field second)
        {
            return null;
        }

        public override List<string> ToListstring()
        {
            return null;
        }

        public override Math_Field CEI(Math_Field first, Math_Field second)
        {
            return null;
        }

        public override Math_Field RES(Math_Field value)
        {
            return null;
        }
        #endregion        

        #endregion
    }
}
