using System;
using System.Windows.Forms;
using BackupOrganizer;
using CustomDialogs;

namespace BackupOrganizerGUI {
    public class DataGridViewVisualController {
        public ViewController ViewController { get; set; }
        private DataGridViewColumn[] _columns;

        public DataGridViewVisualController(ViewController viewController) {
            ViewController = viewController;
        }

        public DataGridViewColumn[] CreateColumns() {
            _columns = new TextAndImageColumn[] {
                new TextAndImageColumn(){
                    HeaderText = "Name",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                    Width = 220
                },
                new TextAndImageColumn(){
                    HeaderText = "Path in drive",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                    AlignmentToRight = true
                }
            };

            return _columns;
        }

        //Update
        private ImageCache _imageCache = new ImageCache();

        public bool SetRow(DataGridViewRow row, object item) {
            Item thisitem = item as Item;
            row.SetValues(thisitem.Name, thisitem.PathInDrive);

            if (thisitem.ID == ItemID.Group) SetGroupRow(row);
            else SetFileItemRow(row, thisitem as BackupFile);

            return true;
        }

        private void SetGroupRow(DataGridViewRow row) {
            row.DisplayImage(_columns[0], _imageCache.GetImage("group_image", Properties.Resources._22pxLargeGroup, 22, 22), 27);
        }
        private void SetFileItemRow(DataGridViewRow row, BackupFile item) {
            ((TextAndImageCell)row.Cells[0]).XOffet = 3;
            row.DisplayImage(_columns[0], _imageCache.GetImage("file_image", Properties.Resources._16pxZipFile, 16, 16), 27);

            if (item.Password.Length > 0) {
                row.DisplayImage(_columns[1], Properties.Resources._16pxKey);
            }
        }
    }
}
