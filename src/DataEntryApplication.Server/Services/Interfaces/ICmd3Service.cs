using DataEntryApplication.Server.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataEntryApplication.Server.Services.Interfaces
{
    public interface ICmd3Service
    {
        Task<CMD3> GetValuesOfCMD3();
        Task Save(CMD3 values);
    }
}
