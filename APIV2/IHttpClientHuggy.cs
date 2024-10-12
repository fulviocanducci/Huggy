using APIV2.Https;

namespace APIV2
{
    public interface IHttpClientHuggy
    {
        IAgentHttp Agent { get; }
    }
}