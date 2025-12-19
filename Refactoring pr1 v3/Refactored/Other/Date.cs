namespace Refactoring.Other
{
    public class Date{
        public static string GetFormattedDate()
        {
            DateTime today = DateTime.Today;
            return today.ToString("yyyy-MM-dd");
        }
    }
}
