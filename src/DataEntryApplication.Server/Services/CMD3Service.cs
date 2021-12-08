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
    public class CMD3Service : BaseService, ICmd3Service
    {
        public CMD3Service(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
        public async Task<CMD3> GetValuesOfCMD3()
        {
            var _CMD3 = new CMD3();
            var query1 = DbContext.CMD3Label1;
            var query2 = DbContext.CMD3Label3;
            _CMD3.ListCMD3Label1 = await query1.ToListAsync();
            _CMD3.ListCMD3Label3 = await query2.ToListAsync();
            return _CMD3;
        }

        public async Task Save(CMD3 values)
        {
            DbContext.UpdateRange(values.ListCMD3Label1);
            DbContext.UpdateRange(values.ListCMD3Label3);
            await DbContext.SaveChangesAsync();
        }
    }
}
