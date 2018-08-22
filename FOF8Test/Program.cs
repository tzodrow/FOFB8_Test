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

            string fileName = "DataFiles\\player_season_2017.csv";
            var result = enginePlayerSeasonRecord.ReadFile(fileName);

            var enginePlayerInformationRecord = new FileHelperEngine<PlayerInformationRecord>();

            fileName = "DataFiles\\player_information.csv";
            var result2 = enginePlayerInformationRecord.ReadFile(fileName);

            var engineAwardRecord = new FileHelperEngine<AwardRecord>();

            fileName = "DataFiles\\awards.csv";
            var result3 = engineAwardRecord.ReadFile(fileName);

            var engineDraftPersonalRecord = new FileHelperEngine<DraftPersonalRecord>();
            var result4 = engineDraftPersonalRecord.ReadFile("DataFiles\\draft_personal.csv");

            var engineGameInformationRecord = new FileHelperEngine<GameInformationRecord>();
            var result5 = engineGameInformationRecord.ReadFile("DataFiles\\game_information.csv");

            var engineGameRecordsRecord = new FileHelperEngine<GameRecordsRecord>();
            var result6 = engineGameRecordsRecord.ReadFile("DataFiles\\game_records.csv");

            var enginePlayerSeasonRatingsRecord = new FileHelperEngine<PlayerRatingsSeasonRecord>();
            var result7 = enginePlayerSeasonRatingsRecord.ReadFile("DataFiles\\player_ratings_season_2017.csv");

            var enginePlayerRecord = new FileHelperEngine<PlayerRecord>();
            var result8 = enginePlayerRecord.ReadFile("DataFiles\\player_record.csv");

            Console.WriteLine("Please press any key to continue...");
            Console.ReadLine();
        }
    }
}
