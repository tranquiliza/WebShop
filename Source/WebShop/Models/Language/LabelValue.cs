using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models.Language
{
    public class LabelValue : Entity
    {
        public string Value { get; set; }

        public Language Language { get; set; }
    }
}
