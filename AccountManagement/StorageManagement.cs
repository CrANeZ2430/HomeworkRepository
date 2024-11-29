using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace AccountManagement;

public static class StorageManagement
{
    private const string  RootPath = @"C:\Temp";
    private static bool FileExists { get; set; }
    
    public static void SaveUserAccounts(List<User> accounts)
    {
        FileExists = File.Exists(RootPath + @"\UserManagement\Accounts.xlsx");
        if (!FileExists)
        {
            Directory.CreateDirectory(RootPath + @"\UserManagement");
            File.Create(RootPath + @"\UserManagement\Accounts.xlsx").Close();
        }
        
        ExcelPackage.LicenseContext = LicenseContext.Commercial;
        using var package = new ExcelPackage(new FileInfo(RootPath + @"\UserManagement\Accounts.xlsx"));

        ExcelWorksheet worksheet;
        if (package.Workbook.Worksheets.Any(ws => ws.Name == "UserManagement"))
        {
            worksheet = package.Workbook.Worksheets["UserManagement"];
        }
        else
        {
            worksheet = package.Workbook.Worksheets.Add("UserManagement");
        }

        if (accounts.Count == 0)
        {
            MessageHandler.Error("You don't have data to save");
            return;
        }
        
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
        MessageHandler.Message("Data was saved successfully");
    }

    public static void GetUserAccounts(List<User> accounts)
    {
        FileExists = File.Exists(RootPath + @"\UserManagement\Accounts.xlsx");
        if (!FileExists)
        {
            MessageHandler.Error("You don't have file with accounts");
            return;
        }
        
        ExcelPackage.LicenseContext = LicenseContext.Commercial;
        using var package = new ExcelPackage(new FileInfo(RootPath + @"\UserManagement\Accounts.xlsx"));
        
        var worksheet = package.Workbook.Worksheets["UserManagement"];

        for (int i = 0; i < worksheet.Dimension.Rows - 1; i++)
        {
            string userName = worksheet.Cells[i + 2, 1].Text;
            if (userName == null)
            {
                break;
            }
            var temp = worksheet.Cells[i + 2, 2].Text;
            int id = int.Parse(temp);
            accounts.Add(new User(userName, id));
        }
        
        MessageHandler.Message("Data was downloaded successfully");
    }
}