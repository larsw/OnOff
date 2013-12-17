 namespace LarsW.OnOff.Configuration
{
    using System.Collections.Generic;

    public interface IFeatureCollection
    {
        ICollection<IFeature> GetAll();
        IFeature GetByName(string name);
    }
}