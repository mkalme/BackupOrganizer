using System;
using System.Collections.Generic;
using BackupOrganizer;
using CustomDialogs;

namespace BackupOrganizerGUI {
    public static class ItemSelectorUtilities {
        public static InputResult<IList<object>> ShowSelector(Group group, ItemSelectorProfile profile, Func<object, bool> viewableItemValidator) {
            ViewController viewController = new ViewController(new GroupViewNode(group));
            ItemSelectionGridControl gridViewControl = new ItemSelectionGridControl(viewableItemValidator) {
                ViewController = viewController
            };

            return CustomDialog.ShowItemSelector(viewController, gridViewControl, profile);
        }
    }
}
