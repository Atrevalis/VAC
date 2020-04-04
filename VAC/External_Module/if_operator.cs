using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace External_module
{
    public class if_operator : Noda
    {

        int count_of_up_connection;

        List<Working_data> up_connection = new List<Working_data>();
        public List<Noda>[] exits;
        public List<if_operator> if_Operators = new List<if_operator>();
        public string[] names_of_exits;

        public int Count_of_up_connection
        {
            set
            {
                count_of_up_connection = value;
            }
        }

        public override bool isDowncoonection
        {
            get
            {
                return true;
            }
        }

        public override bool isUpcoonection
        {
            get
            {
                return up_connection.Count < count_of_up_connection;
            }
        }

        public void Up_connected(Working_data data)
        {
            if(up_connection.Count < count_of_up_connection)
            {
                up_connection.Add(data);
            }
        }

        public void Down_connection(byte exit, Noda noda)
        {
            if (noda.GetType() != Type.GetType("Data"))
            {
                exits[exit].Add(noda);
            }
        }

        public override bool isDelete
        {
            get
            {
                bool isTrue;
                for(int i = 0; i < exits.Length; i++) 
                    if(exits[i].Count != 0)
                    {
                        return false;
                    }
                return up_connection.Count == 0;
            }
        }

        public override void Delete()
        {
            while (up_connection.Count != 0) up_connection.RemoveAt(0);
            for(int i = 0; i < exits.Length; i++)
            {
                while (exits[i].Count != 0) exits[i].RemoveAt(0);
            }
        }
    }
}
