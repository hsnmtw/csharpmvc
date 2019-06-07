using MVCHIS.Common;
using System;
using System.Collections.Generic;
using System.Data;

namespace MVCHIS.Tools {
    public class CalendarController : IController {

        public static readonly string[] WeekDays = {
            "Sun",
            "Mon",
            "Tue",
            "Wed",
            "Thu",
            "Fri",
            "Sat",
        };
        public static readonly Dictionary<DayOfWeek, int> WeekDaysValues = new Dictionary<DayOfWeek, int> {
            [DayOfWeek.Sunday   ] = 0,
            [DayOfWeek.Monday   ] = 1,
            [DayOfWeek.Tuesday  ] = 2,
            [DayOfWeek.Wednesday] = 3,
            [DayOfWeek.Thursday ] = 4,
            [DayOfWeek.Friday   ] = 5,
            [DayOfWeek.Saturday ] = 6,
        };

        public Action<int> OnSaveAction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Action<int> OnDeleteAction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DataTable GetMonthDays(int year, int month) {
            DataTable table = new DataTable();
            var calendar = GetMonthCalendar(year, month);
            for(int c=0;c<7;c++)table.Columns.Add(WeekDays[c]);
            for(int i=0;i<6;i++)table.Rows.Add(calendar[i]);
            return table;
        }

        public object[][] GetMonthCalendar(int year, int month) {
            object[][] calendar = new object[6][];
            for(int i=0;i<6;i++) calendar[i]=new object[7];
            var firstweekdayofmonth = WeekDaysValues[ new DateTime(year, month, 1).DayOfWeek ];
            var daysofthemonth = new DateTime(year, month, 1).AddMonths(1).AddDays(-1).Day;
            
            int d = 0;
            int w = 0;
            
            for (int i = 0 ; i < 50 ; i++) {
                if (i>=firstweekdayofmonth) calendar[w][i%7] = ++d ;
                if (d == daysofthemonth || i % 7 == 6) {
                    w++;
                    if (d == daysofthemonth) break;
                }
            }
            return calendar;
        }

        public MetaData GetMetaData() {
            throw new NotImplementedException();
        }

        public DataTable GetData() {
            throw new NotImplementedException();
        }

        public Type GetModelType() {
            throw new NotImplementedException();
        }

        public string GetValues(int id) {
            throw new NotImplementedException();
        }

        public Dictionary<int,string> GetKeysAndValues() {
            throw new NotImplementedException();
        }
    }
}
