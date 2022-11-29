using System.Globalization;

namespace StudiesCSharp.Contents
{
    public class DatesExamples
    {
        public static void ReturnDatesExamples()
        {
            #region 01 - Inicializing with Dates
                
                DateTime date = new DateTime(); // get a DateTime struct instance
                Console.WriteLine(date); // output: 1/1/2001 12:00:00 AM

            #endregion
            
            #region 02 - Getting Date values

                var date2 = new DateTime(2022, 10, 12, 13, 23, 16);

                Console.WriteLine($"Data:          {date2}");                // Output:
                Console.WriteLine($"Year:          {date2.Year}");           // Output:
                Console.WriteLine($"Month:         {date2.Month}");          // Output:
                Console.WriteLine($"Day:           {date2.Day}");            // Output:
                Console.WriteLine($"Minute:        {date2.Minute}");         // Output:
                Console.WriteLine($"Second:        {date2.Second}");         // Output:
                Console.WriteLine($"Millisecond:   {date2.Millisecond}");    // Output:
                
                Console.WriteLine($"Day of Week:   {(int)date2.DayOfWeek}"); // Output:
                Console.WriteLine($"Day of Year:   {(int)date2.DayOfYear}"); // Output:

            #endregion

            #region 03 - Formating Dates
                
                var date3 = DateTime.Now;
                var format = String.Format("Format Date: {0: dd/MM/yyyy hh:mm:ss ff z}", date3);
                Console.WriteLine(format);

            #endregion

            #region 04 - Patterns of Formating Dates

                var format2 = String.Format("Date Short: {0: t}", date); // Output: 
                var format3 = String.Format("Date Short: {0: T}", date); // Output: 
                var format4 = String.Format("Date Short: {0: d}", date); // Output: 
                var format5 = String.Format("Date Short: {0: D}", date); // Output: 
                var format6 = String.Format("Date Short: {0: f}", date); // Output: 
                var format7 = String.Format("Date Short: {0: g}", date); // Output: 
                var format8 = String.Format("Date Short: {0: r}", date); // Output: 
                var format9 = String.Format("Date Short: {0: R}", date); // Output: 
                var format10 = String.Format("Date Short: {0: s}", date); // Output: 
                var format11 = String.Format("Date Short: {0: u}", date); // Output: 
                
            #endregion
            
            #region 05 - Add Values

                DateTime date5 = new DateTime();

                Console.WriteLine($"Add milliseconds: {date5.AddMilliseconds(1)}"); // Output: Add milliseconds: 1/1/0001 12:00:00 AM
                Console.WriteLine($"Add seconds:      {date5.AddSeconds(1)}");      // Output: Add seconds: 1/1/0001 12:00:01 AM
                Console.WriteLine($"Add minutes:      {date5.AddMinutes(1)}");      // Output: Add minutes: 1/1/0001 12:01:00 AM
                Console.WriteLine($"Add hours:        {date5.AddHours(1)}");        // Output: Add hours: 1/1/0001 1:00:00 AM
                Console.WriteLine($"Add days:         {date5.AddDays(1)}");         // Output: Add days: 1/2/0001 12:00:00 AM
                Console.WriteLine($"Add months:       {date5.AddMonths(1)}");       // Output: Add months: 2/1/0001 12:00:00 AM
                Console.WriteLine($"Add years:        {date5.AddYears(1)}");        // Output: Add years: 1/1/0002 12:00:00 AM
                Console.WriteLine($"Add ticks:        {date5.AddTicks(2)}");        // Output: Add ticks: 1/1/0001 12:00:00 AM

            #endregion

            #region 06 - Comparing Dates
                
                var date6 = DateTime.Now;

                if(date6 == DateTime.Now)
                    Console.WriteLine("Is equal"); // False, because date6 have milliseconds diference than DateTime.Now
                
                if(date6.Date == DateTime.Now.Date)
                    Console.WriteLine("Is equal"); // True

            #endregion
            
            #region 07 - CultureInfo
                
                var pt = new CultureInfo("pt-PT");
                var br = new CultureInfo("pt-BR");
                var us = new CultureInfo("en-US");
                var de = new CultureInfo("de-DE");
                var uk = new CultureInfo("en-Uk");
                var current = CultureInfo.CurrentCulture;

                Console.WriteLine(DateTime.Now.ToString("D", br));

            #endregion

            #region 08 - Timezone
                
                var utcTime = DateTime.UtcNow;

                Console.WriteLine(DateTime.Now);
                Console.WriteLine(utcTime);

                Console.WriteLine(utcTime.ToLocalTime());

                var timezoneAustralia = 
                TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
                Console.WriteLine(timezoneAustralia);

                var hourAustralia = 
                TimeZoneInfo.ConvertTimeFromUtc(utcTime, timezoneAustralia);
                Console.WriteLine(hourAustralia);

                var timezones = TimeZoneInfo.GetSystemTimeZones();
                foreach(var timezone in timezones)
                {
                    Console.WriteLine(timezone.Id);
                    Console.WriteLine(timezone);
                    Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcTime, timezone));
                    Console.WriteLine("===================================");
                }

            #endregion
           
            #region 09 - Timespan

                var timespan = new TimeSpan();
                Console.WriteLine(timespan);

                var timespanMilliseconds = new TimeSpan(1);
                Console.WriteLine(timespanMilliseconds);

                var timespanHourMinuteSecond = new TimeSpan(5, 12, 8);
                Console.WriteLine(timespanHourMinuteSecond);

                Console.WriteLine(timespanHourMinuteSecond - timespanMilliseconds);
                Console.WriteLine(timespanHourMinuteSecond.Seconds);
                Console.WriteLine(timespanHourMinuteSecond.Minutes);
                Console.WriteLine(timespanHourMinuteSecond.Hours);
                Console.WriteLine(timespanHourMinuteSecond.Days);
                Console.WriteLine(timespanHourMinuteSecond.Add(new TimeSpan(12, 0, 0)));

            #endregion
        }
    }
}