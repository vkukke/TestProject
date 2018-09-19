using System;

namespace PrimeService
{
    public class PrimeService
    {
        public bool IsPrime(int num)
        {
            if (num <= 2)
              return false;
            throw new NotImplementedException();
        }

        public int GetSize()
        {
            string str = "{\"eventgridmodule\": {\"properties.desired\": {\"eventSubscriptions\": {\"deviceInventorySubscription\": {\"topic\": \"edgeHub\", \"properties\": { \"destination\": { \"endpointType\":\"webhook\", \"properties\": { \"endpointUrl\": \"https://deviceInventoryModule:999\"}}, \"filter\": {\"includedEventTypes\": [\"Microsoft.Devices.DeviceCreated\", \"Microsoft.Devices.DeviceDeleted\" ], \"subjectBeginsWith\": \"elevators/northcampus\"}}}}}}}";
            return System.Text.ASCIIEncoding.Unicode.GetByteCount(str);
        }
    }
}
