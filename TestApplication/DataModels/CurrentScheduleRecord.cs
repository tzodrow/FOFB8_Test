using FileHelpers;
using TestApplication.DataEnums;

namespace TestApplication.DataModels
{
    [IgnoreFirst(1)]
    [DelimitedRecord(",")]
    class CurrentScheduleRecord
    {
        public string Week { get; set; }
        public Team VisitorTeam { get; set; }
        public Team HomeTeam { get; set; }
    }
}
