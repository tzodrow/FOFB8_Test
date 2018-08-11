using FileHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.DataEnums;

namespace TestApplication.DataModels
{
    [IgnoreFirst(1)]
    [DelimitedRecord(",")]
    class PlayerSeasonRecord
    {
        public int RecordNumber { get; set; }
        public int PlayerId { get; set; }
        public int Week { get; set; }
        public int Year { get; set; }
        public Team Team { get; set; }
        public bool Active { get; set; }
        public bool Started { get; set; }

        // Quarterback
        public int PassesAttempted { get; set; }
        public int PassesCompleted { get; set; }
        public int PassingYards { get; set; }
        public int LongestPass { get; set; }
        public int TouchdownPasses { get; set; }
        public int PassingInterceptions { get; set; }
        public int TakenSacks { get; set; }
        public int TakenSackYards { get; set; }

        // Quarterback / Runningback / Fullback / Wide Reciever / Tight Ends
        public int Rushes { get; set; }
        public int RushingYards { get; set; }
        public int LongestRun { get; set; }
        public int RushingTouchdowns { get; set; }

        // Runningback / Fullback / Wide Reciever / Tight Ends
        public int Catches { get; set; }
        public int ReceivingYards { get; set; }
        public int LongestReception { get; set; }
        public int ReceivingTouchdowns { get; set; }
        public int Targets { get; set; }
        public int YardsAfterCatch { get; set; }
        public int Drops { get; set; }

        // Returners
        public int PuntReturns { get; set; }
        public int PuntReturnYards { get; set; }
        public int PuntReturnTouchdowns { get; set; }
        public int KickReturns { get; set; }
        public int KickReturnYards { get; set; }
        public int KickReturnTouchdowns { get; set; }

        public int Fumbles { get; set; }
        public int ForceFumbles { get; set; }
        public int FumblesRecovered { get; set; }
        public int FumblesReturnedForTouchdown { get; set; }

        // Blockers
        public int KeyRunBlocks { get; set; }
        public int BlockOpportunities { get; set; }
        public int SacksAllowed { get; set; }

        // Defender
        public int Tackles { get; set; }
        public int AssistedTackles { get; set; }
        public double Sacks { get; set; }
        public int DefensiveInterceptions { get; set; }
        public int InterceptionReturnYards { get; set; }
        public int InterceptionsReturnedForTouchdown { get; set; }
        public int PassesDefended { get; set; }
        public int PassesBlocked { get; set; }
        public int Hurries { get; set; }
        public int PassesCaughtAgainst { get; set; }
        public int PassPlays { get; set; }
        public int RunPlays { get; set; }

        // Kickers
        public int FieldGoalsMade { get; set; }
        public int FieldGoalsAttempted { get; set; }
        public int LongestFieldGoal { get; set; }
        public int PointAfterTouchdowns { get; set; }
        public int PointAfterTouchdownAttempted { get; set; }

        // Punter
        public int Punts { get; set; }
        public int PuntYards { get; set; }
        public int LongestPunt { get; set; }
        public int PuntsInsideTwenty { get; set; }

        public int PointsScored { get; set; }
        public Team Opponent { get; set; }

        // Third Down Offense
        public int ThirdDownRuns { get; set; }
        public int ThirdDownRunsConverted { get; set; }
        public int ThirdDownPassAttempts { get; set; }
        public int ThirdDownCompletions { get; set; }
        public int ThirdDownPassesConverted { get; set; }
        public int ThirdDownTargets { get; set; }
        public int ThirdDownCatches { get; set; }
        public int ThirdDownCatchesConverted { get; set; }

        // First Downs
        public int FirstDownRushes { get; set; }
        public int FirstDownPassAttempts { get; set; }
        public int FirstDownCatches { get; set; }

        // Kicking
        public int FortyPlusYardFieldGoalsAttmpted { get; set; }
        public int FortyPlusYardFieldGoalsMade { get; set; }
        public int FiftyPlusYardFieldGoalsAttmpted { get; set; }
        public int FiftyPlusYardFieldGoalsMade { get; set; }

        // Punting
        public int NetPuntingYards { get; set; }

        public int SpecialTeamsTackles { get; set; }
        public int QuarterbackKnockDowns { get; set; }

        // Redzone
        public int RedZoneRuns { get; set; }
        public int RedZoneRushingYards { get; set; }
        public int RedZonePassAttempts { get; set; }
        public int RedZoneCompletions { get; set; }
        public int RedZonePassingYards { get; set; }
        public int RedZoneTargets { get; set; }
        public int RedZoneCatches { get; set; }
        public int RedZoneReceivingYards { get; set; }

        public int TotalTouchdowns { get; set; }
        public int TwoPointConversions { get; set; }

        // Blocking
        public int PancakeBlocks { get; set; }
        public int QuarterbackKnockdowns { get; set; }
        public int SpecialTeamPlays { get; set; }
        public int OneHundredYardRushingGames { get; set; }
        public int OneHundredYardReceivingGames { get; set; }
        public int ThreeHundredYardPassingGames { get; set; }
        public int TenYardRuns { get; set; }
        public int TwentyYardCatches { get; set; }
        public int TwentyYardCompletions { get; set; }
        public int TotalYardsFromScrimmage { get; set; }
        public int AllPurposeYards { get; set; }
    }
}
