using System;
using System.Collections.Generic;
using System.IO;
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
            data.type = "Data";
            data.data_name = arg;
            return data;
        }

        public static if_operator Bild_if_Operator(string name, ref string[] args)
        {
            if_operator if_ = new if_operator();
            switch(name)
            {
                case "COM_NN_D":
                    {
                        if_.Count_of_up_connection = 2;
                        if_.exits = new List<Noda>[3];
                        for(int i = 0; i < if_.exits.Length; i++)
                        {
                            if_.exits[i] = new List<Noda>();
                        }
                        if_.Count_of_up_connection = 2;
                        args = new string[] { ">", "=", "<" };
                        if_.names_of_exits = args;
                        if_.Name = name;
                    }
                    break;
                case "isDown":
                    {
                        if_.Count_of_up_connection = 1;
                        if_.Count_of_up_connection = 1;
                        if_.exits = new List<Noda>[2];
                        for (int i = 0; i < if_.exits.Length; i++)
                        {
                            if_.exits[i] = new List<Noda>();
                        }
                        args = new string[] { "t", "f"};
                        if_.names_of_exits = args;
                        if_.Name = name;
                    }
                    break;
            }
            if_.type = "if";
            return if_;

        }

       public  static Uno_operator Bild_uno_op(string value)
        {
            Uno_operator uno = new Uno_operator();
            uno.type = "operator";
            uno.name_of_operators = value;
            return uno;
        }

        public static Bin_operator Bild_bin_op(string value)
        {
            Bin_operator bin = new Bin_operator();
            bin.type = "operator";
            bin.name_of_operators = value;
            return bin;
        }

        public static N_operator Bild_n_op(string value)
        {
            N_operator n = new N_operator();
            n.type = "operator";
            n.name_of_operators = value;
            return n;
        }

        public static void Saver1(StreamWriter writer, Noda noda, string text)
        {
            if (noda.type != "operator")
            {
                writer.WriteLine(noda.type + " " + noda.name + " " + text);
            }
            else
            {
                switch ((noda as External_module.Operators).Count_of_up_connection)
                {
                    case -1:
                        {
                            writer.WriteLine(noda.type + " " + noda.name + " " + text + "!N_operator");
                        }
                        break;
                    case 1:
                        {
                            writer.WriteLine(noda.type + " " + noda.name + " " + text + "!Uno_operator");
                        }
                        break;
                    case 2:
                        {
                            writer.WriteLine(noda.type + " " + noda.name + " " + text + "!Bin_operator");
                        }
                        break;
                }
            }
        }

        public static void Saver2(StreamWriter writer, List<Noda_C> nods, int i)
        {
            switch (nods[i].information.type)
            {
                case "Data":
                    {
                        for (int j = 0; j < (nods[i].information as Data).down_Contacted.Count; j++)
                        {
                            for (int k = 0; k < nods.Count; k++)
                            {
                                if (nods[k].information == (nods[i].information as Data).down_Contacted[j])
                                {
                                    writer.Write(k + " ");
                                }
                            }
                        }
                        writer.WriteLine();
                    }
                    break;
                case "if":
                    {
                        for (int j = 0; j < (nods[i].information as if_operator).exits.Length; j++)
                        {
                            for (int q = 0; q < (nods[i].information as if_operator).exits[j].Count; q++)
                            {
                                for (int k = 0; k < nods.Count; k++)
                                {
                                    if (nods[k].information == (nods[i].information as if_operator).exits[j][q])
                                    {
                                        writer.Write(k + " ");
                                    }
                                }
                            }
                            writer.Write("!");
                        }
                        writer.WriteLine();
                    }
                    break;
                case "operator":
                    {
                        for (int j = 0; j < (nods[i].information as Operators).down_Contacted.Count; j++)
                        {
                            for (int k = 0; k < nods.Count; k++)
                            {
                                if (nods[k].information == (nods[i].information as Operators).down_Contacted[j])
                                {
                                    writer.Write(k + " ");
                                }
                            }
                        }
                        writer.WriteLine();
                    }
                    break;
            }
        }

        public static void Loader()
        {

        }


        #region Структуры

        public struct Noda_C
        {
            public Noda information;
            public object Visul;

            public Noda_C(Noda data, object e)
            {
                information = data;
                Visul = e;
            }
        }

        public struct Data_C
        {
            public External_module.Data information;
            public object Visul;

            public Data_C(External_module.Data data, object e)
            {
                information = data;
                Visul = e;
            }
        }

        public struct Operators_C
        {
            public External_module.Operators information;
            public object Visul;

            public Operators_C(External_module.Operators data, object e)
            {
                information = data;
                Visul = e;
            }
        }

        public struct Bin_operator_C
        {
            public External_module.Bin_operator information;
            public object Visul;

            public Bin_operator_C(External_module.Bin_operator data, object e)
            {
                information = data;
                Visul = e;
            }
        }

        public struct if_operator_C
        {
            public External_module.if_operator information;
            public object Visul;

            public if_operator_C(External_module.if_operator data, object e)
            {
                information = data;
                Visul = e;
            }
        }

        public struct N_operator_C
        {
            public External_module.N_operator information;
            public object Visul;

            public N_operator_C(External_module.N_operator data, object e)
            {
                information = data;
                Visul = e;
            }
        }

        public struct Result_C
        {
            public External_module.Result information;
            public object Visul;

            public Result_C(External_module.Result data, object e)
            {
                information = data;
                Visul = e;
            }
        }

        public struct Uno_operator_C
        {
            public External_module.Uno_operator information;
            public object Visul;

            public Uno_operator_C(External_module.Uno_operator data, object e)
            {
                information = data;
                Visul = e;
            }
        }

        public struct Working_data_C
        {
            public External_module.Working_data information;
            public object Visul;

            public Working_data_C(External_module.Working_data data, object e)
            {
                information = data;
                Visul = e;
            }
        }

        #endregion

    }
}
