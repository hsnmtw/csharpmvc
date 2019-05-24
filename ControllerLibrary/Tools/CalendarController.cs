using ControllerLibrary.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerLibrary.Tools {
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

        public DataTable GetMonthDays(int year,int month) {
            var table = new DataTable();
            foreach(var day in WeekDays) {
                table.Columns.Add(day);
            }
            var firstweekdayofmonth = WeekDaysValues[ new DateTime(year, month, 1).DayOfWeek ];
            var daysofthemonth = new DateTime(year, month, 1).AddMonths(1).AddDays(-1).Day;
            
            var week = new object[7];
            int d = 0;
            for (int i = 0 ; i < 50 ; i++) {
                
                if (i>=firstweekdayofmonth) week[i%7] = $"{++d}" ;
                if (d == daysofthemonth || i % 7 == 6) {
                    table.Rows.Add((object[])week.Clone());
                    if (d == daysofthemonth) break;
                    week = new object[7];
                }
            }
            return table;
        }
    }
}
