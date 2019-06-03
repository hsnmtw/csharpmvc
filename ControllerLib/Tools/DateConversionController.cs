using MVCHIS.Common;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace MVCHIS.Tools {
    //[ForModel(MODELS.DateConversion, Enabled = true)]
    public class DateConversionController : AbstractDBController<DateConversionModel> {

        public int Delete(DateConversionModel dateConversionModel, string[] whereFields) {
            int i=0;
            foreach (var model in Read(dateConversionModel, whereFields)) {
                i+=Delete(model);
            }
            return i;
        }

        public static DateTime ToSystemHijri(DateTime gregorianDate) {

            CultureInfo current = Thread.CurrentThread.CurrentCulture;

            CultureInfo arSA = CultureInfo.CreateSpecificCulture("ar-SA");

            // Change the current culture to Arabic (Saudi Arabia).
            Thread.CurrentThread.CurrentCulture = arSA;
            arSA.DateTimeFormat.Calendar = new UmAlQuraCalendar();
            
            string[] dt = gregorianDate.ToString("yyyy-MM-dd").Split('-');
            int y = int.Parse(dt[0]);
            int m = int.Parse(dt[1]);
            int d = int.Parse(dt[2]);
            DateTime result = new DateTime(y,m,d);
            Thread.CurrentThread.CurrentCulture = current;
            return result;
        }

        public IEnumerable<DateConversionModel> GetYearDates(int year, SupportedCalendar calendar) {
            if (calendar == SupportedCalendar.GREGORIAN) {
                var data = Read(new DateConversionModel() { GregorianYear = year }, "GregorianYear");
                if (data.Count() < 12 || data.Count()>12) {
                    Delete(year, calendar);
                    foreach(DateConversionModel model in CalculateDatesForGregorianYear(year)) { Save(model); }
                    data = Read(new DateConversionModel() { GregorianYear = year }, "GregorianYear");
                }
                return data;
            } else if (calendar == SupportedCalendar.HIJRI) {
                var data = Read(new DateConversionModel() { HijriYear = year }, "HijriYear");
                if (data.Count() < 11 || data.Count()>12) {
                    Delete(year, calendar);
                    foreach (DateConversionModel model in CalculateDatesForHijriYear(year)) { Save(model); }
                    data = Read(new DateConversionModel() { HijriYear = year }, "HijriYear");
                }
                return data;
            }
            return null;
        }

        public int Delete(int y, SupportedCalendar calendar) {
            
            int r = 0;
            if (calendar == SupportedCalendar.HIJRI) {

                r += Delete(new DateConversionModel() {
                    HijriYear = y
                }, new string[] { "HijriYear" });
                
            } else if(calendar == SupportedCalendar.GREGORIAN){

                for (int m = 1; m <= 12; m++) {
                    r += Delete(new DateConversionModel() {
                        GregorianDate = new DateTime(y, m, 1)
                    }, new string[] { "GregorianDate" });
                }

            }
            return r;
        }

        public static DateTime ToSystemGregorian(DateTime hijriDate) {
            int yp = hijriDate.Year;
            int mp = hijriDate.Month;
            int dp = hijriDate.Day;

            CultureInfo current = Thread.CurrentThread.CurrentCulture;

            CultureInfo arSA = CultureInfo.CreateSpecificCulture("ar-SA");

            // Change the current culture to Arabic (Saudi Arabia).
            Thread.CurrentThread.CurrentCulture = arSA;
            arSA.DateTimeFormat.Calendar = new UmAlQuraCalendar();


            string[] dt = new DateTime(yp,mp,dp,arSA.DateTimeFormat.Calendar).ToString("yyyy-MM-dd", CultureInfo.InvariantCulture).Split('-');
            int y = int.Parse(dt[0]);
            int m = int.Parse(dt[1]);
            int d = int.Parse(dt[2]);
            DateTime result = new DateTime(y, m, d);
            Thread.CurrentThread.CurrentCulture = current;
            return result;
        }
        public static IEnumerable<DateConversionModel> CalculateDatesStartingFromDate(DateTime startdate,int months) {
            DateTime date = new DateTime(startdate.Year, startdate.Month, startdate.Day);
            DateConversionModel[] dates = new DateConversionModel[months];
            for (int m = 0; m < months; m++) {
                DateTime hdate = ToSystemHijri(date);
                dates[m] = new DateConversionModel() {
                    GregorianDate = date,
                    GregorianYear = date.Year,
                    HijriYear = hdate.Year,
                    HijriMonth = hdate.Month,
                    HijriDay = hdate.Day
                };
                date = date.AddMonths(1);
            }
            return dates;
        }
        public static IEnumerable<DateConversionModel> CalculateDatesForGregorianYear(int year) {
            return CalculateDatesStartingFromDate(new DateTime(year,1,1),12);
        }
        public static IEnumerable<DateConversionModel> CalculateDatesForHijriYear(int year) {
            DateTime hd = ToSystemGregorian(new DateTime(year,1,1));
            DateTime date = new DateTime(hd.Year,hd.Month,1);
            return         CalculateDatesStartingFromDate(date.AddMonths(-3),3)
                   .Concat(CalculateDatesStartingFromDate(date, 12))
                   .Concat(CalculateDatesStartingFromDate(date.AddMonths(12), 3))
                   .Where(x => x.HijriYear==year)
                   .Take(12)
                   .OrderBy(x => x.GregorianDate)
                   ;
        }

    }
}
