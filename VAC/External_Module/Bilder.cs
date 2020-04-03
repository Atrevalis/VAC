using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace External_module
{
    public static class Bilder
    {
        static public Data Bild_Data(string arg)
        {
            Data data = new Data();
            data.data_name = arg;
            return data;
        }

        public static if_operator Bild_if_Operator(string name)
        {
            if_operator if_ = new if_operator();
            switch(name)
            {
                case "":
                    {
                        if_.Count_of_up_connection = 1;
                        if_.exits = new List<Noda>[1];
                    }
                    break;
            }
            return if_;

        }

       public  static Uno_operator Bild_uno_op(string value)
        {
            Uno_operator uno = new Uno_operator();
            uno.name_of_operators = value;
            return uno;
        }

        public static Bin_operator Bild_bin_op(string value)
        {
            Bin_operator bin = new Bin_operator();
            bin.name_of_operators = value;
            return bin;
        }

        public static N_operator Bild_n_op(string value)
        {
            N_operator n = new N_operator();
            n.name_of_operators = value;
            return n;
        }

    }
}
