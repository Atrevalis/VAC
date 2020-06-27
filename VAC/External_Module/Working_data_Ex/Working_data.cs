using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace External_module
{
    public abstract class Working_data : Noda
    {
        private List<Noda> down_contacts = new List<Noda>();

        public override bool isDowncoonection
        {
            get
            {
                return true;
            }
        }

        public Noda down_contacted
        {
            set
            {
                if (!ReferenceEquals(value.GetType(), Type.GetType("Data")))
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
            while (down_contacts.Count != 0)
            {
                down_contacts.RemoveAt(0);
            }
        }

        public override void Delete_Element(Noda noda)
        {
            for (int i = 0; i < down_contacts.Count; i++)
            {
                if (noda == down_contacts[i])
                {
                    down_contacts.RemoveAt(i);
                    return;
                }
            }
        }

    }
}
