using OpenQA.Selenium.Chrome;

namespace ブラウザ操作日本語化;

public class Chromeブラウザ
{
    public static void 起動する()
    {
        // string userDataDir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        // Directory.CreateDirectory(userDataDir);
        var options = new ChromeOptions()
        {
            //BrowserVersion = null
        };
        // options.AddArgument($"--user-data-dir={userDataDir}");
        options.AddArgument("--no-sandbox");
        options.AddArgument("--disable-dev-shm-usage");
        Webユニットテスト.Webドライバ = new ChromeDriver(options);
    }

    public static void 終了する()
    {
        if (Webユニットテスト.Webドライバ == null)
        {
            return;
        }
        Webユニットテスト.Webドライバ.Quit();
    }
}