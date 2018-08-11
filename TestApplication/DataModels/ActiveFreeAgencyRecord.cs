using FileHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.DataEnums;

namespace TestApplication.DataModels
{
    [IgnoreFirst(1)]
    [DelimitedRecord(",")]
    class ActiveFreeAgencyRecord
    {
        public int FreeAgencyId { get; set; }
        public int PlayerId { get; set; }
        public Team Team { get; set; }
        public int Value { get; set; }
        public int Years { get; set; }
        public int SigningStage { get; set; }
    }
}
