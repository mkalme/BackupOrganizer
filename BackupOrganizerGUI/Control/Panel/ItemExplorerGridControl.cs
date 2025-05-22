using System;
using System.Windows.Forms;
using BackupOrganizer;
using CustomDialogs;

namespace BackupOrganizerGUI {
    public class ItemExplorerGridControl : DataGridViewControl {
        public ViewController ViewController { get; set; }
        public DataGridViewVisualController GridViewController { get; set; }

        public ItemExplorerGridControl(ViewController viewController) {
            ViewController = viewController;
            GridViewController = new DataGridViewVisualController(ViewController);

            Initialize();
        }

        public override DataGridViewColumn[] CreateColumns() {
            return GridViewController.CreateColumns();
        }
        protected override bool SetRow(DataGridViewRow row, object item) {
            return GridViewController.SetRow(row, item);
        }
        protected override void GridDoubleClick(DataGridViewCellEventArgs e, object item) {
            Item thisItem = item as Item;

            if (thisItem.ID == ItemID.Group) {
                ViewController.OpenChild(thisItem as Group);
            } else {
                ItemUtilities.EditItem(thisItem);
            }
        }
    }
}
