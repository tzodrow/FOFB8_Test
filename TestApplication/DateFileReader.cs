using System.IO;

namespace TestApplication
{
    class DateFileReader
    {
        private static string SanatizeDataRow(string dataLine)
        {
            string[] dataElements = dataLine.Split(',');

            string dataRow = string.Empty;
            for (int i = 0; i < dataElements.Length; ++i)
            {
                string value = dataElements[i];
                dataRow += int.TryParse(value, out int ignore) ? value : string.Format("\"{0}\"", value);

                if (i < dataElements.Length - 1)
                {
                    dataRow += ",";
                }
            }

            return dataRow;
        }

        private void ReadDataFile()
        {
            using (FileStream stream = File.Open("E:\\TestData\\player_information.csv", FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    //// First Line will be the table headers
                    //string headerLine = reader.ReadLine();
                    //string line = reader.ReadLine();

                    //// If no data available, skip the table entry
                    //if (string.IsNullOrEmpty(line))
                    //{
                    //    return;
                    //}

                    //string[] tableHeaders = headerLine.Split(',');
                    //string[] dataRow = line.Split(',');

                    //if (tableHeaders.Length != dataRow.Length)
                    //{
                    //    throw new ArgumentException("Data file contains mismatched data. Please check CSV Files.");
                    //}

                    //string sqlCreateHeaders = "(";

                    //for (int i = 0; i < tableHeaders.Length; ++i)
                    //{
                    //    sqlCreateHeaders += SanatizeHeaderNames(tableHeaders[i]);
                    //    sqlCreateHeaders += int.TryParse(dataRow[i], out int ignore) ? " int" : " TEXT";

                    //    if (i < tableHeaders.Length - 1)
                    //    {
                    //        sqlCreateHeaders += ",";
                    //    }
                    //}

                    //sqlCreateHeaders += ")";

                    //using (SQLiteConnection sqlConnect = new SQLiteConnection(string.Format("Data Source={0};Version=3;", databaseFileName)))
                    //{
                    //    sqlConnect.Open();

                    //    string sqlTableHeaders = string.Format("create table {0} {1}", fileName, sqlCreateHeaders);
                    //    SQLiteCommand command = new SQLiteCommand(sqlTableHeaders, sqlConnect);
                    //    command.ExecuteNonQuery();

                    //    // First data line already read from analysis
                    //    do
                    //    {
                    //        string sqlInsert = string.Format("insert into {0} values ({1})", fileName, SanatizeDataRow(line));
                    //        command = new SQLiteCommand(sqlInsert, sqlConnect);
                    //        command.ExecuteNonQuery();
                    //    } while (!string.IsNullOrEmpty(line = reader.ReadLine()));
                    //}
                }
            }
        }
    }
}
