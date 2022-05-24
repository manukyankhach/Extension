using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionExamples
{
    public static class Extentions
    {
        public static string GetFirstAndLastLatters(this string source)
        {
            var input = source._IsNullOrEmpty();
            string result = string.Empty;
            if (!input)
            {
                var firstLatter = source[0];
                var lastLatter = source[source.Length - 1];
                result = firstLatter + " " + lastLatter;
            }
            else
                result = "String is Null Or Empty";

            return result;
        }

        public static bool _IsNullOrEmpty(this string source)
        {
            bool result = default(bool);
            if (source != null && source.Contains(source))
                return result;
            else
                result = false;
            return result;
        }

        public static bool _IsNullOrEmptyList<T>(this IEnumerable<T> source)
        {
            bool result = default(bool);
            if (source != null && source.Count() > 0)
                return result = true;

            return result;
        }

        public static T GetBetweenListParameter<T>(this IEnumerable<T> source)
        {
            var result = default(T);
            var check = source._IsNullOrEmptyList();
            if (check)
            {
                var hasBetween = (source.Count() - 1) % 2;
                if (hasBetween == 0)
                {
                    var betweenindex = (source.Count() - 1) / 2;
                    return result = source.ToList()[betweenindex];
                }
                else
                    return result;
            }
            else
                return result;
        }

        public static bool GetOddElementsSum<T>(this IEnumerable<T> source, out int sum)
        {
            sum = 0;
            var check = source._IsNullOrEmptyList();
            if (check)
            {
                foreach (var element in source)
                {
                    if (Convert.ToInt32(element) % 2 != 0)
                    {
                        sum += Convert.ToInt32(element);
                        check = true;
                    }
                }
            }
            return check;
        }
    }
}
