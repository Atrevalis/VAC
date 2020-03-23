using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace External_module
{
    abstract class Working_data : Noda
    {
        private List<Noda> down_contacts = new List<Noda>();

        public Noda down_contacted
        {
            set
            {
                if(!ReferenceEquals(value.GetType(), Type.GetType("Data") ))
                {
                    down_contacts.Add(value);
                }
            }
        }

        public List<Noda> down_Contacted
        {
            get
            {
                return down_contacts;
            }
        }

        public override bool isDelete
        {
            get
            {
                return down_contacts.Count == 0;
            }
        }

        public override void Delete()
        {
            while(down_contacts.Count != 0)
            {
                down_contacts.RemoveAt(0);
            }
        }

    }
}
