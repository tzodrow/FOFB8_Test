using FileHelpers;
using TestApplication.DataEnums;

namespace TestApplication.DataModels
{
    [IgnoreFirst(1)]
    [DelimitedRecord(",")]
    class GameInformationRecord
    {
        public int Year { get; set; }
        public int GameId { get; set; }
        public string Week { get; set; }
        public int VisitorScore { get; set; }
        public Team VisitorTeam { get; set; }
        public int HomeScore { get; set; }
        public Team HomeTeam { get; set; }
        public int Attendance { get; set; }
        public string Weather { get; set; }
        public int Temperature { get; set; }
        public int Wind { get; set; }
        public int VisitorQuarterback { get; set; }
        public int HomeQuarterback { get; set; }
        public int VisitorRunningback { get; set; }
        public int HomeRunningback { get; set; }
        public int VisitorReceiver { get; set; }
        public int HomeReceiver { get; set; }
        public int VisitorQuarterbackPassAttempts { get; set; }
        public int VisitorQuarterbackCompletions { get; set; }
        public int VisitorQuarterbackPassingYards { get; set; }
        public int HomeQuarterbackPassAttempts { get; set; }
        public int HomeQuarterbackCompletions { get; set; }
        public int HomeQuarterbackPassingYards { get; set; }
        public int VisitorLeaderRushes { get; set; }
        public int VisitorLeaderRushingYards { get; set; }
        public int HomeLeaderRushes { get; set; }
        public int HomeLeaderRushingYards { get; set; }
        public int VisitingLeaderReceptions { get; set; }
        public int VisitingLeaderReceivingYards { get; set; }
        public int HomeLeaderReceptions { get; set; }
        public int HomeLeaderReceivingYards { get; set; }
    }
}
