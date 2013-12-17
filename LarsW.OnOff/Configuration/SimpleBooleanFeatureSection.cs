namespace LarsW.OnOff.Configuration
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Configuration;
    using System.Linq;

    [ConfigurationCollection(typeof(SimpleBooleanFeatureConfigurationElement), 
                             AddItemName = AddItemName)]
    internal class SimpleBooleanFeatureSection : ConfigurationSection, IFeatureCollection
    {
        private const string AddItemName = "feature";
        
        [ConfigurationProperty("", IsDefaultCollection = true)]
        [ConfigurationCollection(typeof(SimpleBooleanFeatureConfigurationElement), AddItemName = "feature")]
        public SimpleBooleanFeatureCollection Features
        {
            get { return base[""] as SimpleBooleanFeatureCollection; }
            set { base[""] = value; }
        }

        public ICollection<IFeature> GetAll()
        {
            return new Collection<IFeature>(Features.Cast<IFeature>().ToList());
        }

        public IFeature GetByName(string name)
        {
            return Features[name];
        }
    }
}
