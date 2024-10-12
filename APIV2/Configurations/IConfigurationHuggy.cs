namespace APIV2.Configurations
{
    public interface IConfigurationHuggy
    {
        string ContentType { get; }
        string Accept { get; }
        string Authorization { get; }
    }
}
