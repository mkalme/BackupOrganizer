using System;
using System.Linq;

namespace BackupOrganizerGUI {
    public static class StorageExtensions {
        public static bool IsValidPath(this string path) {
            if (path.Length > 0 && path[0] == '\\') return false;
            return !path.Where((c, i) => i > 0 && c == '\\' && path[i - 1] == '\\').Any();
        }
    }
}
