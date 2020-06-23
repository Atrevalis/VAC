using System;
using LMath;
using External_Controller;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using External_module;
using Interpretator_config;

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
        static List<Working_data> Data;
        static List<if_operator> ifs;
        static bool check;

        public static int progress = 0;

        public static void Interpretate()
        {
            string input = Controller.input;
            string output = Controller.output;
            check = Controller.Auto;
            FileStream inp = null, outp = null;
            try
            {
                inp = new FileStream(input, FileMode.Open);
                outp = new FileStream(output, FileMode.OpenOrCreate);
            }
            catch
            {
                MessageBox.Show("Некоректный путь входного/выходного файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            StreamReader reader = new StreamReader(inp);
            StreamWriter writer = new StreamWriter(outp);
            Data = new List<Working_data>();
            string s;
            try
            {

                for (int i = 0; i < Controller.working_Dates.Count; i++)
                {
                    if (Controller.working_Dates[i].information.type == "Data")
                    {
                        s = reader.ReadLine();
                        if (s == null) throw new Exception();
                        Data.Add(new Working_data(Config.builder(Controller.working_Dates[i].information.name,s), Controller.working_Dates[i]));
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
            progress = 10;
            ifs = new List<if_operator>();
            for(int i = 0; i < Controller.if_Operators.Count; i++)
            {
                ifs.Add(new if_operator(Controller.if_Operators[i]));
            }
            for (int i = 0; i < Controller.results.Count; i++)
            {
                bool isCorrect = true;
                    for (int j = 0; j < Controller.results[i].information.if_Operators.Count; j++)
                    {
                        for (int k = 0; k < ifs.Count; k++)
                        {
                            if (Controller.results[i].information.if_Operators[j] == ifs[k].info.information)
                            {
                                if(ifs[k].path == -1)
                                {
                                    DFS_for_if(ifs[k]);
                                }
                                if (ifs[k].path >= 0)
                                {
                                    isCorrect = false;
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
                                    isCorrect = false;
                                }
                                break;
                            }
                        }
                        if(!isCorrect)
                        {
                            MessageBox.Show("Результат № " + (i+1) + "Не прошел одну из проверок условий, и в выводе не учавствует", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    }
                    if(!isCorrect) continue;
                    for (int k = 0; k < Data.Count; k++)
                    {
                        if (Controller.results[i].information.up_Conected == Data[k].info.information)
                        {
                            if (Data[k].data == null)
                            {
                                DFS_for_WD(Data[k]);
                                if(Data[k].data == null)
                                {
                                    Data[k].isTrue = false;
                                }
                            }
                            if (Data[k].isTrue)
                            {
                                string res = "";
                                for (int a = 0; a < Data[k].data.ToListstring().Count; a++) 
                                res += Data[k].data.ToListstring()[a];
                                writer.WriteLine(res);
                            }
                            else
                            {
                                MessageBox.Show("Результат №  " + (i+1) + "Не получил данных, и в выводе не учавствует", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    progress += 90 / Controller.results.Count;

            }
            reader.Close();
            writer.Close();
            inp.Close();
            outp.Close();
            MessageBox.Show("Интерпритация выполнена успешно", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            progress = 0;
        }

        public static void DFS_for_if(if_operator if_)
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
                            DFS_for_if(ifs[k]);
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
            try
            {
                List<int> indexes = new List<int>();
                for (int k = 0; k < if_.info.information.up_connection.Count; k++)
                {
                    for (int j = 0; j < Data.Count; j++)
                    {
                        if (if_.info.information.up_connection[k] == Data[j].info.information)
                        {
                            indexes.Add(j);
                            if (Data[j].data == null)
                            {
                                DFS_for_WD(Data[j]);
                                if(Data[j].data == null)
                                {
                                    Data[j].isTrue = false;
                                }
                            }
                            if (!Data[j].isTrue)
                            {
                                throw new Exception();
                            }
                            break;
                        }
                    }
                }
                Math_Field[] opearnds = new Math_Field[indexes.Count];
                int Count = 0;
                for (int i = 0; i < indexes.Count; i++)
                {
                    if (Data[indexes[i]].isTrue)
                    {
                        if (Math_Field.idCOM(Data[indexes[0]].data, Data[indexes[i]].data))
                        {
                            Math_Field.id_to_normal(Data[indexes[0]].data, ref Data[indexes[i]].data);
                        }
                        else
                        {
                            Math_Field.id_to_normal(Data[indexes[i]].data, ref Data[indexes[0]].data);
                        }
                        opearnds[Count] = Data[indexes[i]].data;
                        Count++;
                    }
                }
                switch (if_.info.information.name)
                {
                    case "COM_NN_D":
                        {
                            if (Math_Field.idCOM(Data[indexes[0]].data, Data[indexes[1]].data))
                            {
                                Math_Field.id_to_normal(Data[indexes[0]].data, ref Data[indexes[1]].data);
                                switch (Data[indexes[0]].data.COM(Data[indexes[1]].data))
                                {
                                    case 1:
                                        {
                                            if_.path = 0;
                                        }
                                        break;
                                    case 0:
                                        {
                                            if_.path = 1;
                                        }
                                        break;
                                    case 2:
                                        {
                                            if_.path = 2;
                                        }
                                        break;
                                }
                            }
                            else
                            {
                                Math_Field.id_to_normal(Data[indexes[1]].data, ref Data[indexes[0]].data);
                                switch (Data[indexes[1]].data.COM(Data[indexes[0]].data))
                                {
                                    case 2:
                                        {
                                            if_.path = 0;
                                        }
                                        break;
                                    case 0:
                                        {
                                            if_.path = 1;
                                        }
                                        break;
                                    case 1:
                                        {
                                            if_.path = 2;
                                        }
                                        break;
                                }
                            }
                            return;
                        }
                    case "isDown":
                        {
                            if (Data[indexes[0]].data.isDown)
                            {
                                if_.path = 0;
                            }
                            else
                            {
                                if_.path = 1;
                            }
                            return;
                        }
                }
            }
            catch
            {
                if_.path = -1;
                return;
            }
        }

        public static void DFS_for_WD(Working_data wd)
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
                            DFS_for_if(ifs[k]);
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
            List<int> indexes = new List<int>();
            Operators w = wd.info.information as Operators;
            if (w.Count_of_up_connection != -1 && w.up_Conection.Count != w.Count_of_up_connection)
            {
                wd.isTrue = false;
                return;
            }
            else
            {
                for (int i = 0; i < w.up_Conection.Count; i++)
                {
                    for (int j = 0; j < Data.Count; j++)
                    {
                        if (Data[j].info.information == w.up_Conection[i])
                        {
                            indexes.Add(j);
                            if(Data[j].data == null)
                            {
                                DFS_for_WD(Data[j]);
                                if (Data[j].data == null)
                                {
                                    Data[j].isTrue = false;
                                }
                            }
                            if (!Data[j].isTrue && w.Count_of_up_connection != -1)
                            {
                                wd.isTrue = false;
                                return;
                            }
                            break;
                        }
                    }
                }
                if(w.Count_of_up_connection == 1)
                {
                    wd.data = Config.operands(wd.info.information.name, new Math_Field[] { Data[indexes[0]].data });
                }
                else
                {
                    if(w.Count_of_up_connection == 2)
                    {
                        if(Math_Field.idCOM(Data[indexes[0]].data, Data[indexes[1]].data))
                        {
                            Math_Field.id_to_normal(Data[indexes[0]].data, ref Data[indexes[1]].data);
                        }
                        else
                        {
                            Math_Field.id_to_normal(Data[indexes[1]].data, ref Data[indexes[0]].data);
                        }
                        wd.data = Config.operands(wd.info.information.name, new Math_Field[] { Data[indexes[0]].data, Data[indexes[1]].data });
                    }
                    else
                    {
                        int fall = -1;
                        for(int i = 0; i < indexes.Count; i++)
                        {
                            if(Data[indexes[i]].isTrue)
                            {
                                fall = i;
                                break;
                            }
                        }
                        if(fall != -1)
                        {
                            wd.data = Data[indexes[fall]].data;
                            Math_Field[] opearnds = new Math_Field[indexes.Count];
                            int Count = 0;
                            for(int i = fall + 1; i < indexes.Count; i++)
                            {
                                if (Data[indexes[i]].isTrue)
                                {
                                    if (Math_Field.idCOM(wd.data, Data[indexes[i]].data))
                                    {
                                        Math_Field.id_to_normal(wd.data, ref Data[indexes[i]].data);
                                    }
                                    else
                                    {
                                        Math_Field.id_to_normal(Data[indexes[i]].data, ref wd.data);
                                    }
                                    opearnds[Count] = Data[indexes[i]].data;
                                    Count++;
                                }
                            }
                            Array.Resize(ref opearnds, Count+1);
                            wd.data = Config.operands(wd.info.information.name, opearnds);
                        }
                        else
                        {
                            wd.isTrue = false;
                            return;
                        }
                    }
                }
                if(check)
                {
                    while(wd.data.isDown)
                    {
                        wd.data = wd.data.Dawn();
                    }
                }
            }
        }
    }
}
