using System;
using System.Collections.Generic;

namespace WebShop.Models.Language
{
    public class Label : Entity
    {
        public string Alias { get; private set; }

        public ICollection<LabelValue> LabelValues { get; private set; }

        private Label() { }

        public Label(string alias)
        {
            if (string.IsNullOrWhiteSpace(alias)) throw new ArgumentException("Alias cannot be empty", nameof(alias));

            Alias = alias;
        }
    }
}
