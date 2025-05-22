using System;
using System.Windows.Forms;
using CustomDialogs;
using BackupOrganizer;

namespace BackupOrganizerGUI {
    static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            InputResult<byte[]> keyResult = CustomDialog.ShowKeyInput(KeyExtensions.KeyValidator);
            if (keyResult.DialogClosed) return;

            try {
                OrganizerApplication application = new OrganizerApplication(keyResult.Value);
                GuiApplication guiApplication = new GuiApplication();

                Application.Run(new ItemExplorer(application, guiApplication));
            } catch (Exception e) {
                CustomDialog.ShowError(e);
            }
        }
    }
}
