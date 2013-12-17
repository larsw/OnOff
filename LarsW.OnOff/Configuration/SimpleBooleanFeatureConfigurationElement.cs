namespace LarsW.OnOff.Configuration
{
    using System.Configuration;

    internal class SimpleBooleanFeatureConfigurationElement : ConfigurationElement, IFeature
    {
        private const string NamePropertyName = "name";
        private const string EnabledPropertyName = "enabled";

        [ConfigurationProperty(NamePropertyName, IsKey = true)]
        public string Name
        {
            get { return base[NamePropertyName] as string; }
            set { base[NamePropertyName] = value; }
        }

        
        [ConfigurationProperty(EnabledPropertyName)]
        public bool Enabled
        {
            get { return (bool) base[EnabledPropertyName]; }
            set { base[EnabledPropertyName] = value; }
        }
    }
}