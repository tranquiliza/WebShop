using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Contracts.Label;
using WebShop.Models.Language;

namespace WebShop.Translaters
{
    public static class LabelTranslator
    {
        public static LabelDto Translate(this LabelValue labelValue)
        {
            return new LabelDto()
            {
                Alias = labelValue.Alias,
                Value = labelValue.Value
            };
        }
    }
}
