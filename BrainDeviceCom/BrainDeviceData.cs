using System.Net;

namespace BrainDeviceCom
{
    public static class ComConst
    {
        public const byte PackageStart = 0XA0;
        public const byte PackageEnd = 0XC0;
        public const int BufferSize = 1024;//in bytes
        public const int BufferCount = 2;
    }
    
    public enum DeviceStatus
    {
        DevOffLine,
        DevOnLine,
        DevSampling,
        DevError,
    }

    public enum DeviceErrorCode
    {
        OpSuccess,
        OpFailed,
    }

    public enum DeviceCommandCategory
    {
        SampleCmd,
        SetParamCmd,
        QueryParamCmd,
    }
    
    public class DeviceConfig
    {
        public string Host;
        public int Port;
    }

    public class DeviceParam
    {
        
    }

}