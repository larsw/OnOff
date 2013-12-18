namespace LarsW.OnOff.Tests
{
    using Xunit;

    public class SimpleBooleanFeatureTests
    {
        private const string FeatureSetName = "featureSet1";

        [FactAttribute]
        public void Feature_Foo_is_Enabled()
        {
            var manager = ConfigurationFileFeatureManager.Create(FeatureSetName);
            Assert.True(manager.Features.Foo);
        }

        [FactAttribute]
        public void Feature_Bar_is_Disabled()
        {
            var manager = ConfigurationFileFeatureManager.Create(FeatureSetName);
            Assert.False(manager.Features.Bar);
        }
    }
}
