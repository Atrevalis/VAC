using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace External_module
{
    public class Data : Working_data
    {
        public string data_name;

        public override string name
        {
            get
            {
                return data_name;
            }
        }

    }
}
