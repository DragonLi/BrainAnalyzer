namespace BrainDeviceCom
{
    public static class ComConst
    {
        public const byte PackageStart = 0XA0;
        public const byte PackageEnd = 0XC0;
        public const int BufferSize = 1024;//in bytes
        public const int BufferCount = 2;
        public const int TimeOutMilliSec = 100;//in milliseconds
    }
    
    public enum DeviceStatus
    {
        DevOffLine,
        DevOnLine,
        DevSampling,
        DevError,
        DevResponseTimeOut,
    }

    public enum DeviceErrorCode
    {
        OpSuccess,
        OpFailed,
        OpTimeout,
    }

    public enum DeviceCommandCategory
    {
        SampleCmd,
        SetParamCmd,
        QueryParamCmd,
    }

    public struct SamplePackage
    {
        
    }
    
    public struct DeviceParam
    {
        
    }

    public interface IDeviceConfig
    {
        string Host { get; }
        int Port { get; }
    }

}