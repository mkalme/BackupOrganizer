using System;
using BinaryObjectFormat;

namespace BackupOrganizer {
    public sealed class BackupFile : Item {
        public override ItemID ID { get; protected set; } = ItemID.BackupFile;

        public string Password {
            get => _password;
            set {
                if (_password == value) return;

                _password = value;
                CallOnUpdate();
            }
        }
        private string _password = "";

        public bool Delete() {
            Parent.Items.Remove(this);

            return true;
        }

        public override ObjectTag Serialize() {
            ObjectTag output = base.Serialize();
            output.Add("Password", Password);

            return output;
        }
        public static BackupFile Deserialize(ObjectTag obj) {
            BackupFile output = new BackupFile();
            Deserialize(obj, output);

            output.Password = obj["Password"];

            return output;
        }

        public override Item Clone() {
            BackupFile output = new BackupFile();
            Copy(output);

            output.Password = Password;
            return output;
        }
    }
}
