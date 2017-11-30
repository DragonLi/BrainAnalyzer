using System;

namespace BrainDeviceCom
{
    public class BrainDeviceServiceImpl : IBrainDeviceService
    {
        public IObservable<DeviceStatus> Connect(IDeviceConfig cfg)
        {
            throw new NotImplementedException();
        }

        public IObservable<DeviceParam> Query()
        {
            throw new NotImplementedException();
        }

        public IObservable<SamplePackage> Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void SetParam()
        {
            throw new NotImplementedException();
        }
    }
}