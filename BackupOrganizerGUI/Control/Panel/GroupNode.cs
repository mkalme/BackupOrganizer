using System;
using BackupOrganizer;
using CustomDialogs;

namespace BackupOrganizerGUI {
    public class GroupNode : INode {
        public Group Group { get; set; }

        public INode Parent {
            get {
                if (_parent == null && Group.Parent != null) {
                    _parent = new GroupNode(Group.Parent);
                }

                return _parent;
            }
        }
        private INode _parent;

        public object Node => Group;

        public string DisplayText => Group.Name;

        public GroupNode(Group group) {
            Group = group;
        }
    }
}
