using System;
using System.Collections.Generic;
using System.Media;
using CustomDialogs;
using BackupOrganizer;

namespace BackupOrganizerGUI {
    public static class ItemUtilities {
        public static void Move(IList<Item> items, Group currentGroup) {
            Func<object, bool> validator = thisItem => {
                if (((Item)thisItem).ID != ItemID.Group || items.Contains((Item)thisItem)) return false;
                return true;
            };

            InputResult<IList<object>> selectionResult = ItemSelectorUtilities.ShowSelector(currentGroup, new ItemSelectorProfile() {
                SelectedItemValidator = i => !items.Contains(i as Item) && i != currentGroup
            }, validator);

            if (selectionResult.DialogClosed || selectionResult.Value.Count < 1) return;

            currentGroup.Move(items, selectionResult.Value[0] as Group);
        }
        public static void EditItem(Item item) {
            string headerName = item.ID == ItemID.Group ? "Group" : "Backup file";

            InputResult<string> result = CustomDialog.ShowTextInput($"{headerName}'s name", $"Edit the {headerName.ToLower()}'s name.",
                item.Name, Properties.Resources._64pxRename);

            if (result.DialogClosed) return;

            if (string.IsNullOrEmpty(result.Value)) {
                CustomDialog.ShowError("Error", $"{headerName}'s name cannot be empty.");
            } else {
                item.Name = result.Value;
            }
        }
        public static void Delete(IList<Item> items, Group parent) {
            string result = CustomDialog.ShowMessage("Delete", "Are you sure you want to delete this?",
                Properties.Resources._64pxTrash, SystemSounds.Hand, "Delete", "No");

            if (result == "Delete") {
                DeleteGroupContents(parent, items);
            }
        }
        public static bool DeleteGroupContents(Group parent, IList<Item> items) {
            bool errorFree = true;

            for (int i = 0; i < items.Count; i++) {
                Item item = items[i];

                if (item.ID == ItemID.BackupFile) {
                    if (!(item as BackupFile).Delete()) {
                        errorFree = false;
                    }
                } else {
                    if (DeleteGroupContents(item as Group, (item as Group).Items)) {
                        parent.Items.Remove(item);
                    } else {
                        errorFree = false;
                    }
                }
            }

            return errorFree;
        }
        public static void SetNewPath(Item item, Group parent) {
            item.PathInDrive = item.Name;
            if (!string.IsNullOrEmpty(parent.PathInDrive)) {
                item.PathInDrive = $"{parent.PathInDrive}\\{item.PathInDrive}";
            }
        }

        public static void ChangePassword(BackupFile item) {
            var profile = PasswordGeneratorDialogProfile.NewPassword;
            profile.Title = $"Password | {item.Name}";
            profile.Message = $"{item.Name}'s password";
            profile.Password = item.Password;

            InputResult<string> result = CustomDialog.ShowPasswordGenerator(profile);
            if (result.DialogClosed) return;

            item.Password = result.Value;
        }
        public static void SetLink(Item item) {
            InputResult<string> result = CustomDialog.ShowTextInput($"{item.Name} | Link",
                "Edit item's link.", item.Link, Properties.Resources._64pxLink);
            if (result.DialogClosed) return;

            item.Link = result.Value;
        }
        public static void SetPath(Item item) {
            Func<string, bool> validator = path => {
                if (path.IsValidPath()) return true;

                CustomDialog.ShowError("Error", "Path is invalid.");
                return false;
            };

            InputResult<string> result = CustomDialog.ShowTextInput($"{item.Name} | Path in drive",
                "Edit item's path in drive.", item.PathInDrive, Properties.Resources._64pxTreeView, validator);
            if (result.DialogClosed) return;

            item.PathInDrive = result.Value;
        }

        public static void CreateSheet(OrganizerApplication application) {
            InputResult<string> pathResult = CustomDialog.ShowBrowser(BrowseType.SaveFile, "Zip files|*.7z");
            if (pathResult.DialogClosed) return;

            application.CreateSheet(pathResult.Value);
        }
        public static void ChangeKey(OrganizerApplication application) {
            InputResult<byte[]> keyResult = CustomDialog.ShowKeyInput(KeyExtensions.KeyValidator,
                "Current key", "Enter the current key");

            if (keyResult.DialogClosed) return;
            if (!keyResult.Value.KeyEquals(application.Key)) {
                CustomDialog.ShowError("Error", "The key is incorrect.");
                return;
            }

            InputResult<byte[]> newKeyResult = CustomDialog.ShowKeyGenerator();

            if (newKeyResult.DialogClosed) return;
            if (newKeyResult.Value.KeyEquals(application.Key)) {
                CustomDialog.ShowError("Error", "The key is the same.");
                return;
            }

            application.ChangeKey(newKeyResult.Value);

            CustomDialog.ShowMessage("Key changed", "Key changed successfully.", Properties.Resources._16pxKey, SystemSounds.Exclamation);
        }
    }
}
