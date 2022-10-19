using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace modelConfigurator.Localization
{
    public static class modelConfiguratorLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(modelConfiguratorConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(modelConfiguratorLocalizationConfigurer).GetAssembly(),
                        "modelConfigurator.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
