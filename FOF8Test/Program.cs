using FileHelpers;
using System;
using FOF8Test.DataModels;

namespace FOF8Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var enginePlayerSeasonRecord = new FileHelperEngine<PlayerSeasonRecord>();

            string fileName = "E:\\TestData\\player_season_2017.csv";
            var result = enginePlayerSeasonRecord.ReadFile(fileName);

            var enginePlayerInformationRecord = new FileHelperEngine<PlayerInformationRecord>();

            fileName = "E:\\TestData\\player_information.csv";
            var result2 = enginePlayerInformationRecord.ReadFile(fileName);

            var engineAwardRecord = new FileHelperEngine<AwardRecord>();

            fileName = "E:\\TestData\\awards.csv";
            var result3 = engineAwardRecord.ReadFile(fileName);

            var engineDraftPersonalRecord = new FileHelperEngine<DraftPersonalRecord>();
            var result4 = engineDraftPersonalRecord.ReadFile("E:\\TestData\\draft_personal.csv");

            var engineGameInformationRecord = new FileHelperEngine<GameInformationRecord>();
            var result5 = engineGameInformationRecord.ReadFile("E:\\TestData\\game_information.csv");

            var engineGameRecordsRecord = new FileHelperEngine<GameRecordsRecord>();
            var result6 = engineGameRecordsRecord.ReadFile("E:\\TestData\\game_records.csv");

            var enginePlayerSeasonRatingsRecord = new FileHelperEngine<PlayerSeasonRatingsRecord>();
            var result7 = enginePlayerSeasonRatingsRecord.ReadFile("E:\\TestData\\player_ratings_season_2017.csv");

            Console.WriteLine("Please press any key to continue...");
            Console.ReadLine();
        }
    }
}
