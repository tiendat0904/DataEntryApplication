using DataEntryApplication.Server.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataEntryApplication.Server.Services.Interfaces
{
     public interface ICmd2Service
    {
        Task<IList<CMD2>> GetValuesOfCMD2();
        Task Save(IList<CMD2> values);
    }
}
