using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialView.Models
{
    public partial class PartialModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }

    public partial class PartialModel
    {
        public List<PartialModel> partialModel { get; set; }
    }
}