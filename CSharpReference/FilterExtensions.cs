using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReference {
    public static class FilterExtensions {
        public static IEnumerable<string> StringsThatStartWith (this IEnumerable<string> instance, string start) {
            foreach (var str in instance) {
                if (str.StartsWith(start)) {
                    yield return str; // this builds IEnumerable
                }
            }
        }
    }
}
