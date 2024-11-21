
namespace TestBlazor.Infrastructure
{
    public static class StringExtensions
    {
        public static string FormatAsCounter(this string sourse)
        {
            if (sourse.Length != 4)
            {
                return sourse;
            }

            var second = sourse.Substring(0, 2);
            var milliseconds = sourse.Substring(2, 2);
            return second + ":" + milliseconds;
        }
    }
}
