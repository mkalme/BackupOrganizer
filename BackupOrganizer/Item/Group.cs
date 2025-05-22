using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using BinaryObjectFormat;

namespace BackupOrganizer {
    public sealed class Group : Item {
        public override ItemID ID { get; protected set; } = ItemID.Group;
        public ObservableCollection<Item> Items { get; private set; }

        private bool _updateEventSuspended = false;

        public Group() {
            Items = new ObservableCollection<Item>();
            Items.CollectionChanged += CallCollectionContentsChanged;

            OnDelete += OnDeletion;
        }

        private void CallItemContentsChanged(object sender, EventArgs e) {
            CallOnUpdate();
        }
        private void CallCollectionContentsChanged(object sender, NotifyCollectionChangedEventArgs e) {
            if (_updateEventSuspended) return;

            if (e.Action != NotifyCollectionChangedAction.Move) {
                if (e.OldItems != null) {
                    e.OldItems.ForEach<Item>(x => {
                        x.OnUpdate -= CallItemContentsChanged;
                        x.Parent = null;

                        x.CallOnDelete();
                    });
                }
                if (e.NewItems != null) {
                    e.NewItems.ForEach<Item>(x => {
                        x.OnUpdate += CallItemContentsChanged;
                        x.Parent = this;
                    });
                }
            }

            CallOnUpdate();
        }

        private void OnDeletion(object sender, EventArgs e) {
            foreach (var item in Items) {
                item.CallOnDelete();
            }
        }

        public void Move(IEnumerable<Item> children, Group group) {
            _updateEventSuspended = true;

            foreach (var child in children) {
                Items.Remove(child);

                child.Parent = group;
                group.Items.Add(child);
            }

            _updateEventSuspended = false;
        }
        public void SwapChildItems(Item child, Item otherChild) {
            Items.Move(Items.IndexOf(child), Items.IndexOf(otherChild));
        }

        public override ObjectTag Serialize() {
            ObjectTag output = base.Serialize();

            ObjectTag[] items = new ObjectTag[Items.Count];
            for (int i = 0; i < Items.Count; i++) {
                items[i] = Items[i].Serialize();
            }

            output.Add("Items", items);

            return output;
        }
        public static Group Deserialize(ObjectTag obj) {
            Group output = new Group();
            Deserialize(obj, output);

            Tag[] tags = ((ArrayTag)obj["Items"]).As<Tag>();
            output.Items = new ObservableCollection<Item>();

            for (int i = 0; i < tags.Length; i++) {
                ObjectTag tag = tags[i] as ObjectTag;

                Item item;
                switch ((ItemID)(byte)tag["ID"]) {
                    case ItemID.Group:
                        item = Deserialize(tag);
                        break;
                    default:
                        item = BackupFile.Deserialize(tag);
                        break;
                }

                item.OnUpdate += output.CallItemContentsChanged;
                item.Parent = output;

                output.Items.Add(item);
            }

            output.Items.CollectionChanged += output.CallCollectionContentsChanged;

            return output;
        }

        public override Item Clone() {
            Group item = new Group();
            Copy(item);

            foreach (Item thisItem in Items) {
                item.Items.Add(thisItem.Clone());
            }

            return item;
        }
    }
}
