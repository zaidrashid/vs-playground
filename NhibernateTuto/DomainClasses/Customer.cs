using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhibernateTuto.DomainClasses
{
    public class Customer: BaseObject
    {
        public virtual int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string MiddleName { get; set; }
        public virtual string LastName { get; set; }
        public virtual long age { get; set; }
        public virtual DateTime dob { get; set; }
        public virtual IList<Team> teamList { get; set; }
        
    }
}
