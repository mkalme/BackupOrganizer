using System;
using System.Windows.Forms;
using BackupOrganizer;
using CustomDialogs;

namespace BackupOrganizerGUI {
    public class ItemSelectionGridControl : IDataGridViewSelectionControl {
        public DataGridViewVisualController GridViewController { get; set; }

        public DataGridView DataGridView { get; set; }
        public ViewController ViewController { get; set; }
        public Func<object, bool> ViewableItemValidator { get; }

        public ItemSelectionGridControl(Func<object, bool> viewableItemValidator) {
            ViewableItemValidator = viewableItemValidator;

            GridViewController = new DataGridViewVisualController(ViewController);
        }

        public DataGridViewColumn[] CreateColumns() {
            return GridViewController.CreateColumns();
        }

        public void SetRow(DataGridViewRow row, object item) {
            GridViewController.SetRow(row, item);
        }
        public void GridDoubleClick(DataGridViewCellEventArgs e, object item) {
            ItemID id = ((Item)item).ID;

            if (id == ItemID.Group) {
                ViewController.OpenChild(item as Group);
            }
        }
    }
}
