using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Zone = DeviceManagement_WebApp.Models.Zone;

namespace DeviceManagement_WebApp.Repositories
{
    public class ZoneRepository : GenericRepository<Zone>, IZoneRepository
    {

        public ZoneRepository(ConnectedOfficeContext context) : base(context)
        {
        }

        public Zone GetMostRecentZone()
        {
            return _context.Zone.OrderByDescending(zone => zone.DateCreated).FirstOrDefault();
        }
    }
}
