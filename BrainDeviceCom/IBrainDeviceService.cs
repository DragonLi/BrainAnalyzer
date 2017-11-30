using System;

namespace BrainDeviceCom
{
    public interface IBrainDeviceService
    {
        /// <summary>
        /// return the stream of device status,closed if connect failed
        /// client should reconnect when the stream is closed
        /// </summary>
        /// <returns></returns>
        IObservable<DeviceStatus> Connect(IDeviceConfig cfg);

        /// <summary>
        /// client should query the device parameter before starting sampling
        /// </summary>
        /// <returns></returns>
        IObservable<DeviceParam> Query();
        
        /// <summary>
        /// throw exception, if sampling is already started
        /// </summary>
        /// <returns></returns>
        IObservable<SamplePackage> Start();
        
        /// <summary>
        /// nothing happen if not sampling 
        /// </summary>
        void Stop();
        
        /// <summary>
        /// reset device if some unknow error occur and client need to be rescued
        /// </summary>
        void Reset();
        
        /// <summary>
        /// if setting the parameter success,
        /// then the stream of device parameter return by Query() will send a notification  
        /// </summary>
        void SetParam();
    }

}