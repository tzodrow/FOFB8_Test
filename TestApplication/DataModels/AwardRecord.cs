using FileHelpers;
using TestApplication.DataEnums;

namespace TestApplication.DataModels
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
