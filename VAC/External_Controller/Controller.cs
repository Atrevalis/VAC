using System;
using System.Collections.Generic;
using External_module;

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

        public static void Create_new_Nod(string name, string type, object Visual_nod)
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
                        if_Operators.Add(new if_operator(Bilder.Bild_if_Operator(name), Visual_nod));
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
