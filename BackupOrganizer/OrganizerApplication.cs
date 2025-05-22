using System;
using System.Text;
using CommonUtilities;

namespace BackupOrganizer {
    public class OrganizerApplication {
        public byte[] Key {
            get => CacheController.Key;
            set => CacheController.Key = value;
        }
        public string StoragePath => $"{AppDomain.CurrentDomain.BaseDirectory}\\Storage";
        public EncryptedFileController CacheController { get; private set; }

        public GroupResource RootResource { get; set; }

        public OrganizerApplication(byte[] key) {
            CacheController = new EncryptedFileController() {
                Directory = StoragePath,
                Key = key
            };

            RootResource = new GroupResource(CacheController);
            RootResource.Load();
        }

        public void CreateSheet(string path) {
            SheetUtilities.CreateSheet(RootResource.Root, path, Encoding.ASCII.GetString(Key));
        }
        public void ChangeKey(byte[] key) {
            Key = key;
            CacheController.SaveAll();
        }
    }
}
