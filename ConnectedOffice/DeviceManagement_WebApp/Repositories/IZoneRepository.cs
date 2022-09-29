using DeviceManagement_WebApp.Models;

namespace DeviceManagement_WebApp.Repositories
{
    public interface IZoneRepository : IGenericRepository<Zone>
    {
        //This interface class contains all additional methods used in the ZoneController
        //the implementation of these methods are contained in the ZoneRepository class
        Zone GetMostRecentZone();

    }
}