using DeviceManagement_WebApp.Models;
using System.Collections.Generic;

namespace DeviceManagement_WebApp.Repositories
{
    public interface IDevicesRepository : IGenericRepository<Device>
    {

        //This interface class contains all additional methods used in the DevicesController
        //the implementation of these methods are contained in the DevicesRepository class
        public IEnumerable<Device> Incld();
    }

    
}
