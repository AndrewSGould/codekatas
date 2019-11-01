using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SharpKatas.Pages.DataMunging
{
    public class DataMungingModel : PageModel
    {
        private const string MONTH_ROW = "mo";
        private const string WEATHER_DATA = @"C:\Git\codekatas\SharpKatas\Pages\DataMunging\weather.dat";
        private const string FOOTBALL_DATA = @"C:\Git\codekatas\SharpKatas\Pages\DataMunging\football.dat";

        public void OnGet()
        {

        }

        public DailySpread GetLowestTempSpread()
        {
            var spread = CalculateTempSpread();
            return spread.Where(x => x.TempSpread == spread.Min(x => x.TempSpread)).FirstOrDefault();
        }

        public TeamRecordSpread GetLowestScoreSpread()
        {
            var spread = CalculateFootballSpread();
            return spread.Where(x => x.GoalSpread == spread.Min(x => x.GoalSpread)).FirstOrDefault();
        }

        private List<DailySpread> CalculateTempSpread()
        {
            var weatherData = ParseWeatherData(WEATHER_DATA);
            return weatherData.Select(x => new DailySpread
            {
                Day = x.Day,
                TempSpread = x.MaxTemp - x.MinTemp
            }).ToList();
        }

        private List<TeamRecordSpread> CalculateFootballSpread()
        {
            var footballData = ParseFootballRecords(FOOTBALL_DATA);
            return footballData.Select(x => new TeamRecordSpread
            {
                Team = x.Name,
                GoalSpread = x.Record.GoalsScored - x.Record.GoalsAgainst
            }).ToList();
        }

        public List<DailyTemp> ParseWeatherData(string dataFilePath)
        {
            var weatherData = ReadFromDatFile(dataFilePath);

            var headerRow = weatherData.FirstOrDefault();

            var dayColumn = headerRow.IndexOf("Dy");
            var maxTempColumn = headerRow.IndexOf("MxT");
            var minTempColumn = headerRow.IndexOf("MnT");

            var weatherRecords = new List<DailyTemp>();

            foreach (var row in weatherData.Skip(1).Where(x => !x.Contains(MONTH_ROW) && x.Length != 0))
            {
                weatherRecords.Add(new DailyTemp
                {
                    Day = ParseValueFromString(row, dayColumn),
                    MaxTemp = ParseValueFromString(row, maxTempColumn),
                    MinTemp = ParseValueFromString(row, minTempColumn)
                });
            }

            return weatherRecords;
        }

        public List<Team> ParseFootballRecords(string dataFilePath)
        {
            var footballData = ReadFromDatFile(dataFilePath);

            var headerRow = footballData.FirstOrDefault();

            var teamColumn = headerRow.IndexOf("Team");
            var playersColumn = headerRow.IndexOf("P");
            var winsColumn = headerRow.IndexOf("W");
            var lossesColumn = headerRow.IndexOf("L") - 1;
            var drawsColumn = headerRow.IndexOf("D") - 1;
            var goalsScoredColumn = headerRow.IndexOf("F");
            var goalsAgainstColumn = headerRow.IndexOf("A");
            var leaguePointsColumn = headerRow.IndexOf("Pts");

            var footballRecords = new List<Team>();

            foreach (var row in footballData.Skip(1).Where(x => !x.Contains("------")))
            {
                footballRecords.Add(new Team
                {
                    Name = ParseValueFromString(row, teamColumn),
                    Players = ParseValueFromString(row, playersColumn),
                    Record = new Record
                    {
                        Wins = ParseValueFromString(row, winsColumn),
                        Losses = ParseValueFromString(row, lossesColumn),
                        Draws = ParseValueFromString(row, drawsColumn),
                        GoalsScored = ParseValueFromString(row, goalsScoredColumn),
                        GoalsAgainst = ParseValueFromString(row, goalsAgainstColumn),
                        LeaguePoints = ParseValueFromString(row, leaguePointsColumn)
                    }
                });
            }

            return footballRecords;
        }

        private dynamic ParseValueFromString(string input, int startingIndex)
        {
            string value;
            var endOfString = input.Substring(startingIndex).IndexOf(" ");

            if (!StartsWithSpace(input, startingIndex))
            {
                bool isEndOfRow = endOfString != -1;
                if (isEndOfRow)
                    value = input.Substring(startingIndex, endOfString);
                else
                    value = input.Substring(startingIndex, 2);
            }
            else
                value = input.Substring(startingIndex + 1, endOfString + 2);

            if (int.TryParse(value, out int number))
                return number;
            else
                return value;
        }

        private bool StartsWithSpace(string input, int startingIndex)
        {
            return input.Substring(startingIndex).IndexOf(" ") == 0;
        }

        private string[] ReadFromDatFile(string file)
        {
            var rawData = System.IO.File.ReadAllText(file);
            return rawData.Split("\n");
        }

        public class DailyTemp
        {
            public int Day { get; set; }
            public int MaxTemp { get; set; }
            public int MinTemp { get; set; }
        }

        public class DailySpread
        {
            public int Day { get; set; }
            public int TempSpread { get; set; }
        }

        public class Team
        {
            public string Name { get; set; }
            public int Players { get; set; }
            public Record Record { get; set; }
        }

        public class Record
        {
            public int Wins { get; set; }
            public int Losses { get; set; }
            public int Draws { get; set; }
            public int GoalsScored { get; set; }
            public int GoalsAgainst { get; set; }
            public int LeaguePoints { get; set; }
        }

        public class TeamRecord
        {
            public string Team { get; set; }
            public int Players { get; set; }
            public int Wins { get; set; }

            public int GoalsScored { get; set; }
            public int GoalsAgainst { get; set; }
            public int GoalSpread { get; set; }
        }

        public class TeamRecordSpread
        {
            public string Team { get; set; }
            public int GoalSpread { get; set; }
        }
    }
}
