using FileHelpers;
using FOF8Test.DataEnums;

namespace FOF8Test.DataModels
{
    [IgnoreFirst(1)]
    [DelimitedRecord(",")]
    class StaffHistoryRecord
    {
        public int StaffId { get; set; }
        public int Year { get; set; }
        public string Role { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Ties { get; set; }
        public string Playoffs { get; set; }
        public Team Team { get; set; }
    }
}
