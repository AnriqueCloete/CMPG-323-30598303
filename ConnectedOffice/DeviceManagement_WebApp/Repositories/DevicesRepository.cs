using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repositories
{
    public class DevicesRepository : GenericRepository<Device>, IDevicesRepository
    {

        public DevicesRepository(ConnectedOfficeContext context) : base(context)
        {
        }

        public IEnumerable<Device> Incld()
        {
            return (IEnumerable<Device>)_context.Device.Include(d => d.Category).Include(d => d.Zone);
        }
    }
}