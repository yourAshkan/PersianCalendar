using System.Globalization;

namespace Train
{
    public static class Tools
    {
        public static string PersianDate(this DateTime date)
        {
            PersianCalendar pc = new PersianCalendar();
            var year = pc.GetYear(date);
            var month = pc.GetMonth(date);
            var day = pc.GetDayOfMonth(date);

            return $"{year}/{month}/{day}";
        }
    }
}
