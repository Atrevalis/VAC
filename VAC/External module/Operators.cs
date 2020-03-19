using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace External_module
{
    abstract class Operators : Working_data
    {
        static int count_of_operator4s_index = 1;
       protected int count_of_up_connection;
       protected int index_of_Operator;

        protected List<Working_data> up_connection;

        public bool is_up_conection
        {
            get
            {
                return up_connection.Count < count_of_up_connection;
            }
        }

        protected Operators() 
        {
            index_of_Operator = count_of_operator4s_index++;
        }

        public void up_Conected(Working_data data)
        {
            if(up_connection.Count < count_of_up_connection)
            {
                up_connection.Add(data);
            }
        }

    }
}
