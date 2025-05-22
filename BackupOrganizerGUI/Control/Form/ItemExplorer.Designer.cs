
namespace BackupOrganizerGUI {
    partial class ItemExplorer {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemExplorer));
            this.GlobalContainer = new System.Windows.Forms.TableLayoutPanel();
            this.BottomContainer = new System.Windows.Forms.TableLayoutPanel();
            this.CloseSeperatorLabel = new CustomDialogs.DarkLabel();
            this.ChangeKeyButton = new System.Windows.Forms.Button();
            this.CreateSheetButton = new System.Windows.Forms.Button();
            this.DeselectButton = new System.Windows.Forms.Button();
            this.InformationSeperator = new CustomDialogs.DarkLabel();
            this.MoveDownButton = new System.Windows.Forms.Button();
            this.MoveUpButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.AmountOfItemsLabel = new System.Windows.Forms.Label();
            this.MenuStrip = new CustomDialogs.DarkContextMenuStrip(this.components);
            this.NewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGroupMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewBackupFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.ChangePasswordMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetLinkMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetPathInDriveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetPathInDriveSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.CopyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.MoveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GlobalContainer.SuspendLayout();
            this.BottomContainer.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // GlobalContainer
            // 
            this.GlobalContainer.ColumnCount = 1;
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.Controls.Add(this.BottomContainer, 0, 1);
            this.GlobalContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobalContainer.Location = new System.Drawing.Point(0, 0);
            this.GlobalContainer.Margin = new System.Windows.Forms.Padding(0);
            this.GlobalContainer.Name = "GlobalContainer";
            this.GlobalContainer.Padding = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.GlobalContainer.RowCount = 1;
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GlobalContainer.Size = new System.Drawing.Size(800, 450);
            this.GlobalContainer.TabIndex = 2;
            // 
            // BottomContainer
            // 
            this.BottomContainer.AutoSize = true;
            this.BottomContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BottomContainer.ColumnCount = 9;
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.Controls.Add(this.CloseSeperatorLabel, 6, 0);
            this.BottomContainer.Controls.Add(this.ChangeKeyButton, 5, 0);
            this.BottomContainer.Controls.Add(this.CreateSheetButton, 4, 0);
            this.BottomContainer.Controls.Add(this.DeselectButton, 7, 0);
            this.BottomContainer.Controls.Add(this.InformationSeperator, 3, 0);
            this.BottomContainer.Controls.Add(this.MoveDownButton, 2, 0);
            this.BottomContainer.Controls.Add(this.MoveUpButton, 1, 0);
            this.BottomContainer.Controls.Add(this.CloseButton, 8, 0);
            this.BottomContainer.Controls.Add(this.AmountOfItemsLabel, 0, 0);
            this.BottomContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomContainer.Location = new System.Drawing.Point(7, 425);
            this.BottomContainer.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.BottomContainer.Name = "BottomContainer";
            this.BottomContainer.RowCount = 1;
            this.BottomContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BottomContainer.Size = new System.Drawing.Size(786, 23);
            this.BottomContainer.TabIndex = 3;
            // 
            // CloseSeperatorLabel
            // 
            this.CloseSeperatorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CloseSeperatorLabel.AutoSize = true;
            this.CloseSeperatorLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.CloseSeperatorLabel.Location = new System.Drawing.Point(674, 3);
            this.CloseSeperatorLabel.Margin = new System.Windows.Forms.Padding(9, 0, 7, 1);
            this.CloseSeperatorLabel.Name = "CloseSeperatorLabel";
            this.CloseSeperatorLabel.Size = new System.Drawing.Size(10, 15);
            this.CloseSeperatorLabel.TabIndex = 8;
            this.CloseSeperatorLabel.Text = "|";
            // 
            // ChangeKeyButton
            // 
            this.ChangeKeyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ChangeKeyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeKeyButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeKeyButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ChangeKeyButton.Image = global::BackupOrganizerGUI.Properties.Resources._16pxKey;
            this.ChangeKeyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChangeKeyButton.Location = new System.Drawing.Point(567, 0);
            this.ChangeKeyButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChangeKeyButton.Name = "ChangeKeyButton";
            this.ChangeKeyButton.Size = new System.Drawing.Size(98, 23);
            this.ChangeKeyButton.TabIndex = 9;
            this.ChangeKeyButton.Text = "Change key";
            this.ChangeKeyButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangeKeyButton.UseVisualStyleBackColor = true;
            this.ChangeKeyButton.Click += new System.EventHandler(this.ChangeKeyButton_Click);
            // 
            // CreateSheetButton
            // 
            this.CreateSheetButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CreateSheetButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CreateSheetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateSheetButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateSheetButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CreateSheetButton.Image = global::BackupOrganizerGUI.Properties.Resources._16pxExportToExcel;
            this.CreateSheetButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CreateSheetButton.Location = new System.Drawing.Point(460, 0);
            this.CreateSheetButton.Margin = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.CreateSheetButton.Name = "CreateSheetButton";
            this.CreateSheetButton.Size = new System.Drawing.Size(100, 23);
            this.CreateSheetButton.TabIndex = 10;
            this.CreateSheetButton.Text = "Create sheet";
            this.CreateSheetButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateSheetButton.UseVisualStyleBackColor = false;
            this.CreateSheetButton.Click += new System.EventHandler(this.CreateSheetButton_Click);
            // 
            // DeselectButton
            // 
            this.DeselectButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DeselectButton.BackgroundImage = global::BackupOrganizerGUI.Properties.Resources._16pxDeselect;
            this.DeselectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeselectButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.DeselectButton.FlatAppearance.BorderSize = 0;
            this.DeselectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeselectButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeselectButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DeselectButton.Location = new System.Drawing.Point(691, 0);
            this.DeselectButton.Margin = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.DeselectButton.Name = "DeselectButton";
            this.DeselectButton.Size = new System.Drawing.Size(23, 23);
            this.DeselectButton.TabIndex = 11;
            this.DeselectButton.UseVisualStyleBackColor = false;
            this.DeselectButton.Click += new System.EventHandler(this.DeselectButton_Click);
            // 
            // InformationSeperator
            // 
            this.InformationSeperator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InformationSeperator.AutoSize = true;
            this.InformationSeperator.ForeColor = System.Drawing.Color.DarkGray;
            this.InformationSeperator.Location = new System.Drawing.Point(442, 3);
            this.InformationSeperator.Margin = new System.Windows.Forms.Padding(9, 0, 8, 1);
            this.InformationSeperator.Name = "InformationSeperator";
            this.InformationSeperator.Size = new System.Drawing.Size(10, 15);
            this.InformationSeperator.TabIndex = 12;
            this.InformationSeperator.Text = "|";
            // 
            // MoveDownButton
            // 
            this.MoveDownButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MoveDownButton.BackgroundImage = global::BackupOrganizerGUI.Properties.Resources._16pxMoveDown;
            this.MoveDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MoveDownButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.MoveDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveDownButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MoveDownButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MoveDownButton.Location = new System.Drawing.Point(410, 0);
            this.MoveDownButton.Margin = new System.Windows.Forms.Padding(0);
            this.MoveDownButton.Name = "MoveDownButton";
            this.MoveDownButton.Size = new System.Drawing.Size(23, 23);
            this.MoveDownButton.TabIndex = 13;
            this.MoveDownButton.UseVisualStyleBackColor = false;
            this.MoveDownButton.Click += new System.EventHandler(this.MoveDownButton_Click);
            // 
            // MoveUpButton
            // 
            this.MoveUpButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MoveUpButton.BackgroundImage = global::BackupOrganizerGUI.Properties.Resources._16pxMoveUp;
            this.MoveUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MoveUpButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.MoveUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveUpButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MoveUpButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MoveUpButton.Location = new System.Drawing.Point(380, 0);
            this.MoveUpButton.Margin = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.MoveUpButton.Name = "MoveUpButton";
            this.MoveUpButton.Size = new System.Drawing.Size(23, 23);
            this.MoveUpButton.TabIndex = 14;
            this.MoveUpButton.UseVisualStyleBackColor = false;
            this.MoveUpButton.Click += new System.EventHandler(this.MoveUpButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CloseButton.Location = new System.Drawing.Point(721, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(65, 23);
            this.CloseButton.TabIndex = 15;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AmountOfItemsLabel
            // 
            this.AmountOfItemsLabel.AutoSize = true;
            this.AmountOfItemsLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AmountOfItemsLabel.Location = new System.Drawing.Point(0, 4);
            this.AmountOfItemsLabel.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.AmountOfItemsLabel.Name = "AmountOfItemsLabel";
            this.AmountOfItemsLabel.Size = new System.Drawing.Size(39, 15);
            this.AmountOfItemsLabel.TabIndex = 16;
            this.AmountOfItemsLabel.Text = "Items:";
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MenuStrip.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMenuItem,
            this.NewSeperator,
            this.ChangePasswordMenuItem,
            this.SetLinkMenuItem,
            this.SetPathInDriveMenuItem,
            this.SetPathInDriveSeperator,
            this.CopyMenuItem,
            this.PasteMenuItem,
            this.PasteSeperator,
            this.MoveMenuItem,
            this.RenameMenuItem,
            this.DeleteMenuItem});
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(169, 220);
            this.MenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.MenuStrip_Opening);
            // 
            // NewMenuItem
            // 
            this.NewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGroupMenuItem,
            this.NewBackupFileMenuItem});
            this.NewMenuItem.Image = global::BackupOrganizerGUI.Properties.Resources._16pxAdd;
            this.NewMenuItem.Name = "NewMenuItem";
            this.NewMenuItem.Size = new System.Drawing.Size(168, 22);
            this.NewMenuItem.Text = "New   ";
            // 
            // NewGroupMenuItem
            // 
            this.NewGroupMenuItem.Image = global::BackupOrganizerGUI.Properties.Resources._22pxLargeGroup;
            this.NewGroupMenuItem.Name = "NewGroupMenuItem";
            this.NewGroupMenuItem.Size = new System.Drawing.Size(167, 22);
            this.NewGroupMenuItem.Text = "Group                    ";
            this.NewGroupMenuItem.Click += new System.EventHandler(this.NewGroupMenuItem_Click);
            // 
            // NewBackupFileMenuItem
            // 
            this.NewBackupFileMenuItem.Image = global::BackupOrganizerGUI.Properties.Resources._16pxZipFile;
            this.NewBackupFileMenuItem.Name = "NewBackupFileMenuItem";
            this.NewBackupFileMenuItem.Size = new System.Drawing.Size(167, 22);
            this.NewBackupFileMenuItem.Text = "Backup file";
            this.NewBackupFileMenuItem.Click += new System.EventHandler(this.NewBackupFileMenuItem_Click);
            // 
            // NewSeperator
            // 
            this.NewSeperator.Name = "NewSeperator";
            this.NewSeperator.Size = new System.Drawing.Size(165, 6);
            // 
            // ChangePasswordMenuItem
            // 
            this.ChangePasswordMenuItem.Image = global::BackupOrganizerGUI.Properties.Resources._16pxPasswordStrength;
            this.ChangePasswordMenuItem.Name = "ChangePasswordMenuItem";
            this.ChangePasswordMenuItem.Size = new System.Drawing.Size(168, 22);
            this.ChangePasswordMenuItem.Text = "Change password";
            this.ChangePasswordMenuItem.Click += new System.EventHandler(this.ChangePasswordMenuItem_Click);
            // 
            // SetLinkMenuItem
            // 
            this.SetLinkMenuItem.Image = global::BackupOrganizerGUI.Properties.Resources._16pxLink;
            this.SetLinkMenuItem.Name = "SetLinkMenuItem";
            this.SetLinkMenuItem.Size = new System.Drawing.Size(168, 22);
            this.SetLinkMenuItem.Text = "Set link";
            this.SetLinkMenuItem.Click += new System.EventHandler(this.SetLinkMenuItem_Click);
            // 
            // SetPathInDriveMenuItem
            // 
            this.SetPathInDriveMenuItem.Image = global::BackupOrganizerGUI.Properties.Resources._16pxTreeView;
            this.SetPathInDriveMenuItem.Name = "SetPathInDriveMenuItem";
            this.SetPathInDriveMenuItem.Size = new System.Drawing.Size(168, 22);
            this.SetPathInDriveMenuItem.Text = "Set path in drive";
            this.SetPathInDriveMenuItem.Click += new System.EventHandler(this.SetPathInDriveMenuItem_Click);
            // 
            // SetPathInDriveSeperator
            // 
            this.SetPathInDriveSeperator.Name = "SetPathInDriveSeperator";
            this.SetPathInDriveSeperator.Size = new System.Drawing.Size(165, 6);
            // 
            // CopyMenuItem
            // 
            this.CopyMenuItem.Image = global::BackupOrganizerGUI.Properties.Resources._16pxCopyItem;
            this.CopyMenuItem.Name = "CopyMenuItem";
            this.CopyMenuItem.Size = new System.Drawing.Size(168, 22);
            this.CopyMenuItem.Text = "Copy";
            this.CopyMenuItem.Click += new System.EventHandler(this.CopyMenuItem_Click);
            // 
            // PasteMenuItem
            // 
            this.PasteMenuItem.Image = global::BackupOrganizerGUI.Properties.Resources._16pxPaste;
            this.PasteMenuItem.Name = "PasteMenuItem";
            this.PasteMenuItem.Size = new System.Drawing.Size(168, 22);
            this.PasteMenuItem.Text = "Paste";
            this.PasteMenuItem.Click += new System.EventHandler(this.PasteMenuItem_Click);
            // 
            // PasteSeperator
            // 
            this.PasteSeperator.Name = "PasteSeperator";
            this.PasteSeperator.Size = new System.Drawing.Size(165, 6);
            // 
            // MoveMenuItem
            // 
            this.MoveMenuItem.Image = global::BackupOrganizerGUI.Properties.Resources._64pxMove;
            this.MoveMenuItem.Name = "MoveMenuItem";
            this.MoveMenuItem.Size = new System.Drawing.Size(168, 22);
            this.MoveMenuItem.Text = "Move";
            this.MoveMenuItem.Click += new System.EventHandler(this.MoveMenuItem_Click);
            // 
            // RenameMenuItem
            // 
            this.RenameMenuItem.Image = global::BackupOrganizerGUI.Properties.Resources._16pxRename;
            this.RenameMenuItem.Name = "RenameMenuItem";
            this.RenameMenuItem.Size = new System.Drawing.Size(168, 22);
            this.RenameMenuItem.Text = "Rename";
            this.RenameMenuItem.Click += new System.EventHandler(this.RenameMenuItem_Click);
            // 
            // DeleteMenuItem
            // 
            this.DeleteMenuItem.Image = global::BackupOrganizerGUI.Properties.Resources._16pxTrash;
            this.DeleteMenuItem.Name = "DeleteMenuItem";
            this.DeleteMenuItem.Size = new System.Drawing.Size(168, 22);
            this.DeleteMenuItem.Text = "Delete";
            this.DeleteMenuItem.Click += new System.EventHandler(this.DeleteMenuItem_Click);
            // 
            // ItemExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GlobalContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemExplorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup Organizer";
            this.Load += new System.EventHandler(this.ItemExplorer_Load);
            this.GlobalContainer.ResumeLayout(false);
            this.GlobalContainer.PerformLayout();
            this.BottomContainer.ResumeLayout(false);
            this.BottomContainer.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel GlobalContainer;
        private System.Windows.Forms.TableLayoutPanel BottomContainer;
        private CustomDialogs.DarkLabel CloseSeperatorLabel;
        private System.Windows.Forms.Button ChangeKeyButton;
        private System.Windows.Forms.Button CreateSheetButton;
        private System.Windows.Forms.Button DeselectButton;
        private CustomDialogs.DarkLabel InformationSeperator;
        private System.Windows.Forms.Button MoveDownButton;
        private System.Windows.Forms.Button MoveUpButton;
        private System.Windows.Forms.Button CloseButton;

        private CustomDialogs.DarkContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem NewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewGroupMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewBackupFileMenuItem;
        private System.Windows.Forms.ToolStripSeparator NewSeperator;
        private System.Windows.Forms.ToolStripMenuItem ChangePasswordMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetLinkMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetPathInDriveMenuItem;
        private System.Windows.Forms.ToolStripSeparator SetPathInDriveSeperator;
        private System.Windows.Forms.ToolStripMenuItem CopyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteMenuItem;
        private System.Windows.Forms.ToolStripSeparator PasteSeperator;
        private System.Windows.Forms.ToolStripMenuItem RenameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MoveMenuItem;
        private System.Windows.Forms.Label AmountOfItemsLabel;
    }
}

