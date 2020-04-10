using System;
using Math_Module;
using External_Controller;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Interpretation_Controller
{

    public class Working_data
    {
        public Math_Field data;

        public Controller.Working_data info;

        public bool isTrue = true;


        public Working_data(Math_Field field, Controller.Working_data inf)
        {
            data = field;
            info = inf;
        }
    }

    public class if_operator
    {

        public Controller.if_operator info;

        public int path;

        public if_operator(Controller.if_operator inf)
        {
            info = inf;
            path = -1;
        }
    }

    static public class Interpretator
    {

        public static int progress = 0;

        public static void Interpretate()
        {
            string input = Controller.input;
            string output = Controller.output;
            FileStream inp = null, outp = null;
            try
            {
                inp = new FileStream(input, FileMode.Open);
                outp = new FileStream(output, FileMode.OpenOrCreate);
            }
            catch
            {
                MessageBox.Show("Некоректный путь входного/выходного файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inp.Close();
                outp.Close();
                return;
            }
            StreamReader reader = new StreamReader(inp);
            StreamWriter writer = new StreamWriter(outp);
            List<Working_data> Data = new List<Working_data>();
            string s;
            try
            {

                for (int i = 0; i < Controller.working_Dates.Count; i++)
                {
                    if (Controller.working_Dates[i].information.type == "Data")
                    {
                        s = reader.ReadLine();
                        switch (Controller.dates[i].information.name)
                        {
                            case "N":
                                {
                                    List<string> dat = new List<string>();
                                    for (int j = s.Length - 1, q = 1; j >= 0; j -= (int)N.uint_size_div, q++)
                                    {
                                        dat.Insert(0, s.Substring(s.Length - (int)(N.uint_size_div) * q >= 0 ? s.Length - (int)(N.uint_size_div) * q : 0, s.Length - (int)(N.uint_size_div) * q >= 0 ? (int)N.uint_size_div : s.Length % (int)N.uint_size_div));
                                    }
                                    Data.Add(new Working_data(new N(dat), Controller.working_Dates[i]));
                                }
                                break;
                            case "Z":
                                {
                                    List<string> dat = new List<string>();
                                    for (int j = s.Length - 1, q = 1; j >= 0; j -= (int)N.uint_size_div, q++)
                                    {
                                        dat.Insert(0, s.Substring(s.Length - (int)(N.uint_size_div) * q >= 0 ? s.Length - (int)(N.uint_size_div) * q : 0, s.Length - (int)(N.uint_size_div) * q >= 0 ? (int)N.uint_size_div : s.Length % (int)N.uint_size_div));
                                    }
                                    Data.Add(new Working_data(new Z(dat), Controller.working_Dates[i]));
                                }
                                break;
                            case "Q":
                                {
                                    string first = s.Split('/')[0];
                                    string second;
                                    try
                                    {
                                        second = s.Split('/')[1];
                                    }
                                    catch
                                    {
                                        second = "1";
                                    }
                                    List<string> dato = new List<string>();
                                    for (int j = first.Length - 1, q = 1; j >= 0; j -= (int)N.uint_size_div, q++)
                                    {
                                        dato.Insert(0, first.Substring(first.Length - (int)(N.uint_size_div) * q >= 0 ? first.Length - (int)(N.uint_size_div) * q : 0, first.Length - (int)(N.uint_size_div) * q >= 0 ? (int)N.uint_size_div : first.Length % (int)N.uint_size_div));
                                    }
                                    List<string> datt = new List<string>();
                                    for (int j = second.Length - 1, q = 1; j >= 0; j -= (int)N.uint_size_div, q++)
                                    {
                                        datt.Insert(0, second.Substring(second.Length - (int)(N.uint_size_div) * q >= 0 ? second.Length - (int)(N.uint_size_div) * q : 0, second.Length - (int)(N.uint_size_div) * q >= 0 ? (int)N.uint_size_div : second.Length % (int)N.uint_size_div));
                                    }
                                    Data.Add(new Working_data(new Q(dato, datt), Controller.working_Dates[i]));
                                }
                                break;
                            case "P":
                                {
                                    s = s.Replace(" ", "");
                                    s = s.Replace('+', ' ');
                                    s = s.Replace("-", " -");
                                    s = s.Replace("x^", " ");
                                    s = s.Replace("x", " 1");
                                    string[] polinom = s.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                                    List<M> Mnogochlen = new List<M>();
                                    for (int j = 0; j < polinom.Length; j += 2)
                                    {
                                        string first = polinom[j].Split('/')[0];
                                        string second;
                                        try
                                        {
                                            second = polinom[j].Split('/')[1];
                                        }
                                        catch
                                        {
                                            second = "1";
                                        }
                                        List<string> dato = new List<string>();
                                        for (int k = first.Length - 1, q = 1; k >= 0; k -= (int)N.uint_size_div, q++)
                                        {
                                            dato.Insert(0, first.Substring(first.Length - (int)(N.uint_size_div) * q >= 0 ? first.Length - (int)(N.uint_size_div) * q : 0, first.Length - (int)(N.uint_size_div) * q >= 0 ? (int)N.uint_size_div : first.Length % (int)N.uint_size_div));
                                        }
                                        List<string> datt = new List<string>();
                                        for (int k = second.Length - 1, q = 1; k >= 0; k -= (int)N.uint_size_div, q++)
                                        {
                                            datt.Insert(0, second.Substring(second.Length - (int)(N.uint_size_div) * q >= 0 ? second.Length - (int)(N.uint_size_div) * q : 0, second.Length - (int)(N.uint_size_div) * q >= 0 ? (int)N.uint_size_div : second.Length % (int)N.uint_size_div));
                                        }
                                        List<string> datth = new List<string>();
                                        if (j + 1 < polinom.Length)
                                        {
                                            for (int k = polinom[j + 1].Length - 1, q = 1; k >= 0; k -= (int)N.uint_size_div, q++)
                                            {
                                                datth.Insert(0, polinom[j + 1].Substring(polinom[j + 1].Length - (int)(N.uint_size_div) * q >= 0 ? polinom[j + 1].Length - (int)(N.uint_size_div) * q : 0, polinom[j + 1].Length - (int)(N.uint_size_div) * q >= 0 ? (int)N.uint_size_div : polinom[j + 1].Length % (int)N.uint_size_div));
                                            }
                                        }
                                        else
                                        {
                                            datth.Add("0");
                                        }

                                        Q buferq = new Q(dato, datt);
                                        N bufern = new N(datth);
                                        Mnogochlen.Add(new M(buferq, bufern));

                                    }
                                    Data.Add(new Working_data(new P(Mnogochlen), Controller.working_Dates[i]));
                                }
                                break;
                        }
                    }
                    else
                    {
                        Data.Add(new Working_data(null, Controller.working_Dates[i]));
                    }
                }
            }
            catch
            {
                MessageBox.Show("Некоректное содержание входного файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inp.Close();
                outp.Close();
                return;
            }
            progress = 100;
            List<if_operator> ifs = new List<if_operator>();
            for(int i = 0; i < Controller.if_Operators.Count; i++)
            {
                ifs.Add(new if_operator(Controller.if_Operators[i]));
            }
            for (int i = 0; i < Controller.results.Count; i++)
            {
                bool isCorrect = false;
                    for (int j = 0; j < Controller.results[i].information.if_Operators.Count; j++)
                    {
                        for (int k = 0; k < ifs.Count; k++)
                        {
                            if (Controller.results[i].information.if_Operators[j] == ifs[k].info.information)
                            {
                                if(ifs[k].path == -1)
                                {
                                    DFS_for_if(ifs[k], ifs);
                                }
                                if (ifs[k].path >= 0)
                                {
                                    for (int q = 0; q < Controller.results[i].information.if_Operators[j].exits[ifs[k].path].Count; q++)
                                    {
                                        if (Controller.results[i].information.if_Operators[j].exits[ifs[k].path][q] == Controller.results[i].information)
                                        {
                                            isCorrect = true;
                                            break;
                                        }
                                    }

                                }
                                else
                                {
                                    isCorrect = true;
                                }
                                break;
                            }
                        }
                        if(!isCorrect)
                        {
                            MessageBox.Show("Результат № " + i + "Непрошел одну из проверок условий, и в выводе не учавствует", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    }
                    if(!isCorrect) break;
                    for (int j = 0; j < Data.Count; j++)
                    {
                        if (Controller.results[i].information.up_Conected == Data[j].info.information)
                        {
                              
                        }
                    }

            }
            inp.Close();
            outp.Close();
        }

        public static void DFS_for_if(if_operator if_, List<if_operator> ifs)
        {
            for(int i = 0; i < if_.info.information.if_Operators.Count; i++)
            {
                bool isCorrect = false;
                for (int k = 0; k < ifs.Count; k++)
                {
                    if (if_.info.information.if_Operators[i] == ifs[k].info.information)
                    {
                        if (ifs[k].path == -1)
                        {
                            DFS_for_if(ifs[k], ifs);
                        }
                        if (ifs[k].path >= 0)
                        {
                            for (int q = 0; q < if_.info.information.if_Operators[i].exits[ifs[k].path].Count; q++)
                            {
                                if (if_.info.information.if_Operators[i].exits[ifs[k].path][q] == Controller.results[i].information)
                                {
                                    isCorrect = true;
                                    break;
                                }
                            }

                        }
                        else
                        {
                            isCorrect = true;
                        }
                        break;
                    }
                }
                if(!isCorrect)
                {
                    if_.path = -2;
                    return;
                }
            }
        }

        public static void DFS_for_WD(Working_data wd, List<if_operator> ifs)
        {
            for (int i = 0; i < (wd.info.information as External_module.Operators).if_Operators.Count; i++)
            {
                bool isCorrect = false;
                for (int k = 0; k < ifs.Count; k++)
                {
                    if ((wd.info.information as External_module.Operators).if_Operators[i] == ifs[k].info.information)
                    {
                        if (ifs[k].path == -1)
                        {
                            DFS_for_if(ifs[k], ifs);
                        }
                        if (ifs[k].path >= 0)
                        {
                            for (int q = 0; q < (wd.info.information as External_module.Operators).if_Operators[i].exits[ifs[k].path].Count; q++)
                            {
                                if ((wd.info.information as External_module.Operators).if_Operators[i].exits[ifs[k].path][q] == Controller.results[i].information)
                                {
                                    isCorrect = true;
                                    break;
                                }
                            }

                        }
                        else
                        {
                            isCorrect = true;
                        }
                        break;
                    }
                }
                if (!isCorrect)
                {
                    wd.isTrue = false;
                    return;
                }
            }
        }
    }
}
