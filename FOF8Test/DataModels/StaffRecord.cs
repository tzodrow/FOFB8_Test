using FileHelpers;
using FOF8Test.DataEnums;

namespace FOF8Test.DataModels
{
    [IgnoreFirst(1)]
    [DelimitedRecord(",")]
    class StaffRecord
    {
        public int StaffId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Team CurrentTeam { get; set; }
        public string Role { get; set; }
        public string PrimaryGroup { get; set; }
        public int Salary { get; set; }
        public int PlayerDevelopment { get; set; }
        public int YoungPlayerDevelopment { get; set; }
        public int Motivation { get; set; }
        public int Discipline { get; set; }
        public int PlayCalling { get; set; }
        public int StrengthTraining { get; set; }
        public int Conditioning { get; set; }
        public int OffensiveStyle { get; set; }
        public int OffensivePlays { get; set; }
        public int DefensiveFront { get; set; }
        public int Scouting { get; set; }
        public int Interviewing { get; set; }
        public int Age { get; set; }
        public bool Retired { get; set; }
        public int YearsOnContract { get; set; }
        public int SuitableHeadCoach { get; set; }
        public int SuitableOffensiveCoordinator { get; set; }
        public int SuitableDefensiveCoordinator { get; set; }
        public int SuitableAssistantHeadCoach { get; set; }
        public int SuitableStrengthCoordinator { get; set; }
    }
}
