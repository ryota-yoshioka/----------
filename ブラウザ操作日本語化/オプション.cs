using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ブラウザ操作日本語化;

/// <summary>
/// 操作するオプション（ドロップダウンの選択肢）の基底クラス
/// </summary>
public class オプション : Web要素
{
    private readonly ドロップダウン _親ドロップダウン;

    public オプション(ドロップダウン 親ドロップダウン, By by) : base(by)
    {
        this._親ドロップダウン = 親ドロップダウン;
    }

    public オプション(ドロップダウン 親ドロップダウン, IWebElement element) : base(element)
    {
        this._親ドロップダウン = 親ドロップダウン;
    }

    /// <summary>
    /// クリックする
    /// </summary>
    public void クリックする()
    {
        // クリックする処理
        element.Click();
    }

    /// <summary>
    /// 選択する
    /// </summary>
    public void 選択する(string 文字列)
    {
        // 選択する処理
        var select = new SelectElement(element);
        select.SelectByText(文字列);
    }

    /// <summary>
    /// 値で選択する
    /// </summary>
    public void 値で選択する(string 値)
    {
        // 選択する処理
        var select = new SelectElement(element);
        select.SelectByValue(値);
    }

    /// <summary>
    /// 順番で選択する
    /// </summary>
    public void 順番で選択する(int 順番)
    {
        // 選択する処理
        var select = new SelectElement(element);
        select.SelectByIndex(順番);
    }

    public String 文字列
    {
        get { return element.Text; }
    }

    public Boolean 選択されている
    {
        get { return element.Selected; }
    }

    public Boolean 選択されていない
    {
        get { return !element.Selected; }
    }
}