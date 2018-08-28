using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models.Language
{
    public class Label : Entity
    {
        public string Alias { get; private set; }

        private Label() { }

        public Label(string alias)
        {
            if (string.IsNullOrWhiteSpace(alias)) throw new ArgumentException("Alias cannot be empty", nameof(alias));

            Alias = alias;
        }
    }
}
