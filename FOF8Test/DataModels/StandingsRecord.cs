using FileHelpers;
using FOF8Test.DataEnums;

namespace FOF8Test.DataModels
{
    [IgnoreFirst(1)]
    [DelimitedRecord(",")]
    class StandingsRecord
    {
        public int Year { get; set; }
        public string Division { get; set; }
        public int Place { get; set; }
        public Team Team { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Ties { get; set; }
        public string Note { get; set; }
        public int PointsScored { get; set; }
        public int PointsAllowed { get; set; }
        public int ConferenceWins { get; set; }
        public int ConferenceLosses { get; set; }
        public int ConferenceTies { get; set; }
        public int DivisionWins { get; set; }
        public int DivisionLosses { get; set; }
        public int DivisionTies { get; set; }
    }
}
