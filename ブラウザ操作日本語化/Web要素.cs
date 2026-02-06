using OpenQA.Selenium;

namespace ブラウザ操作日本語化;

public class Web要素
{
    protected readonly IWebElement element;

    public Web要素(By by)
    {
        this.element = Webドライバ.FindElement(by);
    }

    public Web要素(IWebElement element)
    {
        this.element = element;
    }

    public bool 有効である => element.Enabled;

    public bool 表示されている => element.Displayed;

    protected static IWebDriver Webドライバ
    {
        get { return Webユニットテスト.Webドライバ!; }
    }
}
