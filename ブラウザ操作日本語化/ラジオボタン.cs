using OpenQA.Selenium;

namespace ブラウザ操作日本語化;

/// <summary>
/// 操作するラジオボタンの基底クラス
/// </summary>
/// <remarks>
/// コンストラクタ
/// </remarks>
/// <param name="by">ラジオボタンのBy</param>
public class ラジオボタン(By by) : Web要素(by)
{
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
    public void 選択する()
    {
        // 選択する処理
        if (!element.Selected)
        {
            element.Click();
        }
    }

    // public String? 文字列
    // {
    //     get { return element.Text; }
    // }

    public Boolean 選択されている
    {
        get { return element.Selected; }
    }

    public Boolean 選択されていない
    {
        get { return !element.Selected; }
    }
}