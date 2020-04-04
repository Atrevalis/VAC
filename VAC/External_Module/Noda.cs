using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace External_module
{
    abstract public class Noda
    {
        public string type = "Noda";
        public abstract void Delete();

        public virtual bool isUpcoonection
        {
            get
            {
                return false;
            }
        }

        public virtual bool isDowncoonection
        {
            get
            {
                return false;
            }
        }

        public abstract bool isDelete
        {
            get;
        }
    }
}
