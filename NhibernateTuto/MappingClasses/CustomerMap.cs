using FluentNHibernate.Mapping;
using NhibernateTuto.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhibernateTuto.MappingClasses
{
    public class CustomerMap: ClassMap <Customer>
    {
        public CustomerMap()
        {
            Id(c => c.Id);
            Map(c => c.FirstName);
            Map(c => c.MiddleName);
            Map(c => c.LastName);
            Map(c => c.age);
            Map(c => c.dob);
            Map(c => c.CreatedDate);
            HasManyToMany(c => c.teamList);

        }
    }
}
