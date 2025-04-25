
namespace cpsyfinalprototype.Classes
{
    public static class DateUtils
    {
        public static bool TryParseDate(string dateString, out DateOnly date)
        {
            date = default;
            if (DateTime.TryParse(dateString, out DateTime dateTime))
            {
                date = DateOnly.FromDateTime(dateTime);
                return true;
            }
            return false;
        }
    }
}