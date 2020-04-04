using System;
using System.Collections.Generic;
using External_module;
using System.Windows.Forms;

namespace External_Controller
{
    public static class Controller
    {
        public static string path_of_now_project;
        public static string name_of_now_project;
        public static List<Data> dates = new List<Data>();
        public static List<Operators> operators = new List<Operators>();
        public static List<Bin_operator> bin_Operators = new List<Bin_operator>();
        public static List<if_operator> if_Operators = new List<if_operator>();
        public static List<N_operator> N_Operators = new List<N_operator>();
        public static List<Noda> nods = new List<Noda>();
        public static List<Result> results = new List<Result>();
        public static List<Uno_operator> uno_Operators = new List<Uno_operator>();
        public static List<Working_data> working_Dates = new List<Working_data>();

        public static void Save()
        {

        }

        public static void Create_new_Nod(string name, string type, object Visual_nod, ref string[] ags)
        {
            switch(type)
            {
                case "Data":
                    {
                        dates.Add(new Data(Bilder.Bild_Data(name), Visual_nod));
                        working_Dates.Add(new Working_data(dates[dates.Count - 1].information, Visual_nod));
                        nods.Add(new Noda(dates[dates.Count - 1].information, Visual_nod));
                    }
                    break;
                case "Bin_operator":
                    {
                        bin_Operators.Add(new Bin_operator(Bilder.Bild_bin_op(name), Visual_nod));
                        operators.Add(new Operators(bin_Operators[bin_Operators.Count - 1].information, Visual_nod));
                        working_Dates.Add(new Working_data(bin_Operators[bin_Operators.Count - 1].information, Visual_nod));
                        nods.Add(new Noda(bin_Operators[bin_Operators.Count - 1].information, Visual_nod));
                    }
                    break;
                case "Uno_operator":
                    {
                        uno_Operators.Add(new Uno_operator(Bilder.Bild_uno_op(name), Visual_nod));
                        operators.Add(new Operators(uno_Operators[uno_Operators.Count - 1].information, Visual_nod));
                        working_Dates.Add(new Working_data(uno_Operators[uno_Operators.Count - 1].information, Visual_nod));
                        nods.Add(new Noda(uno_Operators[uno_Operators.Count - 1].information, Visual_nod));
                    }
                    break;
                case "N_operator":
                    {
                        N_Operators.Add(new N_operator(Bilder.Bild_n_op(name), Visual_nod));
                        operators.Add(new Operators(N_Operators[N_Operators.Count - 1].information, Visual_nod));
                        working_Dates.Add(new Working_data(N_Operators[N_Operators.Count - 1].information, Visual_nod));
                        nods.Add(new Noda(N_Operators[N_Operators.Count - 1].information, Visual_nod));
                    }
                    break;
                case "if_operator":
                    {
                        if_Operators.Add(new if_operator(Bilder.Bild_if_Operator(name, ref ags), Visual_nod));
                        nods.Add(new Noda(if_Operators[if_Operators.Count - 1].information, Visual_nod));
                    }
                    break;
                case "Result":
                    {
                        results.Add(new Result(new External_module.Result(), Visual_nod));
                        nods.Add(new Noda(results[results.Count - 1].information, Visual_nod));
                    }
                    break;

            }
        }

        public static void new_Conect(Control first, Control second)
        {
            External_module.Noda first_obj = null, second_obj = null;
            for(int i = 0; i < nods.Count; i++)
            {
                if (nods[i].Visul == first.Parent) first_obj = nods[i].information;
                if (nods[i].Visul == second) second_obj = nods[i].information;
            }

            if(first_obj.isDowncoonection && second_obj.isUpcoonection)
            {
                if(first_obj.type != "if" && second_obj.type != "if")
                {
                    (first_obj as External_module.Working_data).down_contacted = second_obj;
                    if(second_obj.type == "Result")
                    {
                        (second_obj as External_module.Result).up_Conected = first_obj as External_module.Working_data;
                    }
                    else
                    {
                        (second_obj as External_module.Operators).up_Conected = first_obj as External_module.Working_data;
                    }
                }
                else
                {
                    if(first_obj.type == "if")
                    {
                        for (byte i = 0; i < (first_obj as External_module.if_operator).names_of_exits.Length; i++)
                        {
                            if ((first_obj as External_module.if_operator).names_of_exits[i] == first.Text)
                            {
                                (first_obj as External_module.if_operator).Down_connection(i, second_obj);
                            }
                        }
                        switch (second_obj.type)
                        {
                            case "if":
                                {
                                    (second_obj as External_module.if_operator).if_Operators.Add(first_obj as External_module.if_operator);
                                }
                                break;

                            case "Result":
                                {
                                    (second_obj as External_module.Result).If_operator_conected(first_obj as External_module.if_operator);
                                }
                                break;

                           default:
                                {
                                    (second_obj as External_module.Operators).If_operator_conected(first_obj as External_module.if_operator);
                                }
                                break;
                        }
                    }
                    else
                    {
                        (second_obj as External_module.if_operator).Up_connected(first_obj as External_module.Working_data);
                        if (first_obj.type == "Data")
                        {
                            (first_obj as External_module.Data).down_contacted = second_obj;
                        }
                        else
                        {
                            (first_obj as External_module.Operators).down_contacted = second_obj;
                        }
                    }
                }
            }

        }

        #region Структуры

        public struct Data
        {
            public External_module.Data information;
            public object Visul;

            public Data(External_module.Data data, object e)
            {
                information = data;
                Visul = e;
            }
        }

        public struct Operators
        {
            public External_module.Operators information;
            public object Visul;

            public Operators(External_module.Operators data, object e)
            {
                information = data;
                Visul = e;
            }
        }

        public struct Bin_operator
        {
            public External_module.Bin_operator information;
            public object Visul;

            public Bin_operator(External_module.Bin_operator data, object e)
            {
                information = data;
                Visul = e;
            }
        }

        public struct if_operator
        {
            public External_module.if_operator information;
            public object Visul;

            public if_operator(External_module.if_operator data, object e)
            {
                information = data;
                Visul = e;
            }
        }

        public struct N_operator
        {
            public External_module.N_operator information;
            public object Visul;

            public N_operator(External_module.N_operator data, object e)
            {
                information = data;
                Visul = e;
            }
        }

        public struct Noda
        {
            public External_module.Noda information;
            public object Visul;

            public Noda(External_module.Noda data, object e)
            {
                information = data;
                Visul = e;
            }
        }

        public struct Result
        {
            public External_module.Result information;
            public object Visul;

            public Result(External_module.Result data, object e)
            {
                information = data;
                Visul = e;
            }
        }

        public struct Uno_operator
        {
            public External_module.Uno_operator information;
            public object Visul;

            public Uno_operator(External_module.Uno_operator data, object e)
            {
                information = data;
                Visul = e;
            }
        }

        public struct Working_data
        {
            public External_module.Working_data information;
            public object Visul;

            public Working_data(External_module.Working_data data, object e)
            {
                information = data;
                Visul = e;
            }
        }

        #endregion

    }
}
