namespace LarsW.OnOff
{
    using System;
    using System.Configuration;
    using Configuration;

    public abstract class ConfigurationFileFeatureManager : FeatureManager
    {
        public static FeatureManager Create(string sectionName)
        {
            if (sectionName == null) throw new ArgumentNullException("sectionName");

            var section = ConfigurationManager.GetSection(sectionName);
            if (section == null)
            {
                throw new ConfigurationErrorsException("No section named " + sectionName);
            }
            var simpleSection = section as SimpleBooleanFeatureSection;
            if (simpleSection != null)
            {
                return new SimpleBooleanFeatureManager(simpleSection);
            }
            throw new InvalidOperationException("Unknown section type: " + section.GetType().Name);
        }
    }
}