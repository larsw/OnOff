namespace LarsW.OnOff.Configuration
{
    public interface IFeature
    {
        string Name { set; }

        bool Enabled { get; }
    }
}