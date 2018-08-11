using FileHelpers;
using FOF8Test.DataEnums;

namespace FOF8Test.DataModels
{
    [IgnoreFirst(1)]
    [DelimitedRecord(",")]
    class AwardRecord
    {
        public int Year { get; set; }
        public string Name { get; set; }
        public int PlayerCoachId { get; set; }
        public Team Team { get; set; }
    }
}
