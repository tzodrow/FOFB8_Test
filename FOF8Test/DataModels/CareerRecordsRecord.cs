using FileHelpers;
using FOF8Test.DataEnums;

namespace FOF8Test.DataModels
{
    [IgnoreFirst(1)]
    [DelimitedRecord(",")]
    class CareerRecordsRecord
    {
        public string Category { get; set; }
        public Team Team { get; set; }
        public int Place { get; set; }
        public int PlayerId { get; set; }
        public int Record { get; set; }
        public int Year { get; set; }
    }
}
