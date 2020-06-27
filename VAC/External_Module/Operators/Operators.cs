using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace External_module
{
    public abstract class Operators : Working_data
    {
        static int count_of_operator4s_index = 1;
       protected int count_of_up_connection;
       protected int index_of_Operator;
        public string name_of_operators;

        protected List<Working_data> up_connection = new List<Working_data>();
        public List<if_operator> if_Operators = new List<if_operator>();

        public int Count_of_up_connection
        {
            get
            {
                return count_of_up_connection;
            }
        }

        public override string name
        {
            get
            {
                return name_of_operators;
            }
        }

        public override bool isUpcoonection
        {
            get
            {
                return up_connection.Count < count_of_up_connection || count_of_up_connection == -1;
            }
        }

        protected Operators()
        {
            index_of_Operator = count_of_operator4s_index++;
        }

        public List<Working_data> up_Conection
        {
            get
            {
                return up_connection;
            }
        }

        public Working_data up_Conected
        {
            set
            {
                if (up_connection.Count < count_of_up_connection || count_of_up_connection == -1)
                {
                    up_connection.Add(value);
                }
            }
        }

        public void If_operator_conected(if_operator if_)
        {
            if_Operators.Add(if_);
        }

        public override bool isDelete
        {
            get
            {
                return base.isDelete && up_connection.Count == 0;
            }
        }

        public override void Delete()
        {
            base.Delete();
            while(up_connection.Count != 0)
            {
                up_connection.RemoveAt(0);
            }
        }

        public override void Delete_Element(Noda elements)
        {
            base.Delete_Element(elements);

            for(int i = 0; i < up_connection.Count; i++)
            {
                if(elements == up_connection[i])
                {
                    up_connection.RemoveAt(i);
                    return;
                }
            }

            for(int i = 0; i < if_Operators.Count; i++)
            {
                if(elements == if_Operators[i])
                {
                    if_Operators.RemoveAt(i);
                    return;
                }
            }
        }

    }
}
