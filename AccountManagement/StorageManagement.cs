using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace AccountManagement;

public static class StorageManagement
{
    private const string  rootPath = @"C:\Temp";
    private static bool DirectoryExists { get; set; }
    
    public static void CreateDirectory(List<User> accounts)
    {
        DirectoryExists = Directory.Exists(rootPath + @"\UserManagement\Accounts.xlsx");
        if (!DirectoryExists)
        {
            Directory.CreateDirectory(rootPath + @"\UserManagement");
            File.Create(rootPath + @"\UserManagement\Accounts.xlsx").Close();
        }
        
        using var package = new ExcelPackage(new FileInfo(rootPath + @"\UserManagement\Accounts.xlsx"));
        
        var worksheet = package.Workbook.Worksheets.Add("UserManagement");
        
        worksheet.Cells["A1:B1"].Style.Font.Bold = true;
        worksheet.Cells["A1:B1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
        worksheet.Cells[1, 1].Value = "Username";
        worksheet.Cells[1, 2].Value = "Id";
        
        for (int i = 0; i < accounts.Count; i++)
        {
            worksheet.Cells[i + 2, 1].Value = accounts[i].UserName;
            worksheet.Cells[i + 2, 2].Value = accounts[i].Id;
        }

        package.Save();
    }
}