namespace LarsW.OnOff
{
    using System;
    using System.Dynamic;

    internal class FeaturesDynamicProxy : DynamicObject
    {
        private readonly Func<string, bool> _lookupFunc;

        public FeaturesDynamicProxy(Func<string, bool> lookupFunc)
        {
            _lookupFunc = lookupFunc;
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            try
            {
                var value = _lookupFunc(binder.Name);
                result = value;
                return true;
            }
            catch
            {
            }
            result = null;
            return false;
        }
    }
}
