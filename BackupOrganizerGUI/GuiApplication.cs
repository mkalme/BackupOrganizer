using System;
using System.Collections.Generic;
using BackupOrganizer;

namespace BackupOrganizerGUI {
    public class GuiApplication {
        public IEnumerable<Item> CopiedItems { get; set; } = new List<Item>();
    }
}
