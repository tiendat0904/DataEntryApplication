using DataEntryApplication.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataEntryApplication.Client.Services.Interfaces
{
    public interface ICMD2Services
    {
        Task<IList<CMD2Model>> GetValuesOfCMD2();
        Task<bool> Save(IList<CMD2Model> values, int mode);
    }
}
