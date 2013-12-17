namespace LarsW.OnOff
{
    using System;
    using Configuration;

    internal class SimpleBooleanFeatureManager : FeatureManager
    {
        private readonly FeaturesDynamicProxy _features;

        public SimpleBooleanFeatureManager(IFeatureCollection features)
            : this(name => features.GetByName(name).Enabled)
        {
        }

        public SimpleBooleanFeatureManager(Func<string, bool> lookupFunc)
        {
            if (lookupFunc == null) throw new ArgumentNullException("lookupFunc");

            _features = new FeaturesDynamicProxy(lookupFunc);
        }

        public override dynamic Features
        {
            get { return _features; }
        }
    }
}