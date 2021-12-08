using DataEntryApplication.Server.Data;
using DataEntryApplication.Server.Data.Entities;
using DataEntryApplication.Server.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataEntryApplication.Server.Services
{
    public class CMD2Service : BaseService, ICmd2Service
    {
        public CMD2Service(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<IList<CMD2>> GetValuesOfCMD2()
        {
            var query = DbContext.CMD2;
            var values = await query.ToListAsync();
            return values;
        }

        public async Task Save(IList<CMD2> values)
        {
            DbContext.UpdateRange(values);
            await DbContext.SaveChangesAsync();
        }
    }
}
