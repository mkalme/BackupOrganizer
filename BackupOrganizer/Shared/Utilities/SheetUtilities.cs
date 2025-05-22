using System;
using System.Collections.Generic;
using System.IO;
using ClosedXML.Excel;

namespace BackupOrganizer {
    static class SheetUtilities {
        public static void CreateSheet(Group group, string filePath, string password) {
            List<BackupFile> files = new List<BackupFile>();
            GetUpdateableItems(group, files);

            using (XLWorkbook workbook = GetWorkbook(files)) {
                string sourcePath = $"{AppDomain.CurrentDomain.BaseDirectory}\\Storage\\Temporary\\UserSheet.xlsx";
                if (File.Exists(sourcePath)) File.Delete(sourcePath);
                
                workbook.SaveAs(sourcePath);

                Zip.ZipFile(sourcePath, filePath, password);

                File.Delete(sourcePath);
            }
        }

        private static XLWorkbook GetWorkbook(List<BackupFile> files) {
            string[][] cells = new string[files.Count + 1][];
            cells[0] = new string[] { "Name", "Path in drive", "Password", "Link" };

            for (int i = 0; i < files.Count; i++) {
                cells[i + 1] = new string[] { files[i].Name, files[i].PathInDrive, files[i].Password, files[i].Link };
            }

            return CreateWorkbook(cells);
        }
        private static XLWorkbook CreateWorkbook(string[][] cells) {
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Data");

            for (int y = 0; y < cells.Length; y++) {
                string[] row = cells[y];

                for (int x = 0; x < row.Length; x++) {
                    var cell = worksheet.Cell(y + 1, x + 1);

                    cell.Value = row[x];
                    if (y == 0) {
                        cell.Style.Font.Bold = true;
                    }
                }
            }

            worksheet.Columns().AdjustToContents();

            return workbook;
        }

        private static void GetUpdateableItems(Group group, IList<BackupFile> output) {
            foreach (var item in group.Items) {
                if (item.ID == ItemID.Group) {
                    GetUpdateableItems(item as Group, output);
                } else {
                    output.Add(item as BackupFile);
                }
            }
        }
    }
}
