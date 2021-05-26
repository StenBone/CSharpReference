using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReference {
    public static class DateUtilities {
        /// <summary>
        /// Extenstion method to DateTime class
        /// </summary>
        /// <param name="inDate"></param>
        /// <returns></returns>
        public static bool IsChristmas(this DateTime inDate) {
            return inDate.Day == 25 && inDate.Month == 12;
        }
    }
}
