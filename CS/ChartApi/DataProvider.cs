using System;
using System.Linq;

namespace ChartApi {
    public class NumericDataPoint {
        public int X { get; set; }
        public int? Y1 { get; set; }
        public int? Y2 { get; set; }
    }
    public class DataProvider {
        static readonly DateTime startDate = new DateTime(2020, 10, 01);
        public static object GetDataForArgNumeric() {
            var dataNumeric = Enumerable.Range(1, 9).Select(i => new NumericDataPoint {
                X = i,
                Y1 = i * 5,
                Y2 = i * 5 + 1
            }).ToList();

            //emulate empty point for certain series
            dataNumeric.Add(new NumericDataPoint { X = 10, Y1 = 50, Y2 = null });
            dataNumeric.Add(new NumericDataPoint { X = 11, Y1 = null,  Y2 = 56 });

            dataNumeric.Add(new NumericDataPoint { X = 12, Y1 = 60, Y2 = 61 });
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