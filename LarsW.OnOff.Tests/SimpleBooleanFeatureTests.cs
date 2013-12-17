namespace LarsW.OnOff.Tests
{
    using Xunit;

    public class SimpleBooleanFeatureTests
    {
        [FactAttribute]
        public void Feature_Foo_is_Enabled()
        {
            var manager = ConfigurationFileFeatureManager.Create("simpleFeatures");
            Assert.True(manager.Features.Foo);
        }

        [FactAttribute]
        public void Feature_Bar_is_Disabled()
        {
            var manager = ConfigurationFileFeatureManager.Create("simpleFeatures");
            Assert.False(manager.Features.Bar);
        }
    }
}
