using Microsoft.Playwright;

namespace ブラウザ操作日本語化;

public class Playwrightドライバ : ドライバーインターフェース, 画面インターフェース
{
    private readonly IPlaywright ドライバ;
    private readonly IBrowser ブラウザ;

    public Playwrightドライバ(IPlaywright ドライバ, IBrowserType ブラウザ, BrowserTypeLaunchOptions options)
    {
        this.ドライバ = ドライバ;
        this.ブラウザ = ブラウザ.LaunchAsync(options).Result;
        this.ブラウザ.NewPageAsync().Wait();
    }

    public 画面インターフェース 先頭画面 => this;

    public void 終了する()
    {
        ブラウザ.CloseAsync().Wait();
    }
    public void ナビゲートする(String url)
    {
        ページ.GotoAsync(url).Wait();
    }
    public int デフォルトの待機秒数 { get; set; }

    private IPage ページ => ブラウザ.Contexts[0].Pages[0];

    public String タイトル => ページ.TitleAsync().Result;
    public 画面要素インターフェース Idで要素を探す(string id)
    {
        return new Playwright要素(ページ.Locator($"#{id}"));
    }
    public 画面要素インターフェース Nameで要素を探す(string name)
    {
        return new Playwright要素(ページ.Locator($"name='{name}'"));
    }
    public 画面要素インターフェース TagNameで要素を探す(string tagName)
    {
        return new Playwright要素(ページ.Locator($"{tagName}"));
    }
}
