using OpenQA.Selenium;

namespace ブラウザ操作日本語化;

/// <summary>
/// 操作するアンカーの基底クラス
/// </summary>
/// <remarks>
/// コンストラクタ
/// </remarks>
/// <param name="by">アンカーのBy</param>
public class アンカー(By by) : Web要素(by)
{

    /// <summary>
    /// クリックする
    /// </summary>
    public void クリックする()
    {
        // クリックする処理
        element.Click();
    }

    public String? 文字列
    {
        get { return element.Text; }
    }
}