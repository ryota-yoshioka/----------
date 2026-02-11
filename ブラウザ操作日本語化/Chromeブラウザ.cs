using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ブラウザ操作日本語化;

/// <summary>
/// 使用するブラウザの選択（Chrome）
/// </summary>
public class Chromeブラウザ : ブラウザ
{
    public Chromeブラウザ() : this(new ChromeOptions())
    {
    }
    public Chromeブラウザ(ChromeOptions options) : base(new Chromeドライバ(options))
    {
    }

    public static Chromeブラウザ 起動する()
    {
        // DirectoryInfo userDataDir = Directory.CreateTempSubdirectory();
        // var options = new ChromeOptions()
        // {
        //     BrowserVersion = null
        // };
        // options.AddArgument($"--user-data-dir={userDataDir.FullName}");
        // options.AddArgument("--no-sandbox");
        // options.AddArgument("--disable-dev-shm-usage");
        // return new Chromeブラウザ(options);
        return new Chromeブラウザ();
    }
}