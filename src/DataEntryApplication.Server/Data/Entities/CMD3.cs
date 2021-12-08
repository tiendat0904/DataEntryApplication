using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataEntryApplication.Server.Data.Entities
{
    public class CMD3
    {
        public List<CMD3Label1> ListCMD3Label1 { get; set; }
        public List<CMD3Lable3> ListCMD3Label3 { get; set; }
    }

    public class CMD3Label1
    {
        public int Id { get; set; }

        public int EC1 { get; set; }

        public int EC2 { get; set; }

        public int EC3 { get; set; }

        public int EC4 { get; set; }
    }
    
    public class CMD3Lable3
    {
        public int Id { get; set; }

        public float L4 { get; set; }

        public float L5 { get; set; }
    }
}
