using DeviceManagement_WebApp.Models;
using System.Collections.Generic;

namespace DeviceManagement_WebApp.Repositories
{
    public interface IDevicesRepository : IGenericRepository<Device>
    {
        public IEnumerable<Device> Incld();
    }

    
}
