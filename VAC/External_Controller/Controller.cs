using System;
using System.Collections.Generic;
using External_module;
using System.Windows.Forms;
using System.IO;
using MVS_Controller;
using System.Drawing;

namespace External_Controller
{
    public static class Controller
    {
        public static string input = "";
        public static string output = "";
        public static bool Auto = false;
        public static string path_of_now_project;
        public static string name_of_now_project;
        public static List<Bilder.Data_C> dates = new List<Bilder.Data_C>();
        public static List<Bilder.Operators_C> operators = new List<Bilder.Operators_C>();
        public static List<Bilder.Bin_operator_C> bin_Operators = new List<Bilder.Bin_operator_C>();
        public static List<Bilder.if_operator_C> if_Operators = new List<Bilder.if_operator_C>();
        public static List<Bilder.N_operator_C> N_Operators = new List<Bilder.N_operator_C>();
        public static List<Bilder.Noda_C> nods = new List<Bilder.Noda_C>();
        public static List<Bilder.Result_C> results = new List<Bilder.Result_C>();
        public static List<Bilder.Uno_operator_C> uno_Operators = new List<Bilder.Uno_operator_C>();
        public static List<Bilder.Working_data_C> working_Dates = new List<Bilder.Working_data_C>();
        public static List<Load_files> load_s;
        public static FileStream file = null;
        public static StreamReader reader = null;

        public static void Save()
        {
            FileStream file = new FileStream(path_of_now_project + "\\" + name_of_now_project + ".cpsprbk", FileMode.OpenOrCreate);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine(input);
            writer.WriteLine(output);
            writer.WriteLine(Auto);
            for(int i = 0; i < nods.Count; i++)
            {
                Control nod = nods[i].Visul as Control;
                writer.WriteLine(nod.Location.X + " " + nod.Location.Y + " " + nod.Width + " " + nod.Height);
                Bilder.Saver1(writer, nods[i].information, (nods[i].Visul as MVS_Controller.Noda).label.Text);
            }
            writer.WriteLine();
            for(int i = 0; i < nods.Count; i++)
            {
                Bilder.Saver2(writer, nods, i);
            }
            writer.Close();
            file.Close();
        }

        public static void Load()
        {
            load_s = new List<Load_files>();
            try
            {
                file = new FileStream(path_of_now_project + "\\" + name_of_now_project + ".cpsprbk", FileMode.Open);
                reader = new StreamReader(file);
            }
            catch
            { MessageBox.Show("Невозможно открыть файл сохранения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            try
            {
                input = reader.ReadLine();
                output = reader.ReadLine();
                Auto = Convert.ToBoolean(reader.ReadLine());
                string s = reader.ReadLine();
                while (s!="")
                {
                    string[] co = s.Split(' ');
                    string[] inf = reader.ReadLine().Split(' ');
                    load_s.Add(new Load_files(Convert.ToInt32(co[0]), Convert.ToInt32(co[1]), Convert.ToInt32(co[2]), Convert.ToInt32(co[3]), inf[0], inf[1], inf[2]));
                    s = reader.ReadLine();
                }
            }
            catch
            { MessageBox.Show("Файл сохранения поврежден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public static void Load_connect()
        {
            int i = 0;
            while(!reader.EndOfStream)
            {
                if (nods[i].information.type == "if")
                {
                    string[] ex = reader.ReadLine().Split('!');
                    for (int k = 0; k < ex.Length; k++)
                    {
                        string[] con = ex[k].Split(' ');
                        for (int j = 0; j < con.Length-1; j++)
                        {
                            new_Conect((nods[i].Visul as MVS_Controller.if_operator).down_contacts[k], (nods[Convert.ToInt32(con[j])].Visul as MVS_Controller.Noda));
                        }
                    }
                }
                else
                {
                    string[] con = reader.ReadLine().Split(' ');
                    for (int j = 0; j < con.Length-1; j++)
                    {
                        new_Conect((nods[i].Visul as MVS_Controller.Working_data).down_contacts, (nods[Convert.ToInt32(con[j])].Visul as MVS_Controller.Noda));
                    }
                }
                i++;
            }
            reader.Close();
            file.Close();
        }

        public static void Delete(Control control)
        {
            for(int i = 0; i < nods.Count; i++)
            {
                if(nods[i].Visul == control)
                {
                    nods.RemoveAt(i);
                }
            }
            for(int i = 0; i < working_Dates.Count; i++)
            {
                if(working_Dates[i].Visul == control)
                {
                    working_Dates.RemoveAt(i);
                    for (int j = 0; j < operators.Count; j++)
                    {
                        if (operators[j].Visul == control)
                        {
                            operators.RemoveAt(j);
                            for (int k= 0; k < bin_Operators.Count; k++)
                            {
                                if (bin_Operators[k].Visul == control)
                                {
                                    bin_Operators.RemoveAt(k);
                                    return;
                                }
                            }
                            for (int k = 0; k < uno_Operators.Count; k++)
                            {
                                if (uno_Operators[k].Visul == control)
                                {
                                    uno_Operators.RemoveAt(k);
                                    return;
                                }
                            }
                            for (int k = 0; k < N_Operators.Count; k++)
                            {
                                if (N_Operators[k].Visul == control)
                                {
                                    N_Operators.RemoveAt(k);
                                    return;
                                }
                            }
                        }
                    }
                    for (int j = 0; j < dates.Count; j++)
                    {
                        if (dates[j].Visul == control)
                        {
                            dates.RemoveAt(j);
                            return;
                        }
                    }
                }
            }
            for (int i = 0; i < if_Operators.Count; i++)
            {
                if (if_Operators[i].Visul == control)
                {
                    if_Operators.RemoveAt(i);
                    return;
                }
            }
            for (int i = 0; i < results.Count; i++)
            {
                if (results[i].Visul == control)
                {
                    results.RemoveAt(i);
                }
            }
        }

        public static void Create_new_Nod(string name, string type, object Visual_nod, ref string[] ags)
        {
            switch(type)
            {
                case "Data":
                    {
                        dates.Add(new Bilder.Data_C(Bilder.Bild_Data(name), Visual_nod));
                        working_Dates.Add(new Bilder.Working_data_C(dates[dates.Count - 1].information, Visual_nod));
                        nods.Add(new Bilder.Noda_C(dates[dates.Count - 1].information, Visual_nod));
                    }
                    break;
                case "Bin_operator":
                    {
                        bin_Operators.Add(new Bilder.Bin_operator_C(Bilder.Bild_bin_op(name), Visual_nod));
                        operators.Add(new Bilder.Operators_C(bin_Operators[bin_Operators.Count - 1].information, Visual_nod));
                        working_Dates.Add(new Bilder.Working_data_C(bin_Operators[bin_Operators.Count - 1].information, Visual_nod));
                        nods.Add(new Bilder.Noda_C(bin_Operators[bin_Operators.Count - 1].information, Visual_nod));
                    }
                    break;
                case "Uno_operator":
                    {
                        uno_Operators.Add(new Bilder.Uno_operator_C(Bilder.Bild_uno_op(name), Visual_nod));
                        operators.Add(new Bilder.Operators_C(uno_Operators[uno_Operators.Count - 1].information, Visual_nod));
                        working_Dates.Add(new Bilder.Working_data_C(uno_Operators[uno_Operators.Count - 1].information, Visual_nod));
                        nods.Add(new Bilder.Noda_C(uno_Operators[uno_Operators.Count - 1].information, Visual_nod));
                    }
                    break;
                case "N_operator":
                    {
                        N_Operators.Add(new Bilder.N_operator_C(Bilder.Bild_n_op(name), Visual_nod));
                        operators.Add(new Bilder.Operators_C(N_Operators[N_Operators.Count - 1].information, Visual_nod));
                        working_Dates.Add(new Bilder.Working_data_C(N_Operators[N_Operators.Count - 1].information, Visual_nod));
                        nods.Add(new Bilder.Noda_C(N_Operators[N_Operators.Count - 1].information, Visual_nod));
                    }
                    break;
                case "if_operator":
                    {
                        if_Operators.Add(new Bilder.if_operator_C(Bilder.Bild_if_Operator(name, ref ags), Visual_nod));
                        nods.Add(new Bilder.Noda_C(if_Operators[if_Operators.Count - 1].information, Visual_nod));
                    }
                    break;
                case "Result":
                    {
                        results.Add(new Bilder.Result_C(new External_module.Result(), Visual_nod));
                        nods.Add(new Bilder.Noda_C(results[results.Count - 1].information, Visual_nod));
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

            if(first_obj.isDowncoonection && (second_obj.isUpcoonection || first_obj.type == "if"))
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
        public struct Load_files
        {
            public int x, y, Whight, Height;
            public string type, name, text;

            public Load_files(int xx, int yy, int Whightt, int Heightt, string typee, string namee, string textt)
            {
                x = xx;
                y = yy;
                Whight = Whightt;
                Height = Heightt;
                type = typee;
                name = namee;
                text = textt;
            }
        }

    }
}
