using FluentNHibernate.Mapping;
using NhibernateTuto.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhibernateTuto.MappingClasses
{
    public class TeamMapping: ClassMap<Team>
    {
        public TeamMapping()
        {
            Id(item => item.teamID);
            Map(item => item.teamName);
            HasManyToMany(item => item.custList);

        }
    }
}
