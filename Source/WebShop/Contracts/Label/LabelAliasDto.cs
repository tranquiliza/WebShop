using System.Collections.Generic;

namespace WebShop.Contracts.Label
{
    public class LabelAliasDto
    {
        public int LabelId { get; set; }

        public string LabelAlias { get; internal set; }

        public IEnumerable<LabelValueDto> LabelValues { get; set; }
    }
}
