namespace LarsW.OnOff.Configuration
{
    using System.Configuration;


    internal class SimpleBooleanFeatureCollection : ConfigurationElementCollection
    {
        public new SimpleBooleanFeatureConfigurationElement this[string name]
        {
            get { return BaseGet(name) as SimpleBooleanFeatureConfigurationElement; }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new SimpleBooleanFeatureConfigurationElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((SimpleBooleanFeatureConfigurationElement) element).Name;
        }
    }
}