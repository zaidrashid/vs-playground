using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhibernateTuto.DomainClasses
{
    public class Team
    {
        public virtual int teamID { get; set; }
        public virtual string teamName { get; set; }
        public virtual IList<Customer> custList { get; set; }
    }
}
