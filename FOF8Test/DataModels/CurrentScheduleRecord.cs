using FileHelpers;
using FOF8Test.DataEnums;

namespace FOF8Test.DataModels
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
