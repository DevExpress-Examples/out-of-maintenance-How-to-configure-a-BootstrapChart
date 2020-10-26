using System;
using System.Linq;

namespace ChartApi {
    public class DataProvider {
        static readonly DateTime startDate = new DateTime(2020, 10, 01);
        public static object GetDataForArgNumeric() {
            var dataNumeric = Enumerable.Range(1, 9).Select(i => new {
                X = i,
                Y1 = i * 5,
                Y2 = i * 5 + 1
            }).ToList();

            //emulate empty point for certain series
            dataNumeric.Add(new { X = 10, Y1 = 50, Y2 = 0 });
            dataNumeric.Add(new { X = 11, Y1 = 0,  Y2 = 56 });

            dataNumeric.Add(new { X = 12, Y1 = 60, Y2 = 61 });
            return dataNumeric;
        }
        public static object GetDataForArgDate() {
            var dataDate = Enumerable.Range(0, 9).Select(i => new {
                X = startDate.AddDays(i),
                Y = i * 5
            }).ToList();

            return dataDate;
        }
        public static object GetDataForArgString() {
            var dataString = Enumerable.Range(1, 9).Select(i => new {
                X = i.ToString(),
                Y = (i * 5).ToString(),
            }).ToList();

            return dataString;
        }
    }
}