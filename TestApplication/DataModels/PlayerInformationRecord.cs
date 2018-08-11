using FileHelpers;
using System;
using TestApplication.DataEnums;

namespace TestApplication.DataModels
{
    [IgnoreFirst(1)]
    [DelimitedRecord(",")]
    class PlayerInformationRecord
    {
        public int PlayerId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public bool Junior { get; set; }
        public string NickName { get; set; }
        public PlayerPosition PlayerPosition { get; set; }
        public int PlayerOfTheGameAwards { get; set; }
        public int ChampionshipRings { get; set; }
        public int PlayerOfTheWeekAwards { get; set; }
        public int PlayerOfTheWeekWins { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public bool HallOfFame { get; set; }
        public int YearInducted { get; set; }
        public int PercentageOfVote { get; set; }
        public Team ChosenTeam { get; set; }
        public int YearBorn { get; set; }
        public int MonthBorn { get; set; }
        public int DayBorn { get; set; }
        public College College { get; set; }
        public int DraftRound { get; set; }
        public int DraftPosition { get; set; }
        public Team DraftedTeam { get; set; }
        public int DraftYear { get; set; }

        // Quarterback Specific
        public int ForthQuarterCombacks { get; set; }
        public int QuarterbackWins { get; set; }
        public int QuarterbackLosses { get; set; }
        public int QuarterbackTies { get; set; }

        public Town HomeTown { get; set; }
        public State HomeState { get; set; }
        public int GamesPlayed { get; set; }
        public int SeasonsPlayed { get; set; }

        public int SeasonPointer1 { get; set; }
        public int SeasonPointer2 { get; set; }
        public int SeasonPointer3 { get; set; }
        public int SeasonPointer4 { get; set; }
        public int SeasonPointer5 { get; set; }
        public int SeasonPointer6 { get; set; }
        public int SeasonPointer7 { get; set; }
        public int SeasonPointer8 { get; set; }
        public int SeasonPointer9 { get; set; }
        public int SeasonPointer10 { get; set; }
        public int SeasonPointer11 { get; set; }
        public int SeasonPointer12 { get; set; }
        public int SeasonPointer13 { get; set; }
        public int SeasonPointer14 { get; set; }
        public int SeasonPointer15 { get; set; }
        public int SeasonPointer16 { get; set; }
        public int SeasonPointer17 { get; set; }
        public int SeasonPointer18 { get; set; }
        public int SeasonPointer19 { get; set; }
        public int SeasonPointer20 { get; set; }

        public int SeasonYear1 { get; set; }
        public int SeasonYear2 { get; set; }
        public int SeasonYear3 { get; set; }
        public int SeasonYear4 { get; set; }
        public int SeasonYear5 { get; set; }
        public int SeasonYear6 { get; set; }
        public int SeasonYear7 { get; set; }
        public int SeasonYear8 { get; set; }
        public int SeasonYear9 { get; set; }
        public int SeasonYear10 { get; set; }
        public int SeasonYear11 { get; set; }
        public int SeasonYear12 { get; set; }
        public int SeasonYear13 { get; set; }
        public int SeasonYear14 { get; set; }
        public int SeasonYear15 { get; set; }
        public int SeasonYear16 { get; set; }
        public int SeasonYear17 { get; set; }
        public int SeasonYear18 { get; set; }
        public int SeasonYear19 { get; set; }
        public int SeasonYear20 { get; set; }
    }
}
