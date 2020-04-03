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

        public static string Create_new_Nod(string name, object Visual_nod)
        {
            return null;
        }

        #region Структуры

        public struct Data
        {
            External_module.Data information;
            object Visul;

            public Data(External_module.Data data, object e)
            {
                information = data;
                Visul = e;
            }
        }

        public struct Operators
        {
            External_module.Operators information;
            object Visul;

            public Operators(External_module.Operators data, object e)
            {
                information = data;
                Visul = e;
            }
        }

        public struct Bin_operator
        {
            External_module.Bin_operator information;
            object Visul;

            public Bin_operator(External_module.Bin_operator data, object e)
            {
                information = data;
                Visul = e;
            }
        }

        public struct if_operator
        {
            External_module.if_operator information;
            object Visul;

            public if_operator(External_module.if_operator data, object e)
            {
                information = data;
                Visul = e;
            }
        }

        public struct N_operator
        {
            External_module.N_operator information;
            object Visul;

            public N_operator(External_module.N_operator data, object e)
            {
                information = data;
                Visul = e;
            }
        }

        public struct Noda
        {
            External_module.Noda information;
            object Visul;

            public Noda(External_module.Noda data, object e)
            {
                information = data;
                Visul = e;
            }
        }

        public struct Result
        {
            External_module.Result information;
            object Visul;

            public Result(External_module.Result data, object e)
            {
                information = data;
                Visul = e;
            }
        }

        public struct Uno_operator
        {
            External_module.Uno_operator information;
            object Visul;

            public Uno_operator(External_module.Uno_operator data, object e)
            {
                information = data;
                Visul = e;
            }
        }

        public struct Working_data
        {
            External_module.Working_data information;
            object Visul;

            public Working_data(External_module.Working_data data, object e)
            {
                information = data;
                Visul = e;
            }
        }

        #endregion

    }
}
