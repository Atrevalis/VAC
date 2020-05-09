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

        public R(List<smaller_R> s)
        {

        }

        #endregion

        #region Поля

        List<smaller_R> Sum;

        #endregion

        #region Свойства

        #endregion

        #region Перегрузки

        public static R operator -(R value)
        {
            return null;
        }

        public static R operator +(R first, R second)
        {
            return null;
        }

        public static R operator -(R first, R second)
        {
            return null;
        }

        public static R operator *(R first, R second)
        {
            return null;
        }

        public static R operator /(R first, R second)
        {
            return null;
        }

        public static R operator ^(R first, R second)
        {
            return null;
        }

        public static implicit operator R (Q value)
        {
            return null;
        }

        #endregion

        #region Методы

        public static Math_Field Antiderivative_event_do(Math_Field value)
        {
            return ((R)(value as Q)).ANT;
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
        public override bool isDown { get; }

        public override Math_Field ABS { get; }

       public override Math_Field UNT { get; }

        public override Math_Field DER { get; }

        public override Math_Field LED { get; }

        public override Math_Field DEG { get; }

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

        public override Math_Field CEI(Math_Field first, Math_Field second)
        {
            try
            {
                return ANT.RES(second) - ANT.RES(first);
            }
            catch
            {
                return null;
            }
        }

        public override Math_Field RES()
        {
            return this;
        }
        #endregion
        #endregion
    }

    public class the_smallest_R
    {
        Q basa;
        R indicator;

        public the_smallest_R(Q b, R ind)
        {

        }
    }

    public class smaller_R
    {
        List<the_smallest_R> product;
        public smaller_R(List<the_smallest_R> p)
        {

        }
    }
}
