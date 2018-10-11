using System.Linq;
using WebShop.Contracts.Label;
using WebShop.Models.Languages;

namespace WebShop.Translaters
{
    public static class LabelTranslator
    {
        public static LabelAliasDto TranslateToLabelAliasDto(this Label label)
        {
            return new LabelAliasDto()
            {
                LabelId = label.Id,
                LabelAlias = label.Alias,
                LabelValues = label.LabelValues.Select(value => value.TranslateValue()),
            };
        }

        public static LabelValueDto TranslateValue(this LabelValue labelValue)
        {
            return new LabelValueDto()
            {
                Id = labelValue.Id,
                IsoCode = labelValue.Language.IsoCode,
                Language = labelValue.Language.LanguageName,
                Value = labelValue.Value
            };
        }

        public static LanguageLabelDto TranslateToLanguageLabelsFor(this Label label, string isoCode)
        {
            return new LanguageLabelDto()
            {
                Alias = label.Alias,
                Value = label.LabelValues.FirstOrDefault(x => x.Language.IsoCode == isoCode)?.Value
            };
        }
    }
}
