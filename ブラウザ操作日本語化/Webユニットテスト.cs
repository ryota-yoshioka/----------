using OpenQA.Selenium;

namespace ブラウザ操作日本語化;

public class Webユニットテスト
{
    private static IWebDriver? _Webドライバ;

    public static IWebDriver Webドライバ
    {
        get
        {
            if (_Webドライバ == null)
            {
                throw new InvalidOperationException("Webドライバが初期化されていません。");
            }
            return _Webドライバ!;
        }
        set
        {
            _Webドライバ = value;
        }
    }

    protected static TimeSpan 暗黙の待機時間
    {
        set
        {
            Webドライバ.Manage().Timeouts().ImplicitWait = value;
        }
    }
}