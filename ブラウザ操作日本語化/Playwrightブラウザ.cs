using Microsoft.Playwright;

namespace ブラウザ操作日本語化;

public class Playwrightブラウザ : ブラウザ
{
    private Playwrightブラウザ(IPlaywright ドライバ, IBrowserType ブラウザ, BrowserTypeLaunchOptions オプション)
        : base(new Playwrightドライバ(ドライバ, ブラウザ, オプション))
    {
        
    }

    public static Playwrightブラウザ Chromeを起動する()
    {
        var playwright = Playwright.CreateAsync().Result;
        var option = new BrowserTypeLaunchOptions { Channel = "chrome", Headless = false };
        return new Playwrightブラウザ(playwright, playwright.Chromium, option);
    }
    public static Playwrightブラウザ Edgeを起動する()
    {
        var playwright = Playwright.CreateAsync().Result;
        var option = new BrowserTypeLaunchOptions { Channel = "msedge", Headless = false };
        return new Playwrightブラウザ(playwright, playwright.Chromium, option);
    }
}