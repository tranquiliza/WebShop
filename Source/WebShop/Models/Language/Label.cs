using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models.Language
{
    public class Label : Entity
    {
        public string Alias { get; set; }

        public LabelValue Value { get; set; }
    }
}
