using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace CJ.ABPVueDemo.Localization
{
    public static class ABPVueDemoLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ABPVueDemoConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ABPVueDemoLocalizationConfigurer).GetAssembly(),
                        "CJ.ABPVueDemo.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
