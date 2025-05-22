using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Linq;
using System.Collections.Generic;
using BackupOrganizer;
using CustomDialogs;

namespace BackupOrganizerGUI {
    public partial class ItemExplorer : Form {
        public OrganizerApplication Application { get; set; }
        public GuiApplication GuiApplication { get; set; }

        public IView CurrentView => ViewControl.ViewController.CurrentView;
        public Group CurrentGroup => CurrentView.ViewNode.Node as Group;

        public ItemExplorerGridControl GridControl { get; set; }
        public DataGridView GridView {
            get => GridControl.DataGridView;
        }

        public ViewControl ViewControl { get; set; }

        public ItemExplorer(OrganizerApplication application, GuiApplication guiApplication) {
            InitializeComponent();

            Application = application;
            GuiApplication = guiApplication;

            ViewController viewController = new ViewController(new GroupViewNode(Application.RootResource.Root));
            GridControl = new ItemExplorerGridControl(viewController);

            ViewControl = new ViewControl() { 
                Dock = DockStyle.Fill,
                Margin = new Padding(0)
            };

            StandardVerticalViewControl viewControl = new StandardVerticalViewControl(ViewControl, GridControl);
            viewControl.HeaderToolBar.ViewController = viewController;
            viewControl.HeaderToolBar.NodeCreator = item => new GroupNode(item as Group);

            ViewControl.Initialize(viewController, viewControl);
            GlobalContainer.Controls.Add(ViewControl, 0, 0);

            GridView.ContextMenuStrip = MenuStrip;

            ViewControl.Updated += ViewUpdate;
            Application.RootResource.Root.OnUpdate += ContentUpdate;
        }

        private void ItemExplorer_Load(object sender, EventArgs e) {
            ViewControl.UpdateView();
        }

        private void ViewUpdate(object sender, EventArgs e) {
            AmountOfItemsLabel.Text = $"Items: {CurrentView.ViewNode.Items.Count}";
        }
        private void ContentUpdate(object sender, EventArgs e) {
            Application.RootResource.Save();
        }

        //Bottom buttons
        private void DeselectButton_Click(object sender, EventArgs e) {
            GridView.ClearSelection();
        }
        private void CloseButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void CreateSheetButton_Click(object sender, EventArgs e) {
            ItemUtilities.CreateSheet(Application);
        }
        private void ChangeKeyButton_Click(object sender, EventArgs e) {
            ItemUtilities.ChangeKey(Application);
        }

        private void MoveUpButton_Click(object sender, EventArgs e) {
            if (GridView.SelectedRows.Count != 1) return;

            int rowIndex = GridView.SelectedRows[0].Index;
            if (rowIndex < 1) return;

            Item item = GridView.SelectedRows[0].Tag as Item;
            CurrentGroup.SwapChildItems(item, GridView.Rows[rowIndex - 1].Tag as Item);
        }
        private void MoveDownButton_Click(object sender, EventArgs e) {
            if (GridView.SelectedRows.Count != 1) return;

            int rowIndex = GridView.SelectedRows[0].Index;
            if (rowIndex >= GridView.Rows.Count - 1) return;

            Item item = GridView.SelectedRows[0].Tag as Item;
            CurrentGroup.SwapChildItems(item, GridView.Rows[rowIndex + 1].Tag as Item);
        }

        //MenuStrip
        private void MenuStrip_Opening(object sender, CancelEventArgs e) {
            Item item = GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as Item;

            ChangePasswordMenuItem.Enabled = item != null && item.ID == ItemID.BackupFile;
            SetLinkMenuItem.Enabled = item != null && CurrentView.SelectedItems.Count == 1;
            SetPathInDriveMenuItem.Enabled = item != null && CurrentView.SelectedItems.Count == 1;

            CopyMenuItem.Enabled = item != null;
            PasteMenuItem.Enabled = GuiApplication.CopiedItems.Any();

            MoveMenuItem.Enabled = CurrentView.SelectedItems.Any();
            RenameMenuItem.Enabled = item != null && CurrentView.SelectedItems.Count == 1;
            DeleteMenuItem.Enabled = item != null && CurrentView.SelectedItems.Count > 0;
        }

        private void NewGroupMenuItem_Click(object sender, EventArgs e) {
            Group group = new Group() {
                Name = "New group"
            };
            ItemUtilities.SetNewPath(group, CurrentGroup);

            CurrentGroup.Items.Add(group);
            GridControl.SelectRow(group);

            ItemUtilities.EditItem(group);
        }
        private void NewBackupFileMenuItem_Click(object sender, EventArgs e) {
            BackupFile file = new BackupFile() {
                Name = "New backup file"
            };
            ItemUtilities.SetNewPath(file, CurrentGroup);

            CurrentGroup.Items.Add(file);
            GridControl.SelectRow(file);

            ItemUtilities.EditItem(file);
        }

        private void ChangePasswordMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.ChangePassword(GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as BackupFile);
        }
        private void SetLinkMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.SetLink(GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as Item);
        }
        private void SetPathInDriveMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.SetPath(GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as Item);
        }

        private void CopyMenuItem_Click(object sender, EventArgs e) {
            GuiApplication.CopiedItems = new List<Item>(CurrentView.SelectedItems.Cast<Item>().ToList());
        }
        private void PasteMenuItem_Click(object sender, EventArgs e) {
            Group parentGroup = CurrentGroup;

            Item item = GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as Item;
            if (item != null && item.ID == ItemID.Group) parentGroup = item as Group;

            foreach (var thisItem in GuiApplication.CopiedItems) {
                parentGroup.Items.Add(thisItem.Clone());
            }
        }

        private void MoveMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.Move(CurrentView.SelectedItems.Cast<Item>().ToList(), CurrentGroup);
        }
        private void RenameMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.EditItem(GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as Item);
        }
        private void DeleteMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.Delete(CurrentView.SelectedItems.Cast<Item>().ToList(), CurrentGroup);
        }
    }
}
