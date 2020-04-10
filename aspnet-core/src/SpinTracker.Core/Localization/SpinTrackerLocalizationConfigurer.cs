using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace SpinTracker.Localization
{
    public static class SpinTrackerLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(SpinTrackerConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(SpinTrackerLocalizationConfigurer).GetAssembly(),
                        "SpinTracker.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
