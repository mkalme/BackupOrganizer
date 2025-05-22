using System;
using System.Collections;

namespace BackupOrganizer {
    static class EnumerableExtensions {
        public static void ForEach<T>(this IList list, Action<T> action) {
            foreach (object value in list) {
                action((T)value);
            }
        }
    }
}
