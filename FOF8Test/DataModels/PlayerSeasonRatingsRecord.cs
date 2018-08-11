using FileHelpers;

namespace FOF8Test.DataModels
{
    [IgnoreFirst(1)]
    [DelimitedRecord(",")]
    class PlayerSeasonRatingsRecord
    {
        public int RecordNumber { get; set; }
        public int Year { get; set; }
        public int PlayerId { get; set; }
        public string Scouting { get; set; }
        public int ScreenPasses { get; set; }
        public int ShortPasses { get; set; }
        public int MediumPasses { get; set; }
        public int LongPasses { get; set; }
        public int DeepPasses { get; set; }
        public int ThirdDownPasses { get; set; }
        public int RunFrequency { get; set; }
        public int Future1 { get; set; }
        public int Accuracy { get; set; }
        public int Timing { get; set; }
        public int SenseRush { get; set; }
        public int ReadDefense { get; set; }
        public int TwoMinuteOffense { get; set; }
        public int Future2 { get; set; }
        public int Future3 { get; set; }
        public int Future4 { get; set; }
        public int Future5 { get; set; }
        public int Future6 { get; set; }
        public int Speed { get; set; }
        public int PowerInside { get; set; }
        public int ThirdDownRuns { get; set; }
        public int HoleRecognition { get; set; }
        public int Elusiveness { get; set; }
        public int SpeedOutside { get; set; }
        public int BlitzPickup { get; set; }
        public int AvoidDrops { get; set; }
        public int GetDownfield { get; set; }
        public int RouteRunning { get; set; }
        public int ThirdDownReceiving { get; set; }
        public int BigPlayReceiving { get; set; }
        public int Courage { get; set; }
        public int AdjustToBall { get; set; }
        public int PuntReturns { get; set; }
        public int KickReturns { get; set; }
        public int Future7 { get; set; }
        public int RunBlocking { get; set; }
        public int PassBlocking { get; set; }
        public int BlockStrength { get; set; }
        public int PuntingPower { get; set; }
        public int HangTime { get; set; }
        public int DirectionalPunting { get; set; }
        public int KickoffDistance { get; set; }
        public int KickoffHangTime { get; set; }
        public int KickingAccuracy { get; set; }
        public int KickingPower { get; set; }
        public int RunDefense { get; set; }
        public int PassRushTechnique { get; set; }
        public int ManToManDefense { get; set; }
        public int ZoneDefense { get; set; }
        public int BumpAndRunDefense { get; set; }
        public int PassRushStrength { get; set; }
        public int PlayDiagnosis { get; set; }
        public int PunishingHitter { get; set; }
        public int Intercepting { get; set; }
        public int Endurance { get; set; }
        public int SpecialTeams { get; set; }
        public int LongSnapping { get; set; }
        public int KickHolding { get; set; }
        public int CurrentOverall { get; set; }
        public int FutureOverall { get; set; }
    }
}
