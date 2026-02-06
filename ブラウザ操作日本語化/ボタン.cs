using OpenQA.Selenium;

namespace ブラウザ操作日本語化;

/// <summary>
/// 操作するボタンの基底クラス
/// </summary>
/// <remarks>
/// コンストラクタ
/// </remarks>
/// <param name="by">ボタンのBy</param>
public class ボタン(By by) : Web要素(by)
{

    /// <summary>
    /// ボタンを押す
    /// </summary>
    public void 押す()
    {
        // ボタンを押す処理
        element.Click();
    }

    public string? 文字列 => element.Text;
}
