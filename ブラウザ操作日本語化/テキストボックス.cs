using OpenQA.Selenium;

namespace ブラウザ操作日本語化;

/// <summary>
/// 操作するテキストボックスの基底クラス
/// </summary>
/// <remarks>
/// コンストラクタ
/// </remarks>
/// <param name="by">テキストボックスのBy</param>
public class テキストボックス(By by) : Web要素(by)
{
    /// <summary>
    /// テキストを入力する
    /// </summary>
    /// <param name="text">入力するテキスト</param>
    public void 入力する(string text)
    {
        // テキストを入力する処理
        element.Clear();
        element.SendKeys(text);
    }

    public String? 文字列
    {
        set { element.Clear(); element.SendKeys(value!); }
        get { return element.GetAttribute("value"); }
    }
}