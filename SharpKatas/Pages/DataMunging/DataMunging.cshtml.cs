using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SharpKatas.Pages.DataMunging
{
    public class DataMungingModel : PageModel
    {
        private const string MONTH_ROW = "mo";

        public void OnGet()
        {

        }

        public DailySpread GetLowestTempSpread()
        {
            var spread = CalculateTempSpread();
            return spread.Where(x => x.TempSpread == spread.Min(x => x.TempSpread)).FirstOrDefault();
        }

        private List<DailySpread> CalculateTempSpread()
        {
            var weatherData = ReadFromDatFile(@"C:\Git\codekatas\SharpKatas\Pages\DataMunging\weather.dat");
            return weatherData.Select(x => new DailySpread
            {
                Day = x.Day,
                TempSpread = x.MaxTemp - x.MinTemp
            }).ToList();
        }

        private List<DailyTemp> ReadFromDatFile(string file)
        {
            var fileData = System.IO.File.ReadAllText(file);
            
            var weatherRawData = fileData.Split("\n");
            var weatherData = new List<DailyTemp>();

            foreach(var data in weatherRawData.Skip(2))
            {
                var row = data.Split(" ").Where(x => !x.Equals("")).ToArray();

                if (row[0] == MONTH_ROW) break;

                SanitizeDatRow(row);

                weatherData.Add(new DailyTemp { 
                    Day = Convert.ToInt32(row[0]),
                    MaxTemp = Convert.ToInt32(row[1]),
                    MinTemp = Convert.ToInt32(row[2])
                });
            }

            return weatherData;
        }

        private void SanitizeDatRow(string[] row)
        {
            for (var i = 0; i < row.Length; i++)
            {
                if (row[i].Contains("*"))
                {
                    row[i] = row[i].Split("*")[0];
                }
            }
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
    }
}