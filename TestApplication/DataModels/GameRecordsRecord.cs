using FileHelpers;
using TestApplication.DataEnums;

namespace TestApplication.DataModels
{
    [IgnoreFirst(1)]
    [DelimitedRecord(",")]
    class GameRecordsRecord
    {
        public string Category { get; set; }
        public Team RecordTeam { get; set; }
        public int Place { get; set; }
        public int PlayerId { get; set; }
        public int Record { get; set; }
        public int Year { get; set; }
        public Team Team { get; set; }
        public Team Opponent { get; set; }
    }
}
