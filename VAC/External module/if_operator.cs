using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace External_module
{
    class if_operator : Noda
    {

        int count_of_up_connection;

        List<Working_data> up_connection = new List<Working_data>();

        public int Count_of_up_connection
        {
            set
            {
                count_of_up_connection = value;
            }
        }

        public void Up_connected(Working_data data)
        {
            if(up_connection.Count < count_of_up_connection)
            {
                up_connection.Add(data);
            }
        }

        public override bool isDelite
        {
            get
            {
                return false;
            }
        }

        public override void Delite()
        {

        }
    }
}
