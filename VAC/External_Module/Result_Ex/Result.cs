using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace External_module
{
    public class Result : Noda
    {
        private Working_data up_connection;
        private static int count_of_results_index = 1;
        public List<if_operator> if_Operators = new List<if_operator>();
        private int index_of_result;

        public override string name
        {
            get
            {
                return "Result";
            }
        }

        public override bool isUpcoonection
        {
            get
            {
                if (up_connection == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Result()
        {
            type = "Result";
            index_of_result = count_of_results_index++;
        }

        public int Index_of_result
        {
            get
            {
                return index_of_result;
            }
        }
        public Working_data up_Conected
        {

            get
            {
                return up_connection;
            }

            set
            {
                if (up_connection == null)
                {
                    up_connection = value;
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
                return up_connection == null;
            }
        }

        public override void Delete()
        {
            up_connection = null;
        }

        public override void Delete_Element(Noda elements)
        {
            if (elements == up_connection)
            {
                up_connection = null;
                return;
            }
            for (int i = 0; i < if_Operators.Count; i++)
            {
                if (elements == if_Operators[i])
                {
                    if_Operators.RemoveAt(i);
                    return;
                }
            }
        }
    }
}
