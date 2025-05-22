using System;
using BinaryObjectFormat;

namespace BackupOrganizer {
    public abstract class Item {
        public virtual string Name {
            get => _name;
            set {
                if (_name == value) return;

                _name = value;
                CallOnUpdate();
            }
        }
        private string _name = "";

        public virtual string PathInDrive {
            get => _pathInDrive;
            set {
                if (_pathInDrive == value) return;

                _pathInDrive = value;
                CallOnUpdate();
            }
        }
        private string _pathInDrive = "";

        public virtual string Link {
            get => _link;
            set {
                if (_link == value) return;

                _link = value;
                CallOnUpdate();
            }
        }
        private string _link = "";

        public abstract ItemID ID { get; protected set; }
        public Group Parent { get; internal set; }

        public event EventHandler OnUpdate;
        public event EventHandler OnDelete;

        internal void CallOnUpdate() {
            if (OnUpdate != null) OnUpdate(this, EventArgs.Empty);
        }
        internal void CallOnDelete() {
            if (OnDelete != null) OnDelete(this, EventArgs.Empty);
        }

        public virtual ObjectTag Serialize() {
            return new ObjectTag() {
                { "ID", (byte)ID },
                { "Name", Name },
                { "PathInDrive", PathInDrive },
                { "Link", Link }
            };
        }
        public static void Deserialize(ObjectTag obj, Item output) {
            output.ID = (ItemID)(byte)obj["ID"];
            output.Name = obj["Name"];
            output.PathInDrive = obj["PathInDrive"];
            output.Link = obj["Link"];
        }

        public abstract Item Clone();
        protected virtual void Copy(Item output) {
            output.Name = Name;
            output.PathInDrive = PathInDrive;
            output.Link = Link;
        }
    }
}
