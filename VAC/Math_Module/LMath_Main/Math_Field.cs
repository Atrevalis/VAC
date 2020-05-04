using System.Collections.Generic;

namespace LMath
{
    abstract public class Math_Field
    {
        abstract public int id { get; }

        public static bool idCOM(Math_Field first, Math_Field second)
        {
            return first.id > second.id;
        }

        public static int count_of_COM_id(Math_Field first, Math_Field second)
        {
            return first.id - second.id;
        }

        public static void id_to_normal(Math_Field first,ref  Math_Field second)
        {
            while(count_of_COM_id(first, second)>0)
            {
                second = Up(second);
            }
        }

        public delegate Math_Field Up_delegaete(Math_Field value);
        public static event Up_delegaete Up;

        public Math_Field External_Up()
        {
            return Up(this);
        }

        abstract public bool isDown { get; }

        abstract public Math_Field ABS { get; }

        abstract public Math_Field UNT { get; }

        abstract public Math_Field DER { get; }

        abstract public Math_Field LED { get; }

        abstract public Math_Field DEG { get; }

        abstract public Math_Field FAC { get; }


        abstract public Math_Field Dawn();

        abstract public Math_Field SUB(Math_Field second);

        abstract public Math_Field DIV(Math_Field second);

        abstract public Math_Field MOD(Math_Field second);

        abstract public Math_Field ADD(Math_Field second);

        abstract public Math_Field MUL(Math_Field second);

        abstract public Math_Field GCF(Math_Field second);

        abstract public Math_Field LCM(Math_Field second);
       
        abstract public byte COM(Math_Field second);

        abstract public List<string> ToListstring();
    }
}
