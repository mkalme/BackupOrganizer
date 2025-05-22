using System;
using BinaryObjectFormat;
using CommonUtilities;

namespace BackupOrganizer {
    public class GroupResource : Serializeable {
        public Group Root { get; set; }

        public override string ResourceName { get; set; } = "Items";

        public GroupResource(IFileCacheController controller) : base(controller) { }

        public override ObjectTag Serialize() {
            return Root.Serialize();
        }

        public override void SetDefaultState() {
            Root = new Group() {
                Name = "Root"
            };
        }
        public override void SetState(ObjectTag obj) {
            Root = Group.Deserialize(obj);
        }
    }
}
