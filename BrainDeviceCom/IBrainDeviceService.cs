namespace BrainDeviceCom
{
    public interface IBrainDeviceService
    {
        void Connect();
        void Start();
        void Stop();
        void Query();
        void SetParam();
        void Reset();
    }
}