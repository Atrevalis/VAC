using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMath
{
    public class R : Math_Field
    {
        #region Конструкторы

        #endregion

        #region Поля



        #endregion

        #region Свойства

        #endregion

        #region Перегрузки

        #endregion

        #region Методы

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
        public override bool isDown { get; }

        public override Math_Field ABS { get; }

       public override Math_Field UNT { get; }

        public override Math_Field DER { get; }

        public override Math_Field LED { get; }

        public override Math_Field DEG { get; }

        public override Math_Field FAC { get; }

        #endregion

        #region Методы


        public override Math_Field Dawn()
        {
            return null;
        }

        public override Math_Field SUB(Math_Field second)
        {
            return null;
        }

        public override Math_Field DIV(Math_Field second)
        {
            return null;
        }

        public override Math_Field MOD(Math_Field second)
        {
           return null;
        }

        public override Math_Field ADD(Math_Field second)
        {
            return null;
        }

        public override Math_Field MUL(Math_Field second)
        {
            return null;
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
            return 0;
        }

        public override List<string> ToListstring()
        {
            return null;
        }

        #endregion
        #endregion
    }
}
